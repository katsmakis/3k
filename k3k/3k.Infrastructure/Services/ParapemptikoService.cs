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
    public class ParapemptikoService : IParapemptikoService
    {
        private readonly IParapemptikoRepository _parapemptikoRepository;

        public ParapemptikoService(IParapemptikoRepository parapemptikoRepository)
        {
            _parapemptikoRepository = parapemptikoRepository;
        }

        //Get By
        public IEnumerable<Parapemptiko> GetParapempitkoByAsthnisId(int asthnisId)
        {
            var clients = _parapemptikoRepository.GetParapempitkoByAsthnisId(asthnisId);
            return clients;
        }

        public IEnumerable<Parapemptiko> GetParapempitkoByGiatrosId(int giatrosId)
        {
            var clients = _parapemptikoRepository.GetParapempitkoByGiatrosId(giatrosId);
            return clients;
        }

        //Save
        public void SaveParampemptiko(Parapemptiko parapemptiko)
        {
            _parapemptikoRepository.Update(parapemptiko);
        }
    }
}
