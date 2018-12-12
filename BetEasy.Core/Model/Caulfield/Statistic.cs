using System;
using System.Xml.Serialization;

namespace BetEasy.Core.Model.Caulfield
{
    [Serializable]
    public class Statistic
    {
        [XmlAttribute]
        public string Type { get; set; }

        [XmlAttribute]
        public ushort Total { get; set; }

        [XmlAttribute]
        public byte Firsts { get; set; }

        [XmlAttribute]
        public byte Seconds { get; set; }

        [XmlAttribute]
        public byte Thirds { get; set; }
    }
}