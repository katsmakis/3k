using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k3k.Domain.Interfaces.Services
{
    public interface ISinedriesService
    {
        // Get By
        IEnumerable<Sinedries> GetSinedriesByParapemtiko(int parapemptikoId);

        IEnumerable<Sinedries> GetSinedriesByAsthenisId(int asthnisId);

        IEnumerable<Sinedries> GetSinedriesByFisikotherapeftisId(int fisikotherapeftisId);

        // Save - Update
        void SaveSinedries(Sinedries sinedries);
    }
}
