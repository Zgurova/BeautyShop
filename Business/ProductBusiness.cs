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



    }
}
