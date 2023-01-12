// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFreamework;
using DataAccess.Concrete.InMemory;

ProductManeger productManeger = new ProductManeger(new EfProductDal());
foreach (var product in productManeger.GetAllByCategory(2))
{
    Console.WriteLine(product.ProductName);
}


