
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3k.Domain;
using _3k.Domain.Interfaces.Repositories;
using System.Data.Entity;

namespace _3k.Infrastructure.Repositories
{
    public class AsthenisRepository : Ef3kRepository<Asthenis> , IAsthenistRepository
    {
        public AsthenisRepository(DbContext context):base (context)
        {
        }

        //public IEnumerable<Asthenis> GetAsthenisByAll(string partialEponimo, string partialOnoma, decimal AMKA)
        //{

        //    return Context.Asthenis.Where(b => b.Eponimo.Contains(partialEponimo) && c => c.Onoma.Contains(partialOnoma) && (a => a.amka == AMKA));
      
        //}

        public IEnumerable<Asthenis> GetAsthenisByAMKA(decimal AMKA)
        {
            return Context.Asthenis.Where(a => a.amka == AMKA);
        }

        public IEnumerable<Asthenis> GetAsthenisByEponimo(string partialEponimo)
        {
            return Context.Asthenis.Where(a => a.Eponimo.Contains(partialEponimo));
        }
    }
}
