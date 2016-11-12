namespace TomeGenerator
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    public class Fields
    {
        #region Fields

        [XmlElement("Field")]
        public List<Field> FieldList;

        #endregion
    }
}