﻿using Microsoft.AspNetCore.Mvc;
using AspNetSampleMvcApp.Models;
using AspNetSample.Core.Abstractions;
using AutoMapper;
using AspNetSample.Core.DataTransferObjects;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace AspNetSampleMvcApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;

        public AccountController(IUserService userService,
            IMapper mapper, IRoleService roleService)
        {
            _userService = userService;
            _mapper = mapper;
            _roleService = roleService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                var userRoleId = await _roleService.GetRoleIdByNameAsync("User");
                var userDto = _mapper.Map<UserDto>(model);
                if (userDto != null && userRoleId != null)
                {
                    userDto.RoleId = userRoleId.Value;
                    var result = await _userService.RegisterUser(userDto);
                    if (result > 0)
                    {
                        await Authenticate(model.Email);
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View(model);
        }

        [HttpPost]
        public IActionResult CheckEmail(string email)
        {
            if (email.ToLowerInvariant().Equals("test@email.com"))
            {
                return Ok(false);
            }
            return Ok(true);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            var isPasswordCorrect = await _userService.CheckUserPassword(model.Email, model.Password);
            if (isPasswordCorrect)
            {
                await Authenticate(model.Email);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

        private async Task Authenticate(string email)
        {
            var userDto = await _userService.GetUserByEmailAsync(email);

            var claims = new List<Claim>()
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userDto.Email),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, userDto.RoleName)
            };

            var identity = new ClaimsIdentity(claims,
                "ApplicationCookie",
                ClaimsIdentity.DefaultNameClaimType,
                ClaimsIdentity.DefaultRoleClaimType
            );

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(identity));
        }
    }
}
