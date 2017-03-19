using _3k.Domain;
using _3k.Domain.Interfaces.Repositories;
using _3k.Domain.Interfaces.Services;
using System.Collections.Generic;
using System;

namespace _3k.Infrastructure.Services
{
    public class ClientService : IClientService
    {
        private readonly IAsthenisRepository _asthenisRepository;
        private readonly IFinancialRepository _financialRepository;
        private readonly ISinedriesRepository _sinedriesRepository;
        private readonly IParapemptikoRepository _parapemptikoRepository;



        public ClientService(IAsthenisRepository asthenisReposiroty, IFinancialRepository financialRepository, ISinedriesRepository sinedriesRepository, IParapemptikoRepository parapemptikoRepository)

        {
            _asthenisRepository = asthenisReposiroty;
            _financialRepository = financialRepository;
            _sinedriesRepository = sinedriesRepository;
            _parapemptikoRepository = parapemptikoRepository;
        }
        // Get
        public IEnumerable<Asthenis> GetAsthenisByAll(string partialEponimo, string partialOnoma, decimal AMKA)
        {
            var clients = _asthenisRepository.GetAsthenisByAll(partialEponimo, partialOnoma, AMKA);
            return clients;
        }

        public IEnumerable<Asthenis> GetClientByAMKA(decimal AMKA)
        {
            var clients = _asthenisRepository.GetAsthenisByAMKA(AMKA);
            return clients;
        }

        public IEnumerable<Asthenis> GetClientByEponimo(string partialEponimo)
        {
            var clients = _asthenisRepository.GetAsthenisByEponimo(partialEponimo);
            return clients;
        }



        // Save - Update
        public void SaveClient(Asthenis asthenis)
        {
            _asthenisRepository.Update(asthenis);
        }
    }
}
