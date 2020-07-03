using Core.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstarct
{
    public interface IProductDal:IEntityRepository<Product>
    {
        
    }
}
