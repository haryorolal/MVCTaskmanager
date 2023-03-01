using Microsoft.AspNetCore.Antiforgery;
using Microsoft.AspNetCore.Mvc;
using MVCTaskmanager.identity;
using MVCTaskmanager.serviceContracts;
using MVCTaskmanager.viewModels;

namespace TaskManagerMVC.Controllers
{
    [ApiController]
    public class AccountController : Controller
    {
        private IUsersService _usersService;
        private readonly IAntiforgery _antiforgery;
        private readonly ApplicationSignInManager _applicationSignInManager;
        public AccountController(IUsersService usersService, ApplicationSignInManager applicationSignInManager, IAntiforgery antiforgery)
        {
            _usersService = usersService;
            _applicationSignInManager = applicationSignInManager;
            _antiforgery = antiforgery;
        }

        [HttpPost]
        [Route("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] LoginViewModel loginViewModel)
        {
            if(loginViewModel.userName != null && loginViewModel.Password != null)
            {
                var user = await _usersService.Authenticate(loginViewModel);
                if (user == null)
                {
                    return BadRequest(new { message = "Username or password is incorrect" });

                }
                // Antiforgery
                HttpContext.User = await _applicationSignInManager.CreateUserPrincipalAsync(user);
                var tokens = _antiforgery.GetAndStoreTokens(HttpContext);
                Response.Headers.Add("XSRF-REQUEST-TOKEN", tokens.RequestToken);
                Response.Headers.Add("Access-Control-Expose-Headers", "XSRF-REQUEST-TOKEN");

                return Ok(user);
            }
            else
            {
                return BadRequest(new { message = "Username and password is incorrect" });
            }
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] SignUpViewModel signUpViewModel)
        {
            var user = await _usersService.Register(signUpViewModel);
            if (user == null)
            {
                return BadRequest(new { message = "Invalid Data" });

            }
            // Antiforgery
            HttpContext.User = await _applicationSignInManager.CreateUserPrincipalAsync(user);
            var tokens = _antiforgery.GetAndStoreTokens(HttpContext);
            Response.Headers.Add("XSRF-REQUEST-TOKEN", tokens.RequestToken);
            Response.Headers.Add("Access-Control-Expose-Headers", "XSRF-REQUEST-TOKEN");

            return Ok(user);
        }

        [HttpGet]
        [Route("api/getUserByEmail/{email}")]
        public async Task<IActionResult> GetUserByEmail(string email)
        {
            var user = await _usersService.GetUserByEmail(email);
            
            return Ok(user);
        }
    }
}
