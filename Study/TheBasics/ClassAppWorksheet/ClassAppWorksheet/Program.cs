using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAppWorksheet
{
    class Program
    {
        static void Main(string[] args)
        {
            People _yhwh = new People();
            /*Console.WriteLine("Please enter your name:");
            _yhwh.Name = Console.ReadLine();
            Console.WriteLine("\nPlease enter your surname:");
            _yhwh.Surname = Console.ReadLine();
            Console.WriteLine("\nPlease enter your patronymic:");
            _yhwh.Patronymic = Console.ReadLine();
            Console.WriteLine("\nPlease enter your sex:");
            _yhwh.Sex = Console.ReadLine();
            Console.WriteLine("\nPlease enter your education:");
            _yhwh.Education = Console.ReadLine();
            Console.WriteLine("\nPlease enter your city:");
            _yhwh.City = Console.ReadLine();
            Console.WriteLine("\nPlease enter your year of birth:");
            _yhwh.Birth = Convert.ToInt32(Console.ReadLine());
            _yhwh.GetWorksheet();
            */
            Console.WriteLine("Hash code of this object: " + _yhwh.GetHashCode());
            Console.WriteLine("Type of this object: " + _yhwh.GetType());

            Console.ReadKey();
        }
    }
}
