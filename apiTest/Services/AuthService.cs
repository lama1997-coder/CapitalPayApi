using apiTest.Model;
using apiTest.ViewModel;

namespace apiTest.Services
{
    public class AuthService
    {

        private readonly CapitalPayServices _capitalPayServices;

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


    }
}
