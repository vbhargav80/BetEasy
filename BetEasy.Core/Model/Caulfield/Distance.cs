using System;
using System.Xml.Serialization;

namespace BetEasy.Core.Model.Caulfield
{
    [Serializable]
    [XmlType(AnonymousType = true)]
    public class Distance
    {
        [XmlAttribute]
        public ushort Metres { get; set; }
    }
}