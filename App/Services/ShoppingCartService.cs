using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationRazor.Models;

namespace WebApplicationRazor.Services
{
    public static class ShoppingCartService
    {
        private static ShoppingCart ShopCart;

        public static void AddtoCart(Item x) {
            ShopCart.Cart.Add(x);
        }

                public static void RemoveFromCart() {

        }

                public static void Something() {

        }
        
    }
}