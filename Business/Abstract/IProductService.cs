using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll(Expression<Func<Product , bool>> filter);
        List<Product> GetAllByCategory(int categoryId);
        List<Product> GetAllByUnitprice(decimal min, decimal max);
        List<ProductDetailDto> GetProductDetails();

    }
}
