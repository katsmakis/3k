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
        IEnumerable<Financial> GetFinancialByFinancialId(int partialFinancialId);

        IEnumerable<Financial> GetFinancialByAsthenisId(int partialAsthenisId);

        IEnumerable<Financial> GetFinancialByParapemptikoId(int partialParapemptikoId);

        IEnumerable<Financial> GetFinancialBySinedriesId(int partialSinedriesId);

        // Save - Update
        void SaveClient(Financial financial);
    }
}
