using _3k.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3k.Domain;
using _3k.Domain.Interfaces.Repositories;

namespace _3k.Infrastructure.Services
{
    public class FisikotherapeftisService : IFisikotherapeftisService
    {

        private readonly IFisikotherapeftisRepository _fisikotherapeftisRepository;

        public FisikotherapeftisService(IFisikotherapeftisRepository fisikotherapeftisRepository)
        {
            _fisikotherapeftisRepository = fisikotherapeftisRepository;

        }




        public IEnumerable<Fisikotherapeftis> GetFisikotherapeftisByEponimo(string partialEponomo)
        {
            var clients = _fisikotherapeftisRepository.GetFisikotherapeftisByEponimo(partialEponomo);
            return clients;
        }
    }
}
