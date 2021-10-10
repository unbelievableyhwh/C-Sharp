using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAppWorksheet
{
    class Program
    {
        public class People
        {
            public string name, surname, patronymic, city, education, sex;
            public int birth;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string Surname
            {
                get { return surname; }
                set { surname = value; }
            }
            public string Patronymic
            {
                get { return patronymic; }
                set { patronymic = value; }
            }
            public string City
            {
                get { return city; }
                set { city = value; }
            }
            public string Education
            {
                get { return education; }
                set { education = value; }
            }
            public string Sex
            {
                get { return sex; }
                set { sex = value; }
            }
            public int Birth
            {
                get { return birth; }
                set { birth = value; }
            }
            public int GetAge()
            {
                int age = 2021 - birth;
                return age;
            }
            public void GetWorksheet()
            {
                Console.WriteLine("Your worksheet:");
                Console.WriteLine($"\nName - {Surname} { Name } {Patronymic}");
                Console.WriteLine($"Sex - {Sex}");
                Console.WriteLine($"Education - {Education}");
                Console.WriteLine($"City - {City}");
                Console.WriteLine($"Age - {GetAge()}");
            }
        }
        static void Main(string[] args)
        {
            People _yhwh = new People();
            Console.WriteLine("Please enter your name:");
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


            Console.ReadKey();
        }
    }
}
