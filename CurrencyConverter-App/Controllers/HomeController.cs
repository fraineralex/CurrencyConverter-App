using CurrencyConverter_App.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Application.Services;
using Application.ViewModel;

namespace CurrencyConverter_App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ConverterCurrencyService _converterCurrencyService;

        public HomeController()
        {
            _converterCurrencyService = new ConverterCurrencyService();
        }
        public IActionResult Index()
        {
            return View(_converterCurrencyService.GetAll());
        }

        [HttpPost]
        public IActionResult GetConvertion(ConvertionCreateViewModel vm)
        {
            _converterCurrencyService.Add(vm);
            return RedirectToRoute(new { controller = "Home", action = "Index" });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}