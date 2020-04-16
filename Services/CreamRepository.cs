using Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products
{
    public class CreamRepository
    {
        public readonly ProductContext context;
        public CreamRepository()
        {
            var context = new ProductContext();
        }
        public List<Cream> GetAll()
        {
            List<Cream> creams = null;
            using (this.context)
            {               
               creams = context.Creams.ToList();
            }           
            return creams;
        }

        public void takeData()
        {
            using (this.context)
            {
                Cream cream = new Cream();
                context.Creams.Add(cream);
                context.SaveChanges();

            }
        }

    }
}
