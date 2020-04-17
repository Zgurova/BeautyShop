using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products
{
    public class CartRepository
    {
        public CartRepository()
        {

        }
        public List<Cart> Add(object cosmetic)
        {
            List<Cart> cart = null;            
            using (var context = new ProductContext())
            {                
                cart = context.Cart.ToList();
            }
            return cart;
        }
        public List<Cart> GetAll()
        {
            List<Cart> cart = null;
            using (var context = new ProductContext())
            {
                cart = context.Cart.ToList();
            }
            return cart;
        }
        public void takeData()
        {
            using (var context = new ProductContext())
            {
                Cart cart = new Cart();
                context.Cart.Add(cart);
                context.SaveChanges();

            }
        }

    }
}
