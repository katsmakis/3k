﻿using _3k.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3k.Domain;
using _3k.Domain.Interfaces.Repositories;

namespace _3k.Infrastructure.Services
{
    public class GiatrosService : IGiatrosService
    {
        private readonly IGiatrosRepository _giatrosRepository;

        public GiatrosService (IGiatrosRepository giatrosRepository)
        {
            _giatrosRepository = giatrosRepository;

        }

        
        public IEnumerable<Giatros> GetGiatrosByEponimo(string partialEponimo)
        {
            var clients = _giatrosRepository.GetGiatrosByEponimo(partialEponimo);
            return clients;
        }
    }
}
