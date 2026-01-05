using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;
using SignalR.DataAccessLayer.Repositories;
using SignalR.EntityLayer.Entities;

namespace SignalR.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(SignalRContext context) : base(context)
        {
        }

        public List<Product> GetProductsWithCategories()
        {
            var context = new SignalRContext();
            var values = context.Products.Include(x => x.Category).ToList();
            return values;
        }

        public int ProductCount()
        {
            var context = new SignalRContext();
            return context.Products.Count();
        }

        public int ProductCountByCategoryNameDrink()
        {
            var context = new SignalRContext();
            return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "İçecekler").Select(z => z.CategoryID).FirstOrDefault())).Count();
        }

        public int ProductCountByCategoryNameHamburger()
        {
            var context = new SignalRContext();
            return context.Products.Where(x => x.CategoryID == (context.Categories.Where(y => y.CategoryName == "Hamburger").Select(z => z.CategoryID).FirstOrDefault())).Count();
        }

        public string ProductNameByMaxPrice()
        {
            var contex = new SignalRContext();
            return contex.Products.Where(x => x.Price == (contex.Products.Max(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
        }

        public string ProductNameByMinPrice()
        {
            var contex = new SignalRContext();
            return contex.Products.Where(x => x.Price == (contex.Products.Min(y => y.Price))).Select(z => z.ProductName).FirstOrDefault();
        }

        public decimal ProductAvgPriceByHamburger()
        {
            var context = new SignalRContext();
            return context.Products.Where(x => x.ProductID == (context.Categories.Where(y => y.CategoryName == "Hamburger").Select(z => z.CategoryID).FirstOrDefault())).Average(w => w.Price);
        }

        public decimal ProdutPriceAverage()
        {
            var context = new SignalRContext();
            return context.Products.Average(x => x.Price);
        }

        public decimal ProductPriceBySteakBurger()
        {
            var context = new SignalRContext();
            return context.Products.Where(x => x.ProductName == "SteakBurger").Select(y => y.Price).FirstOrDefault();
        }

        public decimal TotalPriceByDrinkCategory()
        {
            var context = new SignalRContext();
            int id = context.Categories.Where(x => x.CategoryName == "İçecekler").Select(y => y.CategoryID).FirstOrDefault();
            return context.Products.Where(x => x.CategoryID == id).Sum(y => y.Price);
        }

        public decimal TotalPriceBySaladCategory()
        {
            var context = new SignalRContext();
            int id = context.Categories.Where(x => x.CategoryName == "Salatalar").Select(y => y.CategoryID).FirstOrDefault();
            return context.Products.Where(x => x.CategoryID == id).Sum(y => y.Price);
        }

        public List<Product> GetLast9Products()
        {
            var context = new SignalRContext();
            return context.Products.Take(9).ToList();
        }
    }
}
