using System;
using System.Xml.Serialization;

namespace BetEasy.Core.Model.Caulfield
{
    [Serializable]
    public class Race
    {
        public int NumberOfRunners { get; set; }

        public string StartTime { get; set; }

        public Distance Distance { get; set; }

        [XmlArrayItem("horse")]
        [XmlArray(ElementName = "horses")]
        public Horse[] Horses { get; set; }

        [XmlArrayItem("price")]
        [XmlArray(ElementName = "prices")]
        public RacePrice[] Prices { get; set; }

        [XmlAttribute]
        public int Number { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public uint Id { get; set; }

        [XmlAttribute]
        public string Status { get; set; }
    }
}