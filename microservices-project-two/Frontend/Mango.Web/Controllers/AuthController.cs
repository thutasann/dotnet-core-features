using Mango.Web.Models;
using Mango.Web.Service.IService;
using Mango.Web.Utils;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace Mango.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly ILogger<AuthController> _logger;
        private readonly IAuthService _authService;
        private readonly ITokenProvider _tokenProvider;

        public AuthController(ILogger<AuthController> logger, IAuthService authService, ITokenProvider tokenProvider)
        {
            _logger = logger;
            _authService = authService;
            _tokenProvider = tokenProvider;
        }

        public IActionResult Login()
        {
            LoginRequestDto loginRequestDto = new();
            return View(loginRequestDto);
        }

        public IActionResult Register()
        {
            var roleList = new List<SelectListItem>()
            {
                new() {Text = SD.RoleAdmin, Value = SD.RoleAdmin},
                new() {Text = SD.RoleCustomer, Value = SD.RoleCustomer}
            };
            ViewBag.RoleList = roleList;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginRequestDto obj)
        {
            ResponseDto result = await _authService.LoginAsync(obj);

            if (result != null && result.IsSuccess)
            {
                LoginResponseDto? loginResponseDto = JsonConvert.DeserializeObject<LoginResponseDto>(Convert.ToString(result.Data)!);
                _tokenProvider.SetToken(loginResponseDto?.Token!);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("CustomError", result!.Message!);
                return View(obj);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterRequestDto registerRequestDto)
        {
            ResponseDto result = await _authService.RegisterAsync(registerRequestDto);
            _logger.LogInformation("register result => " + result.IsSuccess);
            ResponseDto assignRole;

            if (result != null && result.IsSuccess)
            {
                if (string.IsNullOrEmpty(registerRequestDto.Role))
                {
                    registerRequestDto.Role = SD.RoleCustomer;
                }
                assignRole = await _authService.AssignRoleAsync(registerRequestDto);
                if (assignRole != null && assignRole.IsSuccess)
                {
                    TempData["success"] = "Registration Successful";
                    return RedirectToAction(nameof(Login));
                }
            }
            else
            {
                TempData["error"] = result?.Message;
            }

            var roleList = new List<SelectListItem>()
            {
                new() {Text = SD.RoleAdmin, Value = SD.RoleAdmin},
                new() {Text = SD.RoleCustomer, Value = SD.RoleCustomer}
            };
            ViewBag.RoleList = roleList;
            return View(registerRequestDto);
        }

        public IActionResult Logout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

    }
}