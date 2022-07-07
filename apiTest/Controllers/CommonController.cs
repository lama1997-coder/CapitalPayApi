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
        public async Task<IActionResult> getLocal()
        {
            var response = await _commonService.local();
            if (response != null)
            {
                return Ok(
                new ResponseModel
                {
                    data = response,
                    statusCode = 200,
                    message = "Succesful",
                    status = true

                }); ;
            }
            return Unauthorized(
                new ResponseModel
                {
                    data = { },
                    statusCode = 404,
                    message = "error",
                    status = false

                }); ;
        }

        [HttpGet("roles")]
        public async Task<IActionResult> getRole()
        {
            var response = await _commonService.role();
            if (response != null)
            {
                return Ok(
                new ResponseModel
                {
                    data = response,
                    statusCode = 200,
                    message = "Succesful",
                    status = true

                }); ;
            }
            return Unauthorized(
                new ResponseModel
                {
                    data = { },
                    statusCode = 404,
                    message = "error",
                    status = false

                }); ;
        }

        [HttpGet("card/block/reasons")]
        public async Task<IActionResult> getcardBlockReason()
        {
            var response = await _commonService.cardBlockReason();
            if (response != null)
            {
                return Ok(
                new ResponseModel
                {
                    data = response,
                    statusCode = 200,
                    message = "Succesful",
                    status = true

                }); ;
            }
            return Unauthorized(
                new ResponseModel
                {
                    data = { },
                    statusCode = 404,
                    message = "error",
                    status = false

                }); ;
        }

        [HttpGet("card/types")]
        public async Task<IActionResult> getcardTypes()
        {
            var response = await _commonService.cardTypes();
            if (response != null)
            {
                return Ok(
                new ResponseModel
                {
                    data = response,
                    statusCode = 200,
                    message = "Succesful",
                    status = true

                }); ;
            }
            return Unauthorized(
                new ResponseModel
                {
                    data = { },
                    statusCode = 404,
                    message = "error",
                    status = false

                }); ;
        }

        [HttpGet("currencies")]
        public async Task<IActionResult> getcurrenciesCode()
        {
            var response = await _commonService.currenciesCode();
            if (response != null)
            {
                return Ok(
                new ResponseModel
                {
                    data = response,
                    statusCode = 200,
                    message = "Succesful",
                    status = true

                }); ;
            }
            return Unauthorized(
                new ResponseModel
                {
                    data = { },
                    statusCode = 404,
                    message = "error",
                    status = false

                }); ;
        }

        [HttpGet("customer/block/reasons")]
        public async Task<IActionResult> getcustomerBlockReason()
        {
            var response = await _commonService.customerBlockReason();
            if (response != null)
            {
                return Ok(
                new ResponseModel
                {
                    data = response,
                    statusCode = 200,
                    message = "Succesful",
                    status = true

                }); ;
            }
            return Unauthorized(
                new ResponseModel
                {
                    data = { },
                    statusCode = 404,
                    message = "error",
                    status = false

                }); ;
        }
    }


}

