using System;
using System.Xml.Linq;

namespace NoteApplication
{
    class NewNote
    {
        public void New()
        {
            Console.WriteLine("Enter title: ");
            string title = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter content: ");
            string content = Convert.ToString(Console.ReadLine());


            XElement xml = XElement.Load("NoteList.xml");

            xml.Add(new XElement("Note", new XAttribute("title", title), new XAttribute("content", content)));

            xml.Save("NoteList.xml");
        }
    }
}
