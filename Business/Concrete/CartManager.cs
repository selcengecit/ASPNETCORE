using Business.Abstract;
using Entities.Concrete;
using Entities.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CartManager : ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            CartLine cartLine = cart.cartLines.FirstOrDefault(c => c.product.ProductID == product.ProductID);
            if (cartLine != null)
            {
                cartLine.Quantity++;
                return;
            }
            else
            {
                cart.cartLines.Add(new CartLine
                {
                    product = product,
                    Quantity = 1
                });
           }
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.cartLines;
        }

        public void RemoveFromCart(Cart cart, int productid)
        {
            CartLine cartLine = cart.cartLines.FirstOrDefault(c => c.product.ProductID == productid);
            if ((cartLine != null) && (cartLine.Quantity > 1))
            {
                
                    cartLine.Quantity--;
                    return;
               
               
            }
            else
            {
                cart.cartLines.Remove(cart.cartLines.FirstOrDefault(c => c.product.ProductID == productid));
            }
        }
    }
}

    

