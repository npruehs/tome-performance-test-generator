namespace TomeGenerator
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

        [XmlAttribute]
        public string Id;

        [XmlAttribute]
        public string Type;

        #endregion
    }
}