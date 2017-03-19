using _3k.Domain;
using _3k.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System;

namespace _3k.Infrastructure.Repositories
{
    public class AsthenisRepository : Ef3kRepository<Asthenis> , IAsthenisRepository
    {
        public AsthenisRepository(DbContext context):base (context)
        {
        }

        public IEnumerable<Asthenis> GetAsthenisByAll(string partialEponimo, string partialOnoma, decimal AMKA)
        {
            //IEnumerable<Asthenis> asthenis;
            //if (partialEponimo != string.Empty)
            //    {
            //    asthenis=

                return Context.Asthenis.Where(b => b.Eponimo.Contains(partialEponimo) && b.Onoma.Contains(partialOnoma) && b.amka == AMKA);
            //}
        }

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
