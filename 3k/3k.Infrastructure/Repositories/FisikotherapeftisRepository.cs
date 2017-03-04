using _3k.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using _3k.Domain.Interfaces.Repositories;
using System.Linq;

namespace _3k.Infrastructure.Repositories
{
    public class FisikotherapeftisRepository : Ef3kRepository<Fisikotherapeftis>, IFisikotherapeftisRepository
    {
        public FisikotherapeftisRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Fisikotherapeftis> GetFisikotherapeftisByEponimo(string partialEponimo)
        {
            return Context.Fisikotherapeftis.Where(a => a.Eponimo.Contains(partialEponimo));
        }
    }
}
