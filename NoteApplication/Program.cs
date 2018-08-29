using System;
using System.IO;


namespace NoteApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("NoteList.xml"))
            {
                var xml = new NewXML();
                xml.New();
            }
            while (true)
            {
                Console.WriteLine("[1] New Note\n[2] Delete Note\n[3] View Note/s\n[4] Exit application");
                Console.WriteLine("Enter a valid option: ");
                string input = Convert.ToString(Console.ReadLine());

                if (input == "1" || input == "New")
                {
                    var newNote = new NewNote();
                    newNote.New();
                }
                else if (input == "2" || input == "Delete")
                {
                    var deleteNote = new DeleteNote();
                    deleteNote.Delete();
                }
                else if (input == "3" || input == "View")
                {
                    var viewNotes = new ViewNotes();
                    viewNotes.View();
                }
                else if (input == "4" || input == "Exit")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid input, Try Again!");
                }
            }
        }
    }
}
