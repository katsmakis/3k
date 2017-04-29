using k3k.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using k3k.Domain;
using k3k.Domain.Interfaces.Repositories;

namespace k3k.Infrastructure.Services
{
    public class SinedriesService : ISinedriesService
    {
        private readonly ISinedriesRepository _sinedriesReposiroty;

        public SinedriesService(ISinedriesRepository sinedriesReposiroty)
        {
            _sinedriesReposiroty = sinedriesReposiroty;
        }

        // Get By
        public IEnumerable<Sinedries> GetSinedriesByAsthenisId(int asthnisId)
        {
            return _sinedriesReposiroty.GetSinedriesByAsthenisId(asthnisId);
        }

        public IEnumerable<Sinedries> GetSinedriesByFisikotherapeftisId(int fisikotherapeftisId)
        {
            return _sinedriesReposiroty.GetSinedriesByFisikotherapeftisId(fisikotherapeftisId);
        }

        public IEnumerable<Sinedries> GetSinedriesByParapemtiko(int parapemptikoId)
        {
            return _sinedriesReposiroty.GetSinedriesByParapemtiko(parapemptikoId);
        }


        // Save - Update
        public void SaveSinedries(Sinedries sinedries)
        {
            _sinedriesReposiroty.Update(sinedries);
        }
    }
}
