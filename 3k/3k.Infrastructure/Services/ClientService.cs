using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3k.Domain.Interfaces.Services;
using _3k.Domain;

namespace _3k.Infrastructure.Services
{
    public class ClientService : IClientService
    {
        public ClientService()
        {

        }
        public IEnumerable<Asthenis> GetClientByEponimo(string partialEponimo)
        {
            throw new NotImplementedException();
        }
    }
}
