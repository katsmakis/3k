using _3k.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3k.Domain.Interfaces.Repositories 
{
    public interface IFinancialRepository : IRepository<Financial>, IDisposable
    {

        IEnumerable<Financial> GetFinancialByAsthenisId(int asthenisId);

        IEnumerable<Financial> GetFinancialByParapemptikoId(int parapemptikoId);

        IEnumerable<Financial> GetFinancialBySinedriesId(int sinedriesId);
    }
}
