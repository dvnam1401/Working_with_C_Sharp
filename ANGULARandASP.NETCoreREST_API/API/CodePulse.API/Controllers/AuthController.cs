﻿using CodePulse.API.Models.DTO;
using CodePulse.API.Repositories.Inteface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CodePulse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly ITokenRespository tokenRespository;

        public AuthController(UserManager<IdentityUser> userManager,
            ITokenRespository tokenRespository)
        {
            this.userManager = userManager;
            this.tokenRespository = tokenRespository;
        }

        [HttpPost] //api/auth/login
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var identityUser = await userManager.FindByEmailAsync(request.Email);
            if (identityUser is not null)
            {
                //Check password
                var checkPasswordResult = await userManager.CheckPasswordAsync(identityUser, request.Password);
                if (checkPasswordResult)
                {
                    var roles = await userManager.GetRolesAsync(identityUser);
                    //Create a token and response
                    var jwtToken = tokenRespository.CreateJwtToken(identityUser, roles.ToList());
                    var response = new LoginResponseDto()
                    {
                        Email = request.Email,
                        Roles = roles.ToList(),
                        Token = jwtToken,
                    };
                    return Ok(response);
                }
            }
            ModelState.AddModelError("", "Email or password incorrect");
            return ValidationProblem(ModelState);
        }
        //POST: api/auth/register
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto request)
        {
            // create identityuser object
            var user = new IdentityUser
            {
                UserName = request.Email?.Trim(),
                Email = request.Email?.Trim()
            };
            // create user
            var identityResult = await userManager.CreateAsync(user, request.Password);

            if (identityResult.Succeeded)
            {
                //Add role to user (reader)
                identityResult = await userManager.AddToRoleAsync(user, "Reader");
                if (identityResult.Succeeded)
                {
                    return Ok();
                }
                else
                {
                    if (identityResult.Errors.Any())
                    {
                        foreach (var error in identityResult.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }
                }
            }
            else
            {
                if (identityResult.Errors.Any())
                {
                    foreach (var error in identityResult.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }

            }
            return ValidationProblem(ModelState);
        }
    }
}
