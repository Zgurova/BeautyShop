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
    public class MakeUpRepository
    {
       
        public MakeUpRepository()
        {
            
        }
        public List<MakeUp> GetAll()
        {
            List<MakeUp> makeUp = null;
            using (var context = new ProductContext())
            {
                makeUp = context.MakeUp.ToList();

            }

            return makeUp;
        }

        public void takeData()
        {
            using (var context = new ProductContext())
            {
                MakeUp makeUp = new MakeUp();
                context.MakeUp.Add(makeUp);
                context.SaveChanges();

            }
        }
    }
}
