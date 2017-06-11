namespace TomeGenerator
{
    using System.Collections.Generic;
    using System.IO;
    using System.Xml;
    using System.Xml.Serialization;

    internal class Program
    {
        #region Methods

        private static void Main(string[] args)
        {
            const int FieldCount = 1000;
            const int RecordCount = 2000;
            const int FieldsPerRecord = 50;

            // Generate fields.
            var fields = new Fields { FieldList = new List<Field>(FieldCount) };

            for (var i = 0; i < FieldCount; ++i)
            {
                var field = new Field
                {
                    Id = $"Field{i}",
                    DisplayName = $"Field{i}",
                    Type = "String",
                    DefaultValue = $"DefaultValue{i}",
                    Description = $"Description{i}"
                };
                fields.FieldList.Add(field);
            }

            var serializer = new XmlSerializer(typeof(Fields));
            var fieldsFile = new FileInfo("Another Tome Project.tfields");

            using (var textWriter = fieldsFile.CreateText())
            {
                serializer.Serialize(textWriter, fields);
            }

            // Generate records.
            var recordsFile = new FileInfo("Another Tome Project.tdata");

            using (var textWriter = recordsFile.CreateText())
            {
                var xmlWriterSettings = new XmlWriterSettings { Indent = true };

                using (var xmlWriter = XmlWriter.Create(textWriter, xmlWriterSettings))
                {
                    xmlWriter.WriteStartElement("Records");
                    {
                        for (var i = 0; i < RecordCount; ++i)
                        {
                            xmlWriter.WriteStartElement("Record");
                            {
                                xmlWriter.WriteAttributeString("Id", $"Record{i}");
                                xmlWriter.WriteAttributeString("DisplayName", $"Record{i}");

                                for (var j = 0; j < FieldsPerRecord; ++j)
                                {
                                    xmlWriter.WriteStartElement($"Field{j}");
                                    xmlWriter.WriteAttributeString("Value", $"Value{j}");
                                    xmlWriter.WriteEndElement();
                                }
                            }
                            xmlWriter.WriteEndElement();
                        }
                    }
                    xmlWriter.WriteEndElement();
                }
            }
        }

        #endregion
    }
}