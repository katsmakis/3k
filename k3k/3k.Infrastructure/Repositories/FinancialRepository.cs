using k3k.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using k3k.Domain;
using System.Data.Entity;

namespace k3k.Infrastructure.Repositories
{
    public class FinancialRepository : Efk3kRepository<Financial>, IFinancialRepository
    {
        public FinancialRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Financial> GetFinancialByAsthenisId(int asthenisId)
        {
            return Context.Financial.Where(a => a.AsthenisId == asthenisId);
        }


        public IEnumerable<Financial> GetFinancialByParapemptikoId(int parapemptikoId)
        {
            return Context.Financial.Where(a => a.ParapemptikoId == parapemptikoId);
        }

        public IEnumerable<Financial> GetFinancialBySinedriesId(int sinedriesId)
        {
            return Context.Financial.Where(a => a.SinedriesId == sinedriesId);
        }
    }
}
