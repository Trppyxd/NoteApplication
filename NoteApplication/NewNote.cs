using System;
using System.Xml.Linq;

namespace NoteApplication
{
    class NewNote
    {
        public void New()
        {
            Console.WriteLine("Enter title: ");
            string title = Console.ReadLine();

            Console.WriteLine("Enter content: ");
            string content = Console.ReadLine();


            XElement xml = XElement.Load("NoteList.xml");

            xml.Add(new XElement("Note"));
            xml.Add(new XAttribute("title", title));
            xml.Add(new XAttribute("content", content));

            xml.Save("NoteList.xml");
        }
    }
}
