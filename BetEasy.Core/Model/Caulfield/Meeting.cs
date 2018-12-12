using System;
using System.Xml.Serialization;

namespace BetEasy.Core.Model.Caulfield
{
    [Serializable]
    public class Meeting
    {
        [XmlElement(ElementName = "date")]
        public string Date { get; set; }

        public string MeetingType { get; set; }

        [XmlElement(ElementName = "track")]
        public MeetingTrack Track { get; set; }

        public int MeetingId { get; set; }

        [XmlArrayItem("race")]
        [XmlArray(ElementName = "races")]
        public Race[] Races { get; set; }
    }
}