using k3k.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k3k.Domain.Interfaces.Repositories
{
    public interface IFisikotherapeftisRepository : IRepository<Fisikotherapeftis>, IDisposable
    {
        IEnumerable<Fisikotherapeftis> GetFisikotherapeftisByEponimo(string partialEponimo);
    }
}
