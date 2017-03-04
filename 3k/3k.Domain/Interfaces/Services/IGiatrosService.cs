using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3k.Domain.Interfaces.Services
{
    public interface IGiatrosService
    {
        IEnumerable<Giatros> GetGiatrosByEponimo(string partialEponimo);
    }
}
