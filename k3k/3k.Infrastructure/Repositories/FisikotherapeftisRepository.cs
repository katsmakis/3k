using k3k.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using k3k.Domain.Interfaces.Repositories;
using System.Linq;

namespace k3k.Infrastructure.Repositories
{
    public class FisikotherapeftisRepository : Efk3kRepository<Fisikotherapeftis>, IFisikotherapeftisRepository
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
