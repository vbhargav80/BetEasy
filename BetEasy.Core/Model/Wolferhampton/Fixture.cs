using System;

namespace BetEasy.Core.Model.Wolferhampton
{
    public class Fixture
    {
        public string FixtureId { get; set; }
        public DateTime Timestamp { get; set; }
        public FixtureRawData RawData { get; set; }
    }
}