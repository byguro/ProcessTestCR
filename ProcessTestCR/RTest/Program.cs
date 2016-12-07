using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("GUID:" +Guid.NewGuid());
            }


            Console.ReadLine();
        }
    }
}
