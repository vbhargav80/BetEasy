using System;
using System.Linq;
using BetEasy.Core.Interfaces;
using Serilog;

namespace BetEasy.App
{
    public class Application : IApplication
    {
        private readonly ILogger _logger;
        private readonly IHorseService _horseService;

        public Application(ILogger logger, IHorseService horseService)
        {
            _logger = logger;
            _horseService = horseService;
        }

        public void Run()
        {
            var horses = _horseService.GetAllHorses();

            foreach (var horse in horses.OrderBy(x => x.Price))
            {
                Console.WriteLine(horse.Name);
            }

            Console.WriteLine("Enter any key to exit");
            Console.Read();
        }
    }
}
