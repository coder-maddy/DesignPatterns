using System;
using System.Diagnostics;

namespace SingleReponsbility
{
    class Program
    {
        static void Main(string[] args)
        {
            Violation.Journal journal = new Violation.Journal();
            journal.Add("Meeting at 10");
            journal.Add("Dinner at 9");
            Console.WriteLine(journal);

            Journal newJournal = new Journal();
            newJournal.Add("Meeting at 10");
            newJournal.Add("Dinner at 9");
            Console.WriteLine(newJournal);

            Persistance persistance = new Persistance();
            var fileName = "temp.txt";
            persistance.Save(newJournal, fileName, true);

            Console.ReadLine();


        }
    }
}
