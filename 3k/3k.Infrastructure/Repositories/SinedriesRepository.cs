using _3k.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3k.Domain;
using System.Data.Entity;

namespace _3k.Infrastructure.Repositories
{
    public class SinedriesRepository : Ef3kRepository<Sinedries>, ISinedriesRepository
    {
        public SinedriesRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Sinedries> GetSinedriesByParapemtiko(int parapemptikoId)
        {
            return Context.Sinedries.Where(a => a.SinedriesId == parapemptikoId);
        }

        public IEnumerable<Sinedries> GetSinedriesByAsthenisId(int asthnisId)
        {
            return Context.Sinedries.Where(a => a.AsthenisId == asthnisId);
        }

        public IEnumerable<Sinedries> GetSinedriesByFisikotherapeftisId(int fisikotherapeftisId)
        {
            return Context.Sinedries.Where(a => a.FisikotherapeftisId == fisikotherapeftisId);
        }

        
    }
}
