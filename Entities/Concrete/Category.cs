using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
   public class Category:IEntity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

    }
}
