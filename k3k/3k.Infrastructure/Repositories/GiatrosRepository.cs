using k3k.Domain;
using k3k.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace k3k.Infrastructure.Repositories
{
    public class GiatrosRepository : Efk3kRepository<Giatros>, IGiatrosRepository
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
