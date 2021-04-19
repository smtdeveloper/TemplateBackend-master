
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    
    class Program
    {
        static void Main(string[] args)
        {
            EfProduckDal efProduckDal = new EfProduckDal();

            Product produck = new Product
            {
                CategoryId = 1,
                BrandId = 1,
                Name = "Su",
                Price = 1,
                CreateDate = DateTime.Now,
                Code = "WTR01",
                Active = true

            };

            efProduckDal.Add(produck);

            foreach (var product in efProduckDal.GetAll())  // && ve  // p => p.CategoryId == 1   filtre
            {
                Console.WriteLine(product.Name);
            }

        }
    }
}
