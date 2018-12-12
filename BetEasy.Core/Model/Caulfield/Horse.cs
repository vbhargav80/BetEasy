using System;
using System.Xml.Serialization;

namespace BetEasy.Core.Model.Caulfield
{
    [Serializable]
    public class Horse
    {
        [XmlElement(ElementName = "number")]
        public int Number { get; set; }

        [XmlElement(ElementName = "trainer")]
        public Trainer Trainer { get; set; }

        [XmlElement(ElementName = "training_location")]
        public string TrainingLocation { get; set; }

        public string Owners { get; set; }

        public string Colours { get; set; }

        public string CurrentBlinkerInd { get; set; }

        public decimal PrizemoneyWon { get; set; }

        public int LastFourStarts { get; set; }

        public int LastTenStarts { get; set; }

        public Jockey Jockey { get; set; }

        public int Barrier { get; set; }

        public HorseWeight Weight { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute]
        public string Country { get; set; }

        [XmlAttribute]
        public int Age { get; set; }

        [XmlAttribute]
        public string Sex { get; set; }

        [XmlAttribute]
        public string Colour { get; set; }

        [XmlAttribute]
        public DateTime FoalingDate { get; set; }

        [XmlAttribute]
        public int Id { get; set; }
    }
}