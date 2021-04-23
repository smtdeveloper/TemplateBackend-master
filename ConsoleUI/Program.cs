
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    
    class Program
    {
        static void Main(string[] args)
        {
            EfProductDal efProduckDal = new EfProductDal();

            Product produck = new Product
            {
                CategoryId = 1,
                BrandId = 1,
                Name = "Kahve",
                Price = 3,
                CreateDate = DateTime.Now,
                Code = "SMT",
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
