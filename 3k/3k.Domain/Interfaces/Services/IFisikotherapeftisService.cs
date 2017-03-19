using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3k.Domain.Interfaces.Services
{
    public interface IFisikotherapeftisService
    {

        // Get By
        IEnumerable<Fisikotherapeftis> GetFisikotherapeftisByEponimo(string partialEponomo);

        // Save - Update
        void SaveFisikotherapeftis(Fisikotherapeftis fisikotherapeftis);
    }
}
