using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace MVCTaskmanager.identity
{
    public class ApplicationRoleStore: RoleStore<IdentityRole, ApplicationDbContext>
    {
        public ApplicationRoleStore(
            ApplicationDbContext applicationDbContext, 
            IdentityErrorDescriber identityErrorDescriber)
            : base(applicationDbContext, identityErrorDescriber)
        {

        }
    }
}
