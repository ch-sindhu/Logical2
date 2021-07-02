using System;

namespace FactorsOf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a no");
            int no = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=no;i++)
            {
                if(no % i ==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
