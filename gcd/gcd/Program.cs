using System;

namespace gcd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, gcd = 1;
            Console.Write("Enter firstNumber:");

            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter secondNumber:");
            n2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n1 && i <= n2; ++i)
            {
                if(n1%i==0 &&n2%i==0)
                {
                    gcd = i;
                }
                Console.WriteLine("G.C.D of {0} and {1} is {2}", n1, n2, gcd);
            }

        }
    }
}
