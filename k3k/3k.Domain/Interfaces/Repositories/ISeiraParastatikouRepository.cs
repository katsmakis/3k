using k3k.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k3k.Domain.Interfaces.Repositories
{
    public interface ISeiraParastatikouRepository : IRepository<SeiraParastatikou>, IDisposable
    {
        IEnumerable<SeiraParastatikou> GetSeiraParastatikouByPerigrafi(string partialPerigrafi);

    }
}
