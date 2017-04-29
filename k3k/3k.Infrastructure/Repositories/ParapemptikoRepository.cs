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
    public class ParapemptikoRepository : Efk3kRepository<Parapemptiko>, IParapemptikoRepository
    {
        public ParapemptikoRepository(DbContext context) : base(context)
        {
        }

        public IEnumerable<Parapemptiko> GetParapempitkoByAsthnisId(int asthnisId)
        {
            return Context.Parapemptiko.Where(a => a.AsthenisId == asthnisId);
        }

        public IEnumerable<Parapemptiko> GetParapempitkoByGiatrosId(int giatrosId)
        {
            return Context.Parapemptiko.Where(a => a.GiatrosId == giatrosId);
        }

    }
}
