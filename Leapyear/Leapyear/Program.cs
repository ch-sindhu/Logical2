using System;

namespace Leapyear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Year : ");
            int Year = int.Parse(Console.ReadLine());
            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine( Year + " is Leap year");
            }
            else
            {
                Console.WriteLine(Year + "is not a leap year");
            }
            Console.ReadLine();
        }
    }
}
