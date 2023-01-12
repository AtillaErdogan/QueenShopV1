﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManeger : IProductService
    {
        IProductDal _productDal;
        public ProductManeger(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            //İş Kodları
            return _productDal.GetAll();

        }

        public List<Product> GetAllByCategory(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }
    }
}
