using System;
using System.Xml;

namespace NoteApplication
{
    class DeleteNote
    {
        public void Delete()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("NoteList.xml");

            Console.WriteLine("Enter the prefix of the note you wish to delete: ");
            int i = 1;
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                Console.WriteLine(i.ToString() + "[{0}] ", i + node.Attributes["title"].InnerText);
                i++;
            }
            int input = int.Parse(Console.ReadLine());
            XmlNode root = doc.DocumentElement;

            root.RemoveChild(root.ChildNodes[input]);
            doc.Save("NoteList.xml");
        }
    }
}
