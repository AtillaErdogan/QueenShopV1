// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFreamework;
using DataAccess.Concrete.InMemory;

ProductManeger ProductManeger = new ProductManeger(new EfProductDal());
foreach (var product in ProductManeger.GetProductDetails())
{
    Console.WriteLine(product.ProductName +" / "+ product.CategoryName );
}


