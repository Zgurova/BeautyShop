using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products
{
    public class Cart
    {
        public string id { get; set; }
        public string name { get; set; }
        public int number_of_orders { get; set; }
        public decimal price { get; set; }
        public decimal totalPrice
        {
            get { return this.number_of_orders * price; }
        }

    }
}
