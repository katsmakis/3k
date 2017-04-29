using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k3k.Domain.Interfaces.Services
{
    public interface IGiatrosService
    {

        // Get By
        IEnumerable<Giatros> GetGiatrosByEponimo(string partialEponimo);


        // Save - Update
        void SaveGiatros(Giatros giatros);
    }
}
