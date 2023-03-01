using Microsoft.AspNetCore.Identity;
using MVCTaskmanager.identity;

namespace MVCTaskmanager.Seed
{
    public static class seedData
    {
        public static void Seed(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            SeedRole(roleManager);
            
            SeedUser(userManager);
            
            
        }

        private static void SeedRole(RoleManager<IdentityRole> roleManager)
        {
            //Create Admin Role
            bool AdminroleExist = roleManager.RoleExistsAsync("Admin").Result;
            if (!AdminroleExist)
            {
                //ApplicationRole role = new ApplicationRole
                IdentityRole role = new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Admin",
                };
                roleManager.CreateAsync(role).Wait();
            }

            //Create Employee Role
            bool EmployeeroleExist = roleManager.RoleExistsAsync("Employee").Result;
            if (!EmployeeroleExist)
            {
                //ApplicationRole role = new ApplicationRole
                IdentityRole role = new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Employee"
                };
                roleManager.CreateAsync(role).Wait();
            }

        }

        private static void SeedUser(UserManager<ApplicationUser> userManager)
        {
            //Create Admin User
                var defaultUser = new ApplicationUser
                {
                    Id = Guid.NewGuid().ToString(),
                    UserName = "admin",
                    Email = "admin@gmail.com",
                    Firstname = "Admin",
                    Lastname = "Admin",
                    Gender = "Male",
                    DateOfBirth = DateTime.Now,
                    CountryID = 2,
                    ReceiveNewsLetters = false,
                    EmailConfirmed = true
                };

                if(userManager.Users.All(user => user.Id != defaultUser.Id))
                {
                    var user = userManager.FindByEmailAsync(defaultUser.Email).Result;
                    if(user == null)
                    {
                        userManager.CreateAsync(defaultUser, "@Ayodele1" ).Wait();
                        userManager.AddToRoleAsync(defaultUser, "Admin" ).Wait();                                                                       
                    }
                }              
            

        }

       

        
    }
}
