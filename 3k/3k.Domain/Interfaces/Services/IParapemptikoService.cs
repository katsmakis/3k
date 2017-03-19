using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3k.Domain.Interfaces.Services
{
    public interface IParapemptikoService
    {
        // Get By
        IEnumerable<Parapemptiko> GetParapempitkoByParapemptikoId(int PartialParapemptikoId);

        IEnumerable<Parapemptiko> GetParapempitkoByAsthnisId(int PartialAsthnisId);

        IEnumerable<Parapemptiko> GetParapempitkoByGiatrosId(int PartialGiatrosId);

        // Save - Update
        void SaveParampemptiko(Parapemptiko parapemptiko);
    }
}
