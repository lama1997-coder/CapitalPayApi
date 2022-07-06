<<<<<<< HEAD
﻿using apiTest.Model;
using apiTest.ViewModel;
=======
﻿using System.Security.Claims;
using System.Text;
using apiTest.Model;
using apiTest.ViewModel;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
>>>>>>> 3dd600a (Login)

namespace apiTest.Services
{
    public class AuthService
    {

        private readonly CapitalPayServices _capitalPayServices;
<<<<<<< HEAD

        public AuthService(CapitalPayServices capitalPayServices)
        {
            _capitalPayServices = capitalPayServices;
        }


        public  async Task< AuthModel> login(UserModel userModel)
        {

            var user = await _capitalPayServices.PostAsync<AuthModel, UserModel>("auth/login", userModel);

         

            var customer  = await _capitalPayServices.PostAsync<Customer,string>("customer","",token: user.tokenId);









            return customer;



        }


=======
        private readonly IConfiguration _configuration;


        public AuthService(CapitalPayServices capitalPayServices, IConfiguration configuration)
        {
            _capitalPayServices = capitalPayServices;
            _configuration = configuration;
        }


        public  async Task<CustomerModel> login(UserModel userModel)
        {
            var user = await _capitalPayServices.PostAsync<AuthModel, UserModel>("auth/login", userModel,isAuth:false);
            var userToken = user.tokenId;
            var customer  = await _capitalPayServices.GetAsync<CustomerModel>("customer",token: userToken);
            customer.token = GetToken(customer!, userToken.ToString());
            return customer;
        }


        private string GetToken(CustomerModel? customer ,string? userToken)
        {

            var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, customer.Id),
                    new Claim(type:"token",value:userToken),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                expires: DateTime.Now.AddHours(3),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

           return new JwtSecurityTokenHandler().WriteToken(token);

        }
>>>>>>> 3dd600a (Login)
    }
}
