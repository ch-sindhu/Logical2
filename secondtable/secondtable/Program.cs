using System;

namespace secondtable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", n, i, (n * i));
            }
            Console.ReadLine();
        }
    }
}
