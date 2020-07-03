using Core.Concrete.EntityFramework;
using DataAccess.Abstarct;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal :EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
        //içi dolu metotlar..
    
    }
}
