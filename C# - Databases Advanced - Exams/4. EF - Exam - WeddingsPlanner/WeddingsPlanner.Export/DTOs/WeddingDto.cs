﻿namespace WeddingsPlanner.Export.DTOs
{
    using System.Xml.Serialization;
    using System.Collections.Generic;

    [XmlType("wedding")]
    public class WeddingDto
    {
        [XmlAttribute("cash")]
        public decimal Cash { get; set; }

        [XmlAttribute("presents")]
        public int Present { get; set; }

        [XmlElement("bride")]
        public string Bride { get; set; }

        [XmlElement("bridegroom")]
        public string Bridegroom { get; set; }

        [XmlArray("guests")]
        [XmlArrayItem("guest")]
        public List<GuestDto> Guests { get; set; }
    }
}