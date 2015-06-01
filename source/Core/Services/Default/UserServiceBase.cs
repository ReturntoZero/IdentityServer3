﻿using IdentityServer3.Core.Models;
/*
 * Copyright 2014, 2015 Dominick Baier, Brock Allen
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *   http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace IdentityServer3.Core.Services.Default
{
    /// <summary>
    /// Base class implementation of IUserService with empty method implementations.
    /// </summary>
    public class UserServiceBase : IUserService
    {
        /// <summary>
        /// This method gets called before the login page is shown. This allows you to determine if the user should be authenticated by some out of band mechanism (e.g. client certificates or trusted headers).
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns>
        /// The authentication result or null to continue the flow.
        /// </returns>
        public virtual Task<AuthenticateResult> PreAuthenticateAsync(PreAuthenticationContext context)
        {
            return Task.FromResult<AuthenticateResult>(null);
        }

        /// <summary>
        /// This method gets called for local authentication (whenever the user uses the username and password dialog).
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns>
        /// The authentication result.
        /// </returns>
        public virtual Task<AuthenticateResult> AuthenticateLocalAsync(LocalAuthenticationContext context)
        {
            return Task.FromResult<AuthenticateResult>(null);
        }

        /// <summary>
        /// This method gets called when the user uses an external identity provider to authenticate.
        /// The user's identity from the external provider is passed via the `externalUser` parameter which contains the
        /// provider identifier, the provider's identifier for the user, and the claims from the provider for the external user.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns>
        /// The authentication result.
        /// </returns>
        public virtual Task<AuthenticateResult> AuthenticateExternalAsync(ExternalAuthenticationContext context)
        {
            return Task.FromResult<AuthenticateResult>(null);
        }

        /// <summary>
        /// This method gets called when the user signs out.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        public virtual Task SignOutAsync(SignOutContext context)
        {
            return Task.FromResult(0);
        }

        /// <summary>
        /// This method is called whenever claims about the user are requested (e.g. during token creation or via the userinfo endpoint)
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns>
        /// Claims for the subject
        /// </returns>
        public virtual Task<IEnumerable<Claim>> GetProfileDataAsync(ProfileDataRequestContext context)
        {
            return Task.FromResult<IEnumerable<Claim>>(Enumerable.Empty<Claim>());
        }

        /// <summary>
        /// This method gets called whenever identity server needs to determine if the user is valid or active (e.g. if the user's account has been deactivated since they logged in).
        /// (e.g. during token issuance or validation).
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns>
        ///   <c>true</c> if the user is still allowed to receive tokens; <c>false</c> otherwise.
        /// </returns>
        public virtual Task<bool> IsActiveAsync(Models.IsActiveContext context)
        {
            return Task.FromResult(false);
        }

        /// <summary>
        /// This method is called after a partial login. It allows the user service
        /// to replace the AuthenticateResult.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public virtual Task PostPartialLoginAsync(PostPartialLoginContext context)
        {
            return Task.FromResult(0);
        }
    }
}