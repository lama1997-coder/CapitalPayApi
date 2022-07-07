using System;
using apiTest.Server;
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
            var list = await _capitalPayServices.GetAsync<IList<LocalModel>>(APINames.localUrl, isAuth: false);
           
            return list;
        }

        public async Task<IList<string>> role()
        {
            var list = await _capitalPayServices.GetAsync<IList<string>>(APINames.rolerUrl, isAuth: false);

            return list;
        }
        public async Task<IList<string>> cardBlockReason()
        {
            var list = await _capitalPayServices.GetAsync<List<string>>(APINames.cardBlockReason,isAuth: false);

            return list;
        }
        public async Task<IList<string>> cardTypes()
        {
            var list = await _capitalPayServices.GetAsync<List<string>>(APINames.cardTypeUrl,  isAuth: false);

            return list;
        }
        public async Task<IList<string>> currenciesCode()
        {
            var list = await _capitalPayServices.GetAsync<List<string>>(APINames.commonCurennyUrl,isAuth: false);

            return list;
        }
        public async Task<IList<string>> customerBlockReason()
        {
            var list = await _capitalPayServices.GetAsync<List<string>>(APINames.customerBlockReason, isAuth: false);

            return list;
        }
    }
}

