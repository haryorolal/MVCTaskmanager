using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;

namespace MVCTaskmanager.identity
{
    public class ApplicationUserManager: UserManager<ApplicationUser>
    {
        public ApplicationUserManager(
            ApplicationUserStore applicationUserStore, 
            IOptions<IdentityOptions> options, 
            IPasswordHasher<ApplicationUser> passwordHasher,
            IEnumerable<IPasswordValidator<ApplicationUser>> passwordValidators,
            IEnumerable<UserValidator<ApplicationUser>> userValidators,              
            ILookupNormalizer lookupNormalizer,
            IdentityErrorDescriber identityErrorDescriber, 
            IServiceProvider services, 
            ILogger<ApplicationUserManager>logger)
            : base(applicationUserStore, options, passwordHasher, userValidators, passwordValidators, lookupNormalizer, identityErrorDescriber, services, logger )
        {

        }
    }
}
