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
            else
            {
                while (true)
                {

                    Console.WriteLine("\n#####################");
                    Console.WriteLine("[1] New Note\n[2] Delete Note\n[3] View Note/s\n[4] Exit application\n");
                    Console.WriteLine("Enter a valid option: ");
                    string input = Console.ReadLine().ToString();

                    if (input == "1" || input == "New")
                    {
                        Console.Clear();
                        var newNote = new NewNote();
                        newNote.New();
                    }
                    else if (input == "2" || input == "Delete")
                    {
                        Console.Clear();
                        var deleteNote = new DeleteNote();
                        deleteNote.Delete();
                    }
                    else if (input == "3" || input == "View")
                    {
                        Console.Clear();
                        ViewNotes viewNotes = new ViewNotes();
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
}
