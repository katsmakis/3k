using System.Collections.Generic;

namespace _3k.Domain.Interfaces.Services
{
    public interface IClientService
    {
        IEnumerable<Asthenis> GetClientByEponimo(string partialEponimo);

        IEnumerable<Asthenis> GetClientByAMKA(decimal AMKA);

        IEnumerable<Asthenis> GetAsthenisByAll(string partialEponimo, string partialOnoma, decimal AMKA);
    }
}
