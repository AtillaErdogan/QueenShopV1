using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>{
            new Product {ProductId=1 , CategoryId=1, ProductName="Telefon"
            , UnitPrice=10000, UnitsInStock=9},
            new Product {ProductId=2 , CategoryId=1, ProductName="Bilgisayar"
            , UnitPrice=15000, UnitsInStock=5}
            }   ;

        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //Lambda ile liste içindeki elemanlar tek tek geziliyor ve bizim istediğimiz üzün ile eşlendiginde
            //referans numarası productToDelete'in içine aktarılıyor.
            Product productToDelete = _products.SingleOrDefault(p=> p.ProductId==product.ProductId);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            //Where koşulu, Koşulu sağlayan ürünleri başka bir noktada sanal liste oluşturur.
            return _products.Where(p=> p.CategoryId == categoryId).ToList();

        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductId = product.ProductId;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.UnitPrice = product.UnitPrice;

        }
    }
}
