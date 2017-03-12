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
    public class ParapemptikoRepository : Ef3kRepository<Sinedries>, IParapemptikoRepository
    {
        public ParapemptikoRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Parapemptiko> GetParapempitkoByAsthnisId(int PartialAsthnisId)
        {
            return Context.Parapemptiko.Where(a => a.AsthenisId == PartialAsthnisId);
        }

        public IEnumerable<Parapemptiko> GetParapempitkoByGiatrosId(int PartialGiatrosId)
        {
            return Context.Parapemptiko.Where(a => a.GiatrosId == PartialGiatrosId);
        }

        public IEnumerable<Parapemptiko> GetParapempitkoByParapemptikoId(int PartialParapemptikoId)
        {
            return Context.Parapemptiko.Where(a => a.ParapemptikoId == PartialParapemptikoId);
        }
    }
}
