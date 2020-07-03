using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; set; }
        public int currentCategory { get;  set; }
    }
}
