using System;

namespace factors
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                Console.WriteLine("natural numbers are"  +  i);
                sum = sum + i; 
            }
            Console.WriteLine("sum of nos"     +   sum);

        }
    }
}
