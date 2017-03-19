using System.Collections.Generic;

namespace _3k.Domain.Interfaces.Services
{
    public interface IClientService
    {

        // Get By
        IEnumerable<Asthenis> GetClientByEponimo(string partialEponimo);

        IEnumerable<Asthenis> GetClientByAMKA(decimal AMKA);

        IEnumerable<Asthenis> GetAsthenisByAll(string partialEponimo, string partialOnoma, decimal AMKA);


        // Save - Update
        void SaveClient(Asthenis asthenis);
    }


}
