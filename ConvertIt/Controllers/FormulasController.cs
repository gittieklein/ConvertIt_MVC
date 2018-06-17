using ConvertIt.Models;
using ConvertIt.Models.Currency;
using ConvertIt.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConvertIt.Controllers
{
    public class FormulasController : Controller
    {
        ExchangeRateAPIService ExchangeRateAPIService = new ExchangeRateAPIService();

        public ActionResult Index()
        {
            FormulasModel rates = new FormulasModel();
            rates.Rates = GetRates();
            return View(rates);
        }

        public List<AllExchangeRates> GetRates()
        {
            return ExchangeRateAPIService.GetAllExchangeRates(new List<String> { "BRL", "GBP", "CAD", "CNY", "EUR", "INR", "ILS", "JPY", "MXN", "CHF", "USD" });
        }
    }
}


                                            