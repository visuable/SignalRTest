using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using SignalRTest.Models;
using SignalRTest.Services;
using SignalRTest.ViewModels;

namespace SignalRTest.Controllers
{
    public class AccountController : Controller
    {
        private IMapper _mapper;
        private IDbManager _manager;
        public AccountController(IMapper mapper, IDbManager manager)
        {
            _mapper = mapper;
            _manager = manager;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register([FromForm]ViewRegisterModel model)
        {
            var dbModel = _mapper.Map<RegisterModel>(model);
            var result = _manager.Register(dbModel);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Login([FromForm]ViewLoginModel model)
        {
            var dbModel = _mapper.Map<LoginModel>(model);
            var result = _manager.Login(dbModel);
            if (result == null)
            {
                return BadRequest();
            }

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, result.FirstName),
                new Claim(ClaimTypes.Surname, result.LastName)
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
            await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Ok(result);
        }
    }
}
