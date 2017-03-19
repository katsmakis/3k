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
    public class ParapemptikoService : IParapemptikoService
    {
        private readonly IParapemptikoRepository _parapemptikoRepository;

        public ParapemptikoService(IParapemptikoRepository parapemptikoRepository)
        {
            _parapemptikoRepository = parapemptikoRepository;
        }

        //Get By
        public IEnumerable<Parapemptiko> GetParapempitkoByAsthnisId(int PartialAsthnisId)
        {
            var clients = _parapemptikoRepository.GetParapempitkoByAsthnisId(PartialAsthnisId);
            return clients;
        }

        public IEnumerable<Parapemptiko> GetParapempitkoByGiatrosId(int PartialGiatrosId)
        {
            var clients = _parapemptikoRepository.GetParapempitkoByGiatrosId(PartialGiatrosId);
            return clients;
        }

        public IEnumerable<Parapemptiko> GetParapempitkoByParapemptikoId(int PartialParapemptikoId)
        {
            var clients = _parapemptikoRepository.GetParapempitkoByParapemptikoId(PartialParapemptikoId);
            return clients;
        }

        //Save
        public void SaveParampemptiko(Parapemptiko parapemptiko)
        {
            _parapemptikoRepository.Update(parapemptiko);
        }
    }
}
