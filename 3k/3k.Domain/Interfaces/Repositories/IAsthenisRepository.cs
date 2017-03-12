﻿using System.Collections.Generic;

namespace _3k.Domain.Interfaces.Repositories
{
    public interface IAsthenisRepository
    {
        IEnumerable<Asthenis> GetAsthenisByEponimo(string partialEponimo);

        IEnumerable<Asthenis> GetAsthenisByAMKA(decimal AMKA);

        IEnumerable<Asthenis> GetAsthenisByAll(string partialEponimo, string partialOnoma, decimal AMKA);
    }
}
