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
            xmlWriter.WriteAttributeString("title", "ExampleTitle");
            xmlWriter.WriteAttributeString("content", "ExampleContent");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }
    }
}
