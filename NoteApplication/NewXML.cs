using System.Xml;

namespace NoteApplication
{
    class NewXML
    {
        public void New()
        {
            XmlWriter xmlWriter = XmlWriter.Create("NoteList.xml");

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("NoteList");
            xmlWriter.WriteStartElement("Note");
            // "ExampleTitle" and "ExampleContent" will be overwritten.
            xmlWriter.WriteAttributeString("title", "ExampleTitle");
            xmlWriter.WriteAttributeString("content", "ExampleContent");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }
    }
}
