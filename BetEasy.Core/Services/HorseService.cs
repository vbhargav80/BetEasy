using System.Collections.Generic;
using System.Linq;
using BetEasy.Core.Interfaces;
using BetEasy.Core.Model.Caulfield;
using BetEasy.Core.Model.Wolferhampton;
using Serilog;
using Horse = BetEasy.Core.Model.Common.Horse;

namespace BetEasy.Core.Services
{
    public class HorseService : IHorseService
    {
        private readonly ICaulfieldRepository _caulfieldRepository;
        private readonly IWolferhamptonRepository _wolferhamptonRepository;
        private readonly ILogger _logger;

        public HorseService(
            ICaulfieldRepository caulfieldRepository, 
            IWolferhamptonRepository wolferhamptonRepository,
            ILogger logger
            )
        {
            _caulfieldRepository = caulfieldRepository;
            _wolferhamptonRepository = wolferhamptonRepository;
            _logger = logger;
        }

        public List<Horse> GetAllHorses()
        {
            _logger.Debug("Entered HorseService:GetAllHorses");

            var meeting = _caulfieldRepository.GetMeeting();
            var fixture = _wolferhamptonRepository.GetFixture();

            var horses = TransformCaulfieldMeetingToHorses(meeting);
            var wolferhamptonHorses = TransformWolferhamptonFixtureToHorses(fixture);

            horses.AddRange(wolferhamptonHorses);

            _logger.Debug("Exited HorseService:GetAllHorses");
            return horses.OrderBy(a => a.Price).ToList();
        }

        private List<Horse> TransformCaulfieldMeetingToHorses(Meeting meeting)
        {
            var horses = new List<Horse>();

            foreach (var race in meeting.Races)
            {
                var caulfieldHorses = race.Horses.ToList();
                // Just assuming for the exercise's sake we take the first price element
                var caulfieldHorsePrices = race.Prices[0].Horses.ToList();

                foreach (var caulfieldHorse in caulfieldHorses)
                {
                    horses.Add(new Horse
                    {
                        Name = caulfieldHorse.Name,
                        Price = caulfieldHorsePrices.First(a => a.Number == caulfieldHorse.Number).Price
                    });
                }
            }

            return horses;
        }

        private List<Horse> TransformWolferhamptonFixtureToHorses(Fixture fixture)
        {
            var horses = new List<Horse>();

            // Just assuming for the exercise's sake we take the first price element
            foreach (var selection in fixture.RawData.Markets[0].Selections)
            {
                horses.Add(new Horse
                {
                    Name = selection.Tags.Name,
                    Price = selection.Price
                });
            }

            return horses;
        }
    }
}
