using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k3k.Domain.Interfaces.Services
{
    public interface ISeiraParastatikouService
    {
        // Get
        IEnumerable<SeiraParastatikou> GetSeiraParastatikouByPerigrafi(string partialPerigrafi);

        //Save - Update
        void SaveSeiraParastatikou(SeiraParastatikou seiraParastatikou);
    }
}
