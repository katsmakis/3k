using k3k.Core.Data;
using System;
using System.Collections.Generic;

namespace k3k.Domain.Interfaces.Repositories
{
    public interface IGiatrosRepository : IRepository<Giatros>, IDisposable
    {
        IEnumerable<Giatros> GetGiatrosByEponimo(string partialEponimo);

    }
}
