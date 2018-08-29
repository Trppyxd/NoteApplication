using System;
using System.Xml;

namespace NoteApplication
{
    class ViewNotes
    {
        public void View()
        {
            Console.WriteLine("Notes: ");
            XmlDocument doc = new XmlDocument();
            doc.Load("NoteList.xml");

            int ID = 1;

            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                Console.WriteLine("[" + ID.ToString() + "] " + node.Attributes["title"].InnerText);
                // Ex. preview "[1] NoteTitle"
                ID++;
            }
            Console.WriteLine("\nEnter the note prefix you wish to view (Corresponding number).");
            int i = int.Parse(Console.ReadLine()) - 1;
            // i = Note Index
            Console.WriteLine("\n  Title: " + doc.DocumentElement.ChildNodes[i].Attributes["title"].InnerText);
            Console.WriteLine("Content: " + doc.DocumentElement.ChildNodes[i].Attributes["content"].InnerText);
            
        }
    }
}
