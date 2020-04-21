using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]                              //Ação de Post (não de get)
        [ValidateAntiForgeryToken]              //Aumenta a segurança
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));         //redireciona a tela para o Index
        }
    }
}