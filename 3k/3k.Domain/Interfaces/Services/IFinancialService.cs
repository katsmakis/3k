using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3k.Domain.Interfaces.Services
{
    public interface IFinancialService
    {
        // Get By
        IEnumerable<Financial> GetFinancialByAsthenisId(int asthenisId);

        IEnumerable<Financial> GetFinancialByParapemptikoId(int parapemptikoId);

        IEnumerable<Financial> GetFinancialBySinedriesId(int sinedriesId);

        // Save - Update
        void SaveClient(Financial financial);
    }
}
