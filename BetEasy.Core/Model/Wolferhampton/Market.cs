namespace BetEasy.Core.Model.Wolferhampton
{
    public class Market
    {
        public string Id { get; set; }
        public Selection[] Selections { get; set; }
        public MarketTag Tags { get; set; }
    }
}