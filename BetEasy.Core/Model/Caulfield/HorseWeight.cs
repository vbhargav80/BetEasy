using System;
using System.Xml.Serialization;

namespace BetEasy.Core.Model.Caulfield
{
    [Serializable]
    public class HorseWeight
    {
        [XmlAttribute]
        public int Allocated { get; set; }

        [XmlAttribute]
        public int Total { get; set; }
    }
}