using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dylan_Gomer_Hello_Git
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello Git World");
            Console.WriteLine("Give a number: ");

            int number = Convert.ToInt32(Console.ReadLine());

            number = number * 10;

            Console.WriteLine("Your number times 10 is {0}", number);

        }
    }
}
