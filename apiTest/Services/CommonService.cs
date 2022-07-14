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

        public async Task<IList<string>> addressTypes()
        {
            var list = await _capitalPayServices.GetAsync<List<string>>(APINames.addressType, isAuth: false);

            return list;
        }
        public async Task<IList<string>> customerEventType()
        {
            var list = await _capitalPayServices.GetAsync<List<string>>(APINames.customerEventType, isAuth: false);

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
        public async Task<IList<string>> emailType()
        {
            var list = await _capitalPayServices.GetAsync<List<string>>(APINames.emailType, isAuth: false);

            return list;
        }

        public async Task<IList<string>> emailState()
        {
            var list = await _capitalPayServices.GetAsync<List<string>>(APINames.emailState, isAuth: false);

            return list;
        }
        public async Task<IList<string>> gender()
        {
            var list = await _capitalPayServices.GetAsync<List<string>>(APINames.gender, isAuth: false);

            return list;
        }

        public async Task<IList<string>> officialID()
        {
            var list = await _capitalPayServices.GetAsync<List<string>>(APINames.officialIdType, isAuth: false);

            return list;
        }

        public async Task<IList<string>> partnetEventType()
        {
            var list = await _capitalPayServices.GetAsync<List<string>>(APINames.partnerEventType, isAuth: false);

            return list;
        }

        public async Task<IList<string>> phoneType()
        {
            var list = await _capitalPayServices.GetAsync<List<string>>(APINames.phoneType, isAuth: false);

            return list;
        }

        public async Task<IList<CountriesModel>> countries()
        {
            var list = await _capitalPayServices.GetAsync<List<CountriesModel>>(APINames.countries, isAuth: false);

            return list;
        }

        public async Task<IList<CurrencyModel>> listOfCurrency()
        {
            var list = await _capitalPayServices.GetAsync<List<CurrencyModel>>(APINames.listOfCurrency, isAuth: false);

            return list;
        }


        public async Task<IList<CountriesModel>> transactionSource()
        {
            var list = await _capitalPayServices.GetAsync<List<CountriesModel>>(APINames.transactionSource, isAuth: false);

            return list;
        }


        public async Task<IList<CountriesModel>> transactionType()
        {
            var list = await _capitalPayServices.GetAsync<List<CountriesModel>>(APINames.transactionType, isAuth: false);

            return list;
        }

    }
}

