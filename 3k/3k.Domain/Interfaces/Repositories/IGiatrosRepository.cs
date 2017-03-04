using System.Collections.Generic;

namespace _3k.Domain.Interfaces.Repositories
{
    public interface IGiatrosRepository
    {
        IEnumerable<Giatros> GetGiatrosByEponimo(string partialEponimo);

    }
}
