using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WorkinConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello World!");
            */
            Console.Title = "Цвета консоли";
            ConsoleColor[] colors = { ConsoleColor.Blue, ConsoleColor.Red, ConsoleColor.White, ConsoleColor.Magenta, ConsoleColor.DarkYellow, ConsoleColor.Cyan, ConsoleColor.Green, ConsoleColor.DarkGray };
            while (true)
            {
                foreach (ConsoleColor color in colors)
                {
                    Console.CursorLeft = (Console.BufferWidth - ConsoleColor.Blue.ToString().Length) / 2;
                    Console.CursorTop = 10;
                    Console.ForegroundColor = color;
                    Console.WriteLine("YHWH");
                    Thread.Sleep(500);
                    Console.Clear();
                }
            }


            Console.ReadKey();
        }
    }
}
