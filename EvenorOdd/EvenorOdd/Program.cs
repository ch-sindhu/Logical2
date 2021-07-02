using System;

namespace EvenorOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a no");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
    }
}
