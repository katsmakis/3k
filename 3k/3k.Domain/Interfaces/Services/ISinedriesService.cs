﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3k.Domain.Interfaces.Services
{
    public interface ISinedriesService
    {
        IEnumerable<Sinedries> GetSinedriesByParapemtiko(int partialParapemptikoId);

        IEnumerable<Sinedries> GetSinedriesByAsthenisId(int partialAsthnisId);

        IEnumerable<Sinedries> GetSinedriesByFisikotherapeftisId(int partialFisikotherapeftisId);
    }
}