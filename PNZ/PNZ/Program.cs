using System;

namespace PNZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num>0)
            {
                Console.WriteLine("Number is positive");
            }
            else if(num<0)
            {
                Console.WriteLine("Number is negative");
            }
             else
            {
                Console.WriteLine("number is zero");
            }
            Console.ReadLine();

        }
    }
}
