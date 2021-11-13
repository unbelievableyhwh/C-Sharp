using System;

namespace CorporateDistributionBot
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBaseObject ob = new DataBaseObject();
            string[] messages = ob.getMessage();
            for(int i=0; i<messages.Length; i++)
            {
                Console.WriteLine(messages[i]);
            }
            
        }
    }
}
