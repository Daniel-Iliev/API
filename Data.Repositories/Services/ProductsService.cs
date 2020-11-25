using Data.AppDBContext;
using Data.Services.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Data.Services.Services
{
    public class ProductsService
    {
        private readonly DBContext applicationDb;

        public ProductsService(DBContext applicationDb)
        {
            this.applicationDb = applicationDb;
        }
        public List<ProductDto> GetAll()
        {
            using (applicationDb)
            {
                return applicationDb.Products.Select(x => new ProductDto()
                {
                    ProdName = x.ProdName,
                    ProdPrice = x.ProdPrice
                }).ToList();
            }
        }
        public void GetTopSelling(int year, int month)
        {
            using (applicationDb)
            {
                var sellers = applicationDb.Orders
                    .Include(x => x.Products)
                    .Where(x => x.CreatedAt.Date.Month == month && x.CreatedAt.Date.Year == year)
                    .GroupBy(x => new { x.Products})
                    .Select(x => new { Sales = x.Count()})
                    .OrderByDescending(x => x.Sales)
                    .ToList();
            }
        }
    }
}
