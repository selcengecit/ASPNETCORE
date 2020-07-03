using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Helpers;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartService _cartService;
        private ICartSessionHelper _cartSessionHelper;
        private IProductService _productService;
        public CartController(ICartService cartService, ICartSessionHelper cartSessionHelper, IProductService productService)
        {
            _cartService = cartService;
            _cartSessionHelper = cartSessionHelper;
            _productService = productService;

        }
        //sepete ekle butonu için

        public IActionResult AddToCart(int productid)
        {
            //öncelikle idsi verilen ürünü veritabanından cekmemiz gerekiyor
            Product product = _productService.GetById(productid);
            //sonra sessiondan sepeti çekmem gerekiyor öünkü oraya eklicem
            var cart = _cartSessionHelper.GetCart(key: "cart");
            //sepete ürünü eklemem gerekiyor 
            _cartService.AddToCart(cart, product);
            //sepeti sessiona geri eklememiz gerekiyor.
            _cartSessionHelper.SetCart(key: "cart", cart);
            //ProductContorllerdaki index aksiyonuna gönder.
            TempData.Add("message", product.ProductName + " sepette eklendi!");
            return RedirectToAction("Index", controllerName: "Product");
        }
        public IActionResult RemoveFromCart(int productid)
        {
            Product product = _productService.GetById(productid);
            var cart = _cartSessionHelper.GetCart(key: "cart");
            _cartService.RemoveFromCart(cart, productid);
            _cartSessionHelper.SetCart(key: "cart", cart);
            TempData.Add("message", product.ProductName + " sepetten silindi!");
            return RedirectToAction("Index", controllerName: "Cart");
        }
        public IActionResult Index()
        {
            var model = new CartListViewModel
            {
                Cart = _cartSessionHelper.GetCart(key: "cart")
            };
            return View(model);

        }
        public IActionResult Complete()
        {
            var model = new ShippingDetailsViewModel
            {
                ShippingDetail = new ShippingDetail()
            };
            return View(model);

        }
        [HttpPost]
        public IActionResult Complete(ShippingDetail shippingDetail)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            TempData.Add("message", "Siparişiniz başarıyla tamamlandı!");
            _cartSessionHelper.Clear();
            return RedirectToAction("Index", controllerName: "Cart");
        }
    }
}