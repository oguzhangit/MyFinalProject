
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

IProductService productService = new ProductManager(new EfProductDal());
ICategoryService categoryService = new CategoryManager(new EfCategoryDal());


foreach (var item in productService.GetProductDetails())
{
    Console.WriteLine(item.CategoryName +"  " +item.ProductName);
}


