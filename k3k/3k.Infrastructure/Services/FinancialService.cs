using k3k.Domain.Interfaces.Repositories;
using k3k.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using k3k.Domain;

namespace k3k.Infrastructure.Services
{
    public class FinancialService : IFinancialService
    {
        
        private readonly IFinancialRepository _financialRepository;

        public FinancialService(IFinancialRepository financialReposiroty)
        {
            _financialRepository = financialReposiroty;
        }

        // Get By
        public IEnumerable<Financial> GetFinancialByAsthenisId(int asthenisId)
        {
            var clients = _financialRepository.GetFinancialByAsthenisId(asthenisId);
            return clients;
        }


        public IEnumerable<Financial> GetFinancialByParapemptikoId(int parapemptikoId)
        {
            var clients = _financialRepository.GetFinancialByParapemptikoId(parapemptikoId);
            return clients;
        }

        public IEnumerable<Financial> GetFinancialBySinedriesId(int sinedriesId)
        {
            var clients = _financialRepository.GetFinancialBySinedriesId(sinedriesId);
            return clients;
        }


        // Save - Update
        public void SaveClient(Financial financial)
        {
            _financialRepository.Update(financial);
        }
    }
}
