using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BetEasy.DataAccess.Repositories;

namespace BetEasy.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var meeting = new CaulfieldRepository().GetMeeting();
            var fixture = new WolferhamptonRepository().GetFixture();
        }
    }
}
