using Business.Abstract;
using DataAccess.Abstarct;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {


        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int categoryid)
        {
            return _productDal.GetList(filter: p => p.CategoryID == categoryid);
        }

        public Product GetById(int productid)
        {
            return _productDal.Get(filter: p => p.ProductID == productid);
        }
    }
}
