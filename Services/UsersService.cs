using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using MVCTaskmanager.identity;
using MVCTaskmanager.serviceContracts;
using MVCTaskmanager.viewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using MVCTaskmanager.Models;

namespace MVCTaskmanager.Services
{
    public class UsersService: IUsersService
    {
        private readonly ApplicationUserManager _applicationUserManager;
        private readonly ApplicationSignInManager _applicationSignInManager;
        private readonly AppSettings _appSettings;
        private readonly ApplicationDbContext _db;

        public UsersService(ApplicationUserManager applicationUserManager, ApplicationSignInManager applicationSignInManager, IOptions<AppSettings> appSettings, ApplicationDbContext applicationDbContext)
        {
            _applicationUserManager = applicationUserManager;
            _applicationSignInManager = applicationSignInManager;
            _appSettings = appSettings.Value;
            _db = applicationDbContext;
        }

        public async Task<ApplicationUser> Authenticate(LoginViewModel loginViewModel)
        {
            var result = await this._applicationSignInManager.PasswordSignInAsync(loginViewModel.userName, loginViewModel.Password, false, false);
            if (result.Succeeded)
            {
                var applicationUser = await _applicationUserManager.FindByNameAsync(loginViewModel.userName);
                applicationUser.PasswordHash = null;
                if (await this._applicationUserManager.IsInRoleAsync(applicationUser, "Admin")) applicationUser.Role = "Admin";
                else if (await this._applicationUserManager.IsInRoleAsync(applicationUser, "Employee")) applicationUser.Role = "Employee";

                //create token handler
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = System.Text.Encoding.ASCII.GetBytes(_appSettings.Secret);
                var tokenDescriptor = new SecurityTokenDescriptor()
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.Name, applicationUser.Id),
                        new Claim(ClaimTypes.Email, applicationUser.Email),
                        new Claim(ClaimTypes.Role, applicationUser.Role)
                    }),

                    Expires = DateTime.UtcNow.AddHours(8),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                    
                };
                var token = tokenHandler.CreateToken(tokenDescriptor);
                applicationUser.Token = tokenHandler.WriteToken(token);

                return applicationUser;
            }
            else
            {
                return null;
            }
        }

        public async Task<ApplicationUser> Register(SignUpViewModel signUpViewModel)
        {
            //Email,Mobile, DateOfBirth,Password,Gender, CountryID, ReceiveNewsLetters,Skills

            ApplicationUser applicationUser = new ApplicationUser();
            applicationUser.Id = Guid.NewGuid().ToString();
            applicationUser.Firstname = signUpViewModel.PersonName.Firstname;
            applicationUser.Lastname = signUpViewModel.PersonName.Lastname;
            applicationUser.DateOfBirth = Convert.ToDateTime(signUpViewModel.DateOfBirth);
            applicationUser.Gender = signUpViewModel.Gender;
            applicationUser.Email = signUpViewModel.Email;
            applicationUser.PhoneNumber = signUpViewModel.Mobile;
            applicationUser.ReceiveNewsLetters = signUpViewModel.ReceiveNewsLetters;
            applicationUser.CountryID = signUpViewModel.CountryID;            
            applicationUser.UserName = signUpViewModel.Email;
            applicationUser.Role = "Employee";

            var result = await this._applicationUserManager.CreateAsync(applicationUser, signUpViewModel.Password);

            if (result.Succeeded)
            {                
                var result2 = await this._applicationSignInManager.PasswordSignInAsync(signUpViewModel.Email, signUpViewModel.Password, false, false);

                if (result2.Succeeded)
                {
                    applicationUser.PasswordHash = null;

                    //create token handler
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var key = System.Text.Encoding.ASCII.GetBytes(_appSettings.Secret);
                    var tokenDescriptor = new SecurityTokenDescriptor()
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                        new Claim(ClaimTypes.Name, applicationUser.Id),
                        new Claim(ClaimTypes.Email, applicationUser.Email),
                        new Claim(ClaimTypes.Role, applicationUser.Role)
                        }),

                        Expires = DateTime.UtcNow.AddHours(8),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                    };

                    var token = tokenHandler.CreateToken(tokenDescriptor);
                    applicationUser.Token = tokenHandler.WriteToken(token);

                    //skills
                    foreach (var sk in signUpViewModel.Skills)
                    {
                        skills skill = new skills();
                        skill.skillsName = sk.skillsName;
                        skill.skillsLevel = sk.skillsLevel;
                        skill.Id = applicationUser.Id;
                        skill.ApplicationUser = null;
                        this._db.Skills.Add(skill);
                        this._db.SaveChanges();
                    }

                    return applicationUser;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        
    }

        public async Task<ApplicationUser> GetUserByEmail(string email)
        {
            return await this._applicationUserManager.FindByEmailAsync(email);
        }
    }
}
