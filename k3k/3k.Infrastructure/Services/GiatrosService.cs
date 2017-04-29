using k3k.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using k3k.Domain;
using k3k.Domain.Interfaces.Repositories;

namespace k3k.Infrastructure.Services
{
    public class GiatrosService : IGiatrosService
    {
        private readonly IGiatrosRepository _giatrosRepository;

        public GiatrosService (IGiatrosRepository giatrosRepository)
        {
            _giatrosRepository = giatrosRepository;

        }

        // Get By
        public IEnumerable<Giatros> GetGiatrosByEponimo(string partialEponimo)
        {
            var clients = _giatrosRepository.GetGiatrosByEponimo(partialEponimo);
            return clients;
        }

        //Save 
        public void SaveGiatros(Giatros giatros)
        {
            _giatrosRepository.Update(giatros);
        }

       


    }
}
