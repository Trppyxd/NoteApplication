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

            int i = 1;
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                Console.WriteLine("[" + i.ToString() + "] " + node.Attributes["title"].InnerText);
                i++;
            }
            Console.WriteLine("Enter the prefix of the note you wish to delete: ");
            int input = int.Parse(Console.ReadLine()) - 1;
            XmlNode root = doc.DocumentElement;

            root.RemoveChild(root.ChildNodes[input]);
            Console.WriteLine("Note {0} successfully deleted!", ++input);
            
            doc.Save("NoteList.xml");
        }
    }
}
