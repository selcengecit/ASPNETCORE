using Core.Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DomainModels
{
    public class CartLine:IDomainModel //sepetin içindeki her bir ürünü kastediyor
    {
        public Product product { get; set; } //ürünler
        public int Quantity { get; set; } //hangi üründen kaç tane
    }
}
