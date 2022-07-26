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
            _products = new List<Product>() { 
            
                new Product(){ProductId = 1, CategoryId = 1  , ProductName ="Laptop" , UnitPrice = 500 , UnitsInStock = 25},

                 new Product(){ProductId = 2, CategoryId = 2  , ProductName ="Klavye" , UnitPrice = 45 , UnitsInStock = 17},

                  new Product(){ProductId = 3, CategoryId = 3  , ProductName ="Mouse" , UnitPrice = 54 , UnitsInStock = 23},

            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
           Product product1 = _products.SingleOrDefault(p=> p.ProductId == product.ProductId);

            _products.Remove(product1);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
           return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product product1 = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            product.ProductName = product1.ProductName;
            product.UnitPrice = product1.UnitPrice;
            product.UnitsInStock = product1.UnitsInStock;
            product.CategoryId = product1.CategoryId;
        }
    }
}
