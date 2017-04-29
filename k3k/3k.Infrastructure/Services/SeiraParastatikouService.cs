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
    public class SeiraParastatikouService : ISeiraParastatikouService
    {
        private readonly ISeiraParastatikouRepository _seiraParapemptikouReposiroty;

        public SeiraParastatikouService(ISeiraParastatikouRepository seiraParapemptikouReposiroty)
        {
            _seiraParapemptikouReposiroty = seiraParapemptikouReposiroty;
        }

        // Get by
        public IEnumerable<SeiraParastatikou> GetSeiraParastatikouByPerigrafi(string partialPerigrafi)
        {
            return _seiraParapemptikouReposiroty.GetSeiraParastatikouByPerigrafi(partialPerigrafi);
        }

        // Save - Update
        public void SaveSeiraParastatikou(SeiraParastatikou seiraParastatikou)
        {
            _seiraParapemptikouReposiroty.Update(seiraParastatikou);
        }
    }
}
