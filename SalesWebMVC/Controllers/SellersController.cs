using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Services;

namespace SalesWebMVC.Controllers
{
    public class SellersController : Controller
    {

        private readonly SellerService _sellerService;

        public SellersController(SellerService s)
        {
            _sellerService = s;
        }

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();

            return View(list);                      //encaminha os dados para a view
        }
    }
}