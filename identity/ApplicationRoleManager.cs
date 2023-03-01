using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic; 

namespace MVCTaskmanager.identity
{
    public class ApplicationRoleManager: RoleManager<IdentityRole>
    {
        public ApplicationRoleManager(
            ApplicationRoleStore applicationRoleStore, 
            IEnumerable<IRoleValidator<IdentityRole>> roleValidators, 
            ILookupNormalizer lookupNormalizer,
            IdentityErrorDescriber identityErrorDescriber, 
            ILogger<ApplicationRoleManager> logger) 
            : base(applicationRoleStore, roleValidators, lookupNormalizer, identityErrorDescriber, logger)
        {

        }
    }
}
