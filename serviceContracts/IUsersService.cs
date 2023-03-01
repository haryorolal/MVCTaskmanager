using MVCTaskmanager.identity;
using MVCTaskmanager.viewModels;

namespace MVCTaskmanager.serviceContracts
{
    public interface IUsersService
    {
        Task<ApplicationUser> Authenticate(LoginViewModel loginViewModel);
        Task<ApplicationUser> Register(SignUpViewModel signUpViewModel);
        Task<ApplicationUser> GetUserByEmail(string email);
        
    }
}
