using System;
using System.Xml.Serialization;

namespace BetEasy.Core.Model.Caulfield
{
    [Serializable]
    public class RacePriceHorse
    {
        [XmlAttribute(AttributeName = "number")]
        public int Number { get; set; }

        [XmlAttribute]
        public decimal Price { get; set; }
    }
}