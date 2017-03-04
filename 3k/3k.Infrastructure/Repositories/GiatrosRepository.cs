using _3k.Domain;
using _3k.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace _3k.Infrastructure.Repositories
{
    public class GiatrosRepository : Ef3kRepository<Giatros>, IGiatrosRepository
    {
        public GiatrosRepository(DbContext contex): base (contex)
        {
        }

        public IEnumerable<Giatros> GetGiatrosByEponimo(string partialEponimo)
        {
            return Context.Giatros.Where(a => a.Eponimo.Contains(partialEponimo));
        }
    }
}
