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
        public async Task<IActionResult> getCustomerBlockReason()
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


        [HttpGet("countries")]
        public async Task<IActionResult> getCountries()
        {
            var response = await _commonService.countries();
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




        [HttpGet("currencies/detail")]
        public async Task<IActionResult> getCurrencyDetails()
        {
            var response = await _commonService.listOfCurrency();
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




        [HttpGet("tx/sources")]
        public async Task<IActionResult> getTransactionSource()
        {
            var response = await _commonService.transactionSource();
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

        [HttpGet("tx/types")]
        public async Task<IActionResult> getTransactionType()
        {
            var response = await _commonService.transactionType();
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



        [HttpGet("address/types")]
        public async Task<IActionResult> getAddressTypes()
        {
            var response = await _commonService.addressTypes();
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


        [HttpGet("customer/event-types")]
        public async Task<IActionResult> getCustomerEventTypes()
        {
            var response = await _commonService.customerEventType();
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


        [HttpGet("email/types")]
        public async Task<IActionResult> getEmailType()
        {
            var response = await _commonService.emailType();
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

        [HttpGet("email/states")]
        public async Task<IActionResult> getEmailState()
        {
            var response = await _commonService.emailState();
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


        [HttpGet("genders")]
        public async Task<IActionResult> getGenders()
        {
            var response = await _commonService.gender();
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

        [HttpGet("officialid/types")]
        public async Task<IActionResult> getOfficialID()
        {
            var response = await _commonService.officialID();
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

        [HttpGet("partner/user/event-types")]
        public async Task<IActionResult> getPartnerEventType()
        {
            var response = await _commonService.partnetEventType();
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


        [HttpGet("phone/types")]
        public async Task<IActionResult> getPhoneType()
        {
            var response = await _commonService.phoneType();
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

