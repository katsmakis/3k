using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3k.Domain.Interfaces.Repositories
{
    public interface IAsthenistRepository
    {
        IEnumerable<Asthenis> GetAsthenisByEponimo(string partialEponimo);

        IEnumerable<Asthenis> GetAsthenisByAMKA(decimal AMKA);
    }
}
