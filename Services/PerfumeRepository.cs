﻿using Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace products
{
    public class PerfumeRepository
    {
        public readonly ProductContext context;
        public PerfumeRepository()
        {
            var context = new ProductContext();
        }
        public List<Perfume> GetAll()
        {
            List<Perfume> perfumes = null;
            using (var context = new ProductContext())
            {
                perfumes = context.Perfumes.ToList();

            }

            return perfumes;
        }

        public void takeData()
        {
            using (this.context)
            {
                Perfume perfume = new Perfume();
                context.Perfumes.Add(perfume);
                context.SaveChanges();

            }
        }
    }
}
