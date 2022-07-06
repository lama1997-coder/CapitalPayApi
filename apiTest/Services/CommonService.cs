using System;
using apiTest.ViewModel;

namespace apiTest.Services
{
    public class CommonService
    {
        private readonly CapitalPayServices _capitalPayServices;
        public CommonService(CapitalPayServices capitalPayServices)
        {
            _capitalPayServices = capitalPayServices;
        }
        public async Task<IList<LocalModel>>local()
        {
            var list = await _capitalPayServices.GetAsync<IList<LocalModel>>("common/locales",isAuth: false);
           
            return list;
        }

        public async Task<LocalModel> role()
        {
            var list = await _capitalPayServices.PostAsync<LocalModel, string>("common/roles", "", isAuth: false);

            return list;
        }
        public async Task<LocalModel> cardBlockReason()
        {
            var list = await _capitalPayServices.PostAsync<LocalModel, string>("common/card/block/reasons", "", isAuth: false);

            return list;
        }
        public async Task<LocalModel> cardTypes()
        {
            var list = await _capitalPayServices.PostAsync<LocalModel, string>("common/card/types", "", isAuth: false);

            return list;
        }
        public async Task<LocalModel> currenciesCode()
        {
            var list = await _capitalPayServices.PostAsync<LocalModel, string>("common/currencies", "", isAuth: false);

            return list;
        }
        public async Task<LocalModel> customerBlockReason()
        {
            var list = await _capitalPayServices.PostAsync<LocalModel, string>("common/customer/block/reasons", "", isAuth: false);

            return list;
        }
    }
}

