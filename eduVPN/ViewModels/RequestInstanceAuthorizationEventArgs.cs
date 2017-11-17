﻿/*
    eduVPN - End-user friendly VPN

    Copyright: 2017, The Commons Conservancy eduVPN Programme
    SPDX-License-Identifier: GPL-3.0+
*/

using eduOAuth;
using System;

namespace eduVPN.ViewModels
{
    /// <summary>
    /// RequestInstanceAuthorization event arguments
    /// </summary>
    public class RequestInstanceAuthorizationEventArgs : EventArgs
    {
        #region Properties

        /// <summary>
        /// Authenticating instance
        /// </summary>
        public Models.Instance Instance { get; }

        /// <summary>
        /// Requested access token scope
        /// </summary>
        public string Scope { get; }

        /// <summary>
        /// Access token
        /// </summary>
        /// <remarks>Should be populated by access token on event end, or <c>null</c> if authorization failed.</remarks>
        public AccessToken AccessToken { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs event arguments
        /// </summary>
        /// <param name="instance">Authenticating instance</param>
        /// <param name="scope">Requested access token scope</param>
        public RequestInstanceAuthorizationEventArgs(Models.Instance instance, string scope)
        {
            Instance = instance;
            Scope = scope;
        }

        #endregion
    }
}
