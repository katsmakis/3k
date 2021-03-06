﻿using k3k.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using k3k.Domain;
using k3k.Domain.Interfaces.Repositories;

namespace k3k.Infrastructure.Services
{
    public class FisikotherapeftisService : IFisikotherapeftisService
    {

        private readonly IFisikotherapeftisRepository _fisikotherapeftisRepository;
        
        public FisikotherapeftisService(IFisikotherapeftisRepository fisikotherapeftisRepository)
        {
            _fisikotherapeftisRepository = fisikotherapeftisRepository;
        }

        // Get By
        public IEnumerable<Fisikotherapeftis> GetFisikotherapeftisByEponimo(string partialEponomo)
        {
            var clients = _fisikotherapeftisRepository.GetFisikotherapeftisByEponimo(partialEponomo);
            return clients;
        }

        // Save -Update
        public void SaveFisikotherapeftis(Fisikotherapeftis fisikotherapeftis)
        {
            _fisikotherapeftisRepository.Update(fisikotherapeftis);
        }
    }
}
