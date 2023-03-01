using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace MVCTaskmanager.identity
{
    public class ApplicationSignInManager: SignInManager<ApplicationUser>
    {
        public ApplicationSignInManager(
            ApplicationUserManager applicationUserManager, 
            IHttpContextAccessor httpContextAccessor, 
            IUserClaimsPrincipalFactory<ApplicationUser> userClaimsPrincipalFactory,
            IOptions<IdentityOptions> options, 
            ILogger<ApplicationSignInManager> logger, 
            IAuthenticationSchemeProvider authenticationScheme, 
            IUserConfirmation<ApplicationUser> userConfirmation) 
            : base(applicationUserManager, httpContextAccessor, userClaimsPrincipalFactory, options, logger, authenticationScheme, userConfirmation)
        {

        }
    }
}
