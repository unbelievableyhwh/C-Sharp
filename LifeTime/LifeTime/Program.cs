using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LifeTime
{
    class Program
    {
        public static void ConsoleView()
        {
            Console.Title = "LifeTime";
            Console.CursorLeft = 20;
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
        static void Main(string[] args)
        {
            Console.WriteLine();
            ConsoleView();
            string[] formats = { "dd.MM.yyyy", "dd.MM.yyyy HH:mm" };
            Console.WriteLine("Please enter your date of birth (for example '05.07.1999' or '05.07.1999 23:30')\n");
            Console.CursorLeft = 55;
            string dateStrings = Console.ReadLine();
            Console.Clear();
            DateTime parsedDate;
            if (DateTime.TryParseExact(dateStrings, formats, null, System.Globalization.DateTimeStyles.AllowWhiteSpaces | System.Globalization.DateTimeStyles.AdjustToUniversal, out parsedDate))
            {
                TimeSpan timeSpan = DateTime.Now - parsedDate;
                Thread.Sleep(1500);
                Console.CursorLeft = 40;
                Console.WriteLine($"Your date of birth - {parsedDate}\n");
                Thread.Sleep(1500);
                Console.CursorLeft = 35;
                Console.WriteLine($"You lived: {timeSpan.Days} Days, {timeSpan.Hours} Hours, {timeSpan.Minutes} Minutes, {timeSpan.Seconds} Seconds\n");
                Thread.Sleep(1500);
                Console.CursorLeft = 55;
                Console.WriteLine($"Memento Mori");
            }
            else
            {
                Console.CursorLeft = 45;
                Console.WriteLine("You enter a wrong date!!!");
            }
            
            Console.ReadKey();
        }
    }
}
