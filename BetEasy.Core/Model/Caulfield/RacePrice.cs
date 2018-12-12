using System;
using System.Xml.Serialization;

namespace BetEasy.Core.Model.Caulfield
{
    [Serializable]
    public class RacePrice
    {
        [XmlElement(ElementName = "priceType")]
        public string PriceType { get; set; }

        [XmlArrayItem("horse")]
        [XmlArray(ElementName = "horses")]
        public RacePriceHorse[] Horses { get; set; }
    }
}