using _3k.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3k.Domain.Interfaces.Repositories
{
    public interface ISinedriesRepository : IRepository<Sinedries>, IDisposable
    {
        IEnumerable<Sinedries> GetSinedriesByParapemtiko(int parapemptikoId);

        IEnumerable<Sinedries> GetSinedriesByAsthenisId(int asthnisId);

        IEnumerable<Sinedries> GetSinedriesByFisikotherapeftisId(int fisikotherapeftisId);

    }
}
