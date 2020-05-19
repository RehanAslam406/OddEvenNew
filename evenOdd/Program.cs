using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evenOdd
{
    class Program
    {

        public static void checkEven(int num)
        {
            if (num % 2 == 0)
                Console.WriteLine("This number is an even number");
            else
                Console.WriteLine("This number is an odd number");
        }
        static void Main(string[] args)
        {
            checkEven(10);

            String s1 = "TechBeamers";
            String s2 = "Welcomes its readers";
            String s3 = s2;
            Console.WriteLine((s3 == s2) + " " + s2.Equals(s3));
            Console.ReadLine();


            Console.ReadLine();
        }
    }
}
