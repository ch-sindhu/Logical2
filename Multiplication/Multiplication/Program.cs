using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine("{0} X {1} = {2}" ,n,i, (n * i));
            }
            Console.ReadLine();


        }
    }
}
