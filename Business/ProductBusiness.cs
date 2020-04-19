using Data;
using products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business
{
    public class ProductBusiness
    {
        private ProductContext productContext;

        public List<Cart> GetAll()
        {
            using (productContext = new ProductContext())
            {
                return productContext.Cart.ToList();
            }
        }
        public Cart Get(int id)
        {
            using (productContext = new ProductContext())
            {
                return productContext.Cart.Find(id);

            }
        }

        public void Add(Cart product)
        {
            using (productContext = new ProductContext())
            {
                productContext.Cart.Add(product);
                productContext.SaveChanges();

            }
        }

        public void Update(Cart product)
        {
            using (productContext = new ProductContext())
            {

                var item = productContext.Cart.Find(product.Id);
                if (item != null)
                {
                    productContext.Entry(item).CurrentValues.SetValues(product);
                    productContext.SaveChanges();
                }

            }
        }

        public void Delete(int id)
        {
            using (productContext = new ProductContext())
            {
                var product = productContext.Cart.Find(id);
                if (product != null)
                {
                    productContext.Cart.Remove(product);
                    productContext.SaveChanges();
                }
            }
        }


    }
}
