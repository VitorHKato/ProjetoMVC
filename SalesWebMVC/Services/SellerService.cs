using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Data;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services
{
    public class SellerService
    {
        private readonly SalesWebMVCContext _context;

        public SellerService(SalesWebMVCContext c)
        {
            _context = c;
        }

        public List<Seller> FindAll()           //Retorna lista com todos os vendedores do banco
        {
            return _context.Seller.ToList();
        }
    }
}
