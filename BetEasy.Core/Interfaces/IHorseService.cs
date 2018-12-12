using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetEasy.Core.Model.Common;

namespace BetEasy.Core.Interfaces
{
    public interface IHorseService
    {
        List<Horse> GetAllHorses();
    }
}
