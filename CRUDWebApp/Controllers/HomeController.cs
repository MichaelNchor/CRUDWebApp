using CRUDWebApp.Infrastructure.Interfaces;
using CRUDWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CRUDWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductsRepository _service;

        public HomeController(IProductsRepository service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            var products = _service.GetAllProducts();
            return View(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}