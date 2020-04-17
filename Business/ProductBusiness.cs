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

        public void Add(Perfume product)
        {
            using (productContext = new ProductContext())
            {
                productContext.Perfumes.Add(product);
                productContext.SaveChanges();

            }
        }

       /* public void Update(Product product)
        {
            using (productContext = new ProductContext())
            {

                var item = productContext.Products.Find(product.Id);
                if (item != null)
                {
                    productContext.Entry(item).CurrentValues.SetValues(product);
                    productContext.SaveChanges();
                }

            }
        }*/

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
