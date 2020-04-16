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
        public readonly ProductContext context;
        public MakeUpRepository()
        {
            var context = new ProductContext();
        }
        public List<MakeUp> GetAll()
        {
            List<MakeUp> makeUp = null;
            using (this.context)
            {
                makeUp = context.MakeUp.ToList();

            }

            return makeUp;
        }

        public void takeData()
        {
            using (this.context)
            {
                MakeUp makeUp = new MakeUp();
                context.MakeUp.Add(makeUp);
                context.SaveChanges();

            }
        }
    }
}
