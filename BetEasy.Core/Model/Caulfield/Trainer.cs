using System;
using System.Xml.Serialization;

namespace BetEasy.Core.Model.Caulfield
{
    [Serializable]
    public class Trainer
    {
        [XmlArrayItem("statistic")]
        public Statistic[] Statistics { get; set; }

        [XmlAttribute]
        public string Name { get; set; }

        [XmlAttribute]
        public int Id { get; set; }
    }
}