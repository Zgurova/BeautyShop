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
        public CreamRepository()
        {

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
    }
}
