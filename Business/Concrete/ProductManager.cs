using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProduckDal _produckDal;
        public ProductManager(IProduckDal produckDal)
        {
            _produckDal = produckDal;
        }


        public IResult Add(Product product)
        {
            if (product.CategoryId == 1)
            {

                return new ErrorResult("Bu Kategoride  Ürün Eklenmez");
            }

            _produckDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_produckDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<List<Product>> GetAllByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_produckDal.GetAll(p => p.CategoryId == categoryId), Messages.ProductsListed);
        }
    }
}
