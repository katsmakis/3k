using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3k.Domain.Interfaces.Services
{
    public interface IClientlService
    {
        IEnumerable<Asthenis> GetClientByEponimo(string partialEponimo);

        IEnumerable<Asthenis> GetClientByAMKA(decimal AMKA);

        IEnumerable<Asthenis> GetAsthenisByAll(string partialEponimo, string partialOnoma, decimal AMKA);
    }
}
