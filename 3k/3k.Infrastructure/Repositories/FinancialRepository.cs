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
    public class FinancialRepository : Ef3kRepository<Financial>, IFinancialRepository
    {
        public FinancialRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Financial> GetFinancialByAsthenisId(int partialAsthenisId)
        {
            return Context.Financial.Where(a => a.AsthenisId == partialAsthenisId);
        }

        public IEnumerable<Financial> GetFinancialByFinancialId(int partialFinancialId)
        {
            return Context.Financial.Where(a => a.FinancialId == partialFinancialId);
        }

        public IEnumerable<Financial> GetFinancialByParapemptikoId(int partialParapemptikoId)
        {
            return Context.Financial.Where(a => a.ParapemptikoId == partialParapemptikoId);
        }

        public IEnumerable<Financial> GetFinancialBySinedriesId(int partialSinedriesId)
        {
            return Context.Financial.Where(a => a.SinedriesId == partialSinedriesId);
        }
    }
}
