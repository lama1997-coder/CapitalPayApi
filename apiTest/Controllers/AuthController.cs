using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using apiTest.Model;
using System.Text.Json;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http.Headers;
using apiTest.Utilities;
using apiTest.Services;

namespace apiTest.Controllers
{
    [Route("api/")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly AuthService _authService;

        public AuthController(AuthService authService)
        {
            _authService = authService;
        }
        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync(UserModel userModel)
        {
           
            var response = await _authService.login(userModel);
            if (response!=null)
            {
                return Ok(
                new ResponseModel
                {
                    data = response,
                    statusCode = 200,
                    message = "Login Succesful",
                    status = true

                }); ;
            }


            return NotFound(
                new ResponseModel
                {
                    data = { },
                    statusCode = 404,
                    message = "Wrong user name or Password",
                    status = false

                }); ;
        }

        //get Customer Info
        [Authorize]
        [HttpGet("profile")]
        public async Task<IActionResult> CustomerInfo([FromHeader] string headerToken)
        {
            string apiUrl = "https://eval2d011.sandbox.e6tech.net/api/mobile/restful/v1/customer";

      
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization =
          new AuthenticationHeaderValue("Bearer",headerToken);
            HttpResponseMessage response = client.GetAsync(apiUrl).Result;

            var result = await response.Content.ReadFromJsonAsync<AuthModel>();
            if (response.IsSuccessStatusCode)
            {
                return Ok(
                new ResponseModel
                {
                    data = result!.tokenId,
                    statusCode = 200,
                    message = "Login Succesful",
                    status = true

                }); ;
            }


            return NotFound(
                new ResponseModel
                {
                    data = { },
                    statusCode = 404,
                    message = "Wrong user name or Password",
                    status = false

                }); ;
        }

    }
    }


