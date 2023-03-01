using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace MVCTaskmanager.identity
{
    public class ApplicationUserStore: UserStore<ApplicationUser>
    {
        public ApplicationUserStore(ApplicationDbContext applicationDbContext): base(applicationDbContext)
        {

        }
    }
}
