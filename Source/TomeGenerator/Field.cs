﻿namespace TomeGenerator
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public class Field
    {
        #region Fields

        [XmlAttribute]
        public string DefaultValue;

        [XmlAttribute]
        public string Description;

        [XmlAttribute]
        public string DisplayName;

        [XmlElement("Facet")]
        public List<Facet> Facets;

        [XmlAttribute]
        public string Id;

        [XmlAttribute]
        public string Type;

        #endregion
    }
}