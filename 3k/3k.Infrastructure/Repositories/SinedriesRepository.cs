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

        public IEnumerable<Sinedries> GetSinedriesByParapemtiko(int partialParapemptikoId)
        {
            return Context.Sinedries.Where(a => a.SinedriesId == partialParapemptikoId);
        }

        public IEnumerable<Sinedries> GetSinedriesByAsthenisId(int partialAsthnisId)
        {
            return Context.Sinedries.Where(a => a.AsthenisId == partialAsthnisId);
        }

        public IEnumerable<Sinedries> GetSinedriesByFisikotherapeftisId(int partialFisikotherapeftisId)
        {
            return Context.Sinedries.Where(a => a.FisikotherapeftisId == partialFisikotherapeftisId);
        }

        
    }
}
