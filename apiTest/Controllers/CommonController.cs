using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiTest.Model;
using apiTest.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace apiTest.Controllers
{
    [Authorize]
    [Route("api/common")]
    [ApiController]

    public class CommonController : Controller
    {
        private readonly CommonService _commonService;

        public CommonController(CommonService commonService)
        {
            _commonService = commonService;
        }
       
        [HttpGet("locales")]
        public async Task< IActionResult> getLocal()
        {
            var response = await _commonService.local();
            if (response != null)
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


            return Unauthorized(
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

