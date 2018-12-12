using System;
using System.Xml.Serialization;

namespace BetEasy.Core.Model.Caulfield
{
    [Serializable]
    public class MeetingTrack
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public string TranslatedName { get; set; }

        [XmlAttribute]
        public string Club { get; set; }

        [XmlAttribute]
        public string Location { get; set; }

        [XmlAttribute]
        public string Country { get; set; }

        [XmlAttribute]
        public string State { get; set; }

        [XmlAttribute]
        public string Condition { get; set; }
    }
}