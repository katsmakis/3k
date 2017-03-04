
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3k.Domain;
using _3k.Domain.Interfaces.Repositories;

namespace _3k.Infrastructure.Repositories
{
    public class AsthenisRepository : IAsthenistRepository
    {
        public AsthenisRepository()
        {

        }

        public IEnumerable<Asthenis> GetAsthenisByEponimo(string partialEponimo)
        {
            throw new NotImplementedException();
        }
    }
}
