﻿/*
    eduVPN - End-user friendly VPN

    Copyright: 2017, The Commons Conservancy eduVPN Programme
    SPDX-License-Identifier: GPL-3.0+
*/

using eduOAuth;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Web;

namespace eduVPN.ViewModels
{
    /// <summary>
    /// Authorization pop-up
    /// </summary>
    public class AuthorizationPopup : Window
    {
        #region Fields

        /// <summary>
        /// OAuth pending authorization grant
        /// </summary>
        private AuthorizationGrant _authorization_grant;

        /// <summary>
        /// Registered client redirect callback URI (endpoint)
        /// </summary>
        private readonly string _redirect_endpoint = "org.eduvpn.app:/api/callback";

        #endregion

        #region Properties

        /// <summary>
        /// Authenticating eduVPN instance
        /// </summary>
        /// <remarks><c>null</c> if none selected.</remarks>
        public Models.InstanceInfo AuthenticatingInstance
        {
            get { return _authenticating_instance; }
            set {
                _authenticating_instance = value;
                RaisePropertyChanged();
                RetryAuthorization.RaiseCanExecuteChanged();
            }
        }
        private Models.InstanceInfo _authenticating_instance;

        /// <summary>
        /// OAuth access token
        /// </summary>
        public AccessToken AccessToken
        {
            get { return _access_token; }
            set { _access_token = value; RaisePropertyChanged(); }
        }
        private AccessToken _access_token;

        /// <summary>
        /// Request authorization command
        /// </summary>
        public DelegateCommand<Models.InstanceInfo> RequestAuthorization
        {
            get
            {
                lock (_request_authorization_lock)
                {
                    if (_request_authorization == null)
                        _request_authorization = new DelegateCommand<Models.InstanceInfo>(
                            // execute
                            param =>
                            {
                                AuthenticatingInstance = param;

                                // Let retry authorization command do the job.
                                if (RetryAuthorization.CanExecute(null))
                                    RetryAuthorization.Execute(null);
                            },

                            // canExecute
                            param => param is Models.InstanceInfo);

                    return _request_authorization;
                }
            }
        }
        private DelegateCommand<Models.InstanceInfo> _request_authorization;
        private object _request_authorization_lock = new object();

        /// <summary>
        /// Retry authorization command
        /// </summary>
        public DelegateCommand<Models.InstanceInfo> RetryAuthorization
        {
            get
            {
                lock (_retry_authorization_lock)
                {
                    if (_retry_authorization == null)
                        _retry_authorization = new DelegateCommand<Models.InstanceInfo>(
                            // execute
                            param =>
                            {
                                Error = null;
                                ChangeTaskCount(+1);
                                try
                                {
                                    // Prepare new authorization grant.
                                    _authorization_grant = new AuthorizationGrant()
                                    {
                                        AuthorizationEndpoint = AuthenticatingInstance.GetEndpoints(Abort.Token).AuthorizationEndpoint,
                                        RedirectEndpoint = new Uri(_redirect_endpoint),
                                        ClientID = "org.eduvpn.app",
                                        Scope = new List<string>() { "config" },
                                        CodeChallengeAlgorithm = AuthorizationGrant.CodeChallengeAlgorithmType.S256
                                    };

                                    // Open authorization request in the browser.
                                    System.Diagnostics.Process.Start(_authorization_grant.AuthorizationURI.ToString());
                                }
                                catch (Exception ex) { Error = ex; }
                                finally { ChangeTaskCount(-1); }
                            },

                            // canExecute
                            param => AuthenticatingInstance != null);

                    return _retry_authorization;
                }
            }
        }
        private DelegateCommand<Models.InstanceInfo> _retry_authorization;
        private object _retry_authorization_lock = new object();

        /// <summary>
        /// Authorize command
        /// </summary>
        public DelegateCommand<string> Authorize
        {
            get
            {
                lock (_authorize_lock)
                {
                    if (_authorize == null)
                        _authorize = new DelegateCommand<string>(
                            // execute
                            async param =>
                            {
                                Error = null;
                                ChangeTaskCount(+1);
                                try
                                {
                                    // Process response and get access token.
                                    AccessToken = await _authorization_grant.ProcessResponseAsync(
                                        HttpUtility.ParseQueryString(new Uri(param).Query),
                                        AuthenticatingInstance.GetEndpoints(Abort.Token).TokenEndpoint,
                                        null,
                                        Abort.Token);
                                }
                                catch (Exception ex) { Error = ex; }
                                finally { ChangeTaskCount(-1); }
                            },

                            // canExecute
                            param =>
                            {
                                Uri uri;

                                // URI must be:
                                // - non-NULL
                                if (param == null) return false;
                                // - Valid URI (parsable)
                                try { uri = new Uri(param); }
                                catch (Exception) { return false; }
                                // - Must match the redirect endpoint provided in request.
                                if (uri.Scheme + ":" + uri.AbsolutePath != _redirect_endpoint) return false;

                                return true;
                            });

                    return _authorize;
                }
            }
        }
        private DelegateCommand<string> _authorize;
        private object _authorize_lock = new object();

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs an authorization pop-up.
        /// </summary>
        public AuthorizationPopup()
        {
        }

        #endregion
    }
}
