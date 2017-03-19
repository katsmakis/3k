using _3k.Domain.Interfaces.Repositories;
using _3k.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3k.Domain;

namespace _3k.Infrastructure.Services
{
    public class FinancialService : IFinancialService
    {
        
        private readonly IFinancialRepository _financialRepository;

        public FinancialService(IFinancialRepository financialReposiroty)
        {
            _financialRepository = financialReposiroty;
        }

        // Get By
        public IEnumerable<Financial> GetFinancialByAsthenisId(int partialAsthenisId)
        {
            var clients = _financialRepository.GetFinancialByAsthenisId(partialAsthenisId);
            return clients;
        }

        public IEnumerable<Financial> GetFinancialByFinancialId(int partialFinancialId)
        {
            var clients = _financialRepository.GetFinancialByFinancialId(partialFinancialId);
            return clients;
        }

        public IEnumerable<Financial> GetFinancialByParapemptikoId(int partialParapemptikoId)
        {
            var clients = _financialRepository.GetFinancialByParapemptikoId(partialParapemptikoId);
            return clients;
        }

        public IEnumerable<Financial> GetFinancialBySinedriesId(int partialSinedriesId)
        {
            var clients = _financialRepository.GetFinancialBySinedriesId(partialSinedriesId);
            return clients;
        }


        // Save - Update
        public void SaveClient(Financial financial)
        {
            _financialRepository.Update(financial);
        }
    }
}
