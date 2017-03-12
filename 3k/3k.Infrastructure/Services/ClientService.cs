using _3k.Domain;
using _3k.Domain.Interfaces.Repositories;
using _3k.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace _3k.Infrastructure.Services
{
    public class ClientService : IClientService
    {
        private readonly IAsthenisRepository _asthenisRepository;


        public ClientService(IAsthenisRepository asthenisReposiroty)

        {
            _asthenisRepository = asthenisReposiroty;
        }

      //  public IEnumerable<Asthenis> GetAsthenisByAll(string partialEponimo, string partialOnoma, decimal AMKA)
       // {
        //    var clients = _asthenisRepository.GetAsthenisByAll(partialEponimo,partialOnoma,AMKA);
         //   return clients;
        //}

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
    }
}
