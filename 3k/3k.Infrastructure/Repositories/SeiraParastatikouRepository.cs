﻿using _3k.Domain;
using _3k.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace _3k.Infrastructure.Repositories
{
    public class SeiraParastatikouRepository : Ef3kRepository<SeiraParastatikou>, ISeiraParastatikouRepository
    {
        public SeiraParastatikouRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<SeiraParastatikou> GetSeiraParastatikouByPerigrafi(string partialPerigrafi)
        {
            return Context.SeiraParastatikou.Where(a => a.Perigrafi.Contains(partialPerigrafi));
        }
    }
}
