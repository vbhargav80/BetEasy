using System;

namespace BetEasy.Core.Model.Wolferhampton
{
    public class FixtureRawData
    {
        public string FixtureName { get; set; }
        public string Id { get; set; }
        public DateTime StartTime { get; set; }
        public int Sequence { get; set; }
        public Tags Tags { get; set; }
        public Market[] Markets { get; set; }
        public Participant[] Participants { get; set; }
    }
}