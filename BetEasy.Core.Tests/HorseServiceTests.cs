using BetEasy.Core.Interfaces;
using BetEasy.Core.Model.Caulfield;
using BetEasy.Core.Model.Wolferhampton;
using BetEasy.Core.Services;
using NSubstitute;
using Serilog;
using Xunit;

namespace BetEasy.Core.Tests
{
    public class HorseServiceTests
    {
        private readonly ICaulfieldRepository _mockCaulfieldRepository;
        private readonly IWolferhamptonRepository _mockWolferhamptonRepository;

        public HorseServiceTests()
        {
            _mockCaulfieldRepository = Substitute.For<ICaulfieldRepository>();
            _mockWolferhamptonRepository = Substitute.For<IWolferhamptonRepository>();
        }

        [Fact]
        public void GetAllHorses_ReturnsHorsesSortedByPriceAsc()
        {
            _mockCaulfieldRepository.GetMeeting().Returns(GetMockMeeting());
            _mockWolferhamptonRepository.GetFixture().Returns(GetMockFixture());

            var horseService = new HorseService(
                _mockCaulfieldRepository,
                _mockWolferhamptonRepository,
                Substitute.For<ILogger>()
            );

            var horses = horseService.GetAllHorses();
            Assert.True(horses[0].Name == "Caulfield Horse 2");
            Assert.True(horses[1].Name == "Wolferhampton Horse 2");
            Assert.True(horses[2].Name == "Wolferhampton Horse 1");
            Assert.True(horses[3].Name == "Caulfield Horse 1");
            Assert.True(horses[4].Name == "Wolferhampton Horse 3");
        }

        private Fixture GetMockFixture()
        {
            return new Fixture()
            {
                RawData = new FixtureRawData()
                {
                    Markets = new Market[]
                    {
                        new Market()
                        {
                            Selections = new Selection[]
                            {
                                new Selection()
                                {
                                    Price = 7.5m,
                                    Tags = new SelectionTags {Name = "Wolferhampton Horse 1"}
                                },
                                new Selection()
                                {
                                    Price = 3.5m,
                                    Tags = new SelectionTags {Name = "Wolferhampton Horse 2"}
                                },
                                new Selection()
                                {
                                    Price = 17.5m,
                                    Tags = new SelectionTags {Name = "Wolferhampton Horse 3"}
                                }
                            }
                        }
                    }
                }
            };
        }

        private Meeting GetMockMeeting()
        {
            return new Meeting
            {
                Races = new Race[]
                {
                    new Race()
                    {
                        Horses = new Horse[]
                        {
                            new Horse() {Name = "Caulfield Horse 1", Number = 1},
                            new Horse() {Name = "Caulfield Horse 2", Number = 2}
                        },
                        Prices = new RacePrice[]
                        {
                            new RacePrice()
                            {
                                PriceType = "WinFixedOdds",
                                Horses = new RacePriceHorse[]
                                {
                                    new RacePriceHorse()
                                    {
                                        Number = 1,
                                        Price = 13.3m
                                    },
                                    new RacePriceHorse()
                                    {
                                        Number = 2,
                                        Price = 2.4m
                                    }
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}
