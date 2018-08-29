using System;
using System.Xml;

namespace NoteApplication
{
    class ViewNotes
    {
        public void View()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("NoteList.xml");

            int ID = 1;

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                Console.WriteLine(ID.ToString() + "[{0}] ", ID + node.Attributes["title"].InnerText);
                // Ex. preview "[1] NoteTitle"
                ID++;
            }

            Console.WriteLine("\nEnter note prefix (Corresponding number).");
            int i = int.Parse(Console.ReadLine()) - 1;
            // i = Note Index
            Console.WriteLine(doc.DocumentElement.ChildNodes[i].Attributes["title"].InnerText);
            Console.WriteLine(doc.DocumentElement.ChildNodes[i].Attributes["content"].InnerText);
        }
    }
}
