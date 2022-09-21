using Application.Enum;
using Application.Repository;
using Application.Struct;
using Application.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ConverterCurrencyService
    {
        public void Add(ConvertionCreateViewModel vm)
        {
            double amount = vm.Amount;
            int fromCurrency = vm.FromCurrency;
            int toCurrency = vm.ToCurrency;

            if (fromCurrency == (int)Currency.DOP && toCurrency == (int)Currency.USD)
            {
                ConvertionsRepository.Instance.convertion.ConvertionList.Add(new ResultConvertionViewModel { ConvertionResult = amount * Rates.DopToUSDRate + " United State Dollar" } );

            }
            else if (fromCurrency == (int)Currency.DOP && toCurrency == (int)Currency.EUR)
            {
                ConvertionsRepository.Instance.convertion.ConvertionList.Add(new ResultConvertionViewModel { ConvertionResult = amount * Rates.DopToEurRate + " Euros" });
            }
            else if (fromCurrency == (int)Currency.USD && toCurrency == (int)Currency.DOP)
            {
                ConvertionsRepository.Instance.convertion.ConvertionList.Add(new ResultConvertionViewModel { ConvertionResult = amount * Rates.USDToDopRate + " Dominican Pesos" });
            }
            else if (fromCurrency == (int)Currency.USD && toCurrency == (int)Currency.EUR)
            {
                ConvertionsRepository.Instance.convertion.ConvertionList.Add(new ResultConvertionViewModel { ConvertionResult = amount * Rates.USDToEurRate + " Euros" });
            }
            else if (fromCurrency == (int)Currency.EUR && toCurrency == (int)Currency.USD)
            {
                ConvertionsRepository.Instance.convertion.ConvertionList.Add(new ResultConvertionViewModel { ConvertionResult = amount * Rates.EurToUSDRate + " United State Dollar" });
            }
            else if (fromCurrency == (int)Currency.EUR && toCurrency == (int)Currency.DOP)
            {
                ConvertionsRepository.Instance.convertion.ConvertionList.Add(new ResultConvertionViewModel { ConvertionResult = amount * Rates.EurToDopRate + " Dominican Pesos" });
            }
            else if (fromCurrency == toCurrency)
            {
                ConvertionsRepository.Instance.convertion.ConvertionList.Add(new ResultConvertionViewModel { ConvertionResult = "Choose diferent coins" });
            }
            else
            {
                ConvertionsRepository.Instance.convertion.ConvertionList.Add(new ResultConvertionViewModel { ConvertionResult = "0.00" });
            }
        }

        public ConvertionListViewModel GetAll()
        {
            return ConvertionsRepository.Instance.convertion;
        }
    }
}
