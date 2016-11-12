namespace TomeGenerator
{
    using System.Xml.Serialization;

    public class Facet
    {
        #region Fields

        [XmlAttribute]
        public string Key;

        [XmlAttribute]
        public string Value;

        #endregion
    }
}