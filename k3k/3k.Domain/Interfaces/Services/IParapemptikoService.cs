using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k3k.Domain.Interfaces.Services
{
    public interface IParapemptikoService
    {
        // Get By
 
        IEnumerable<Parapemptiko> GetParapempitkoByAsthnisId(int asthnisId);

        IEnumerable<Parapemptiko> GetParapempitkoByGiatrosId(int giatrosId);

        // Save - Update
        void SaveParampemptiko(Parapemptiko parapemptiko);
    }
}
