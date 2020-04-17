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
        public List<Cream> GetAll()
        {
            List<Cream> creams = null;
            using (var context = new ProductContext())
            {
                creams = context.Creams.ToList();
            }
            return creams;
        }

        public void takeData()
        {
            using (var context = new ProductContext())
            {
                Cream cream = new Cream();
                context.Creams.Add(cream);
                context.SaveChanges();

            }
        }
    }
}
