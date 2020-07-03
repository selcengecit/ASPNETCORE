using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities.DomainModels
{
    public class Cart:IDomainModel //sepetin kendisi 
    {

        public Cart()
        {
            cartLines = new List<CartLine>();
        }
        public List<CartLine> cartLines { get; set; } //sepette sepetin satırları olur
    }
}
