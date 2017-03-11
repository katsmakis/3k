using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3k.Domain.Interfaces.Services;
using _3k.Domain;
using _3k.Domain.Interfaces.Repositories;

namespace _3k.Infrastructure.Services
{
    public class ClientService : IClientService
    {
        private readonly IAsthenistRepository _asthenisRepository;


        public ClientService(IAsthenistRepository asthenisReposiroty)

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
