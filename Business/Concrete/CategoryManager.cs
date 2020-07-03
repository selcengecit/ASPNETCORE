using Business.Abstract;
using DataAccess.Abstarct;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {

        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();
            
        }
    }
}
