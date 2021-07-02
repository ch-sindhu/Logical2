using System;

namespace Alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character");
            char ch = Convert.ToChar(Console.ReadLine());
            if((ch>='a'&& ch<='z') || (ch>='A'&& ch<='Z'))
            {
                Console.WriteLine(ch + "is an alphabet");
            }
            else if(ch >='0' && ch <='9')
            {
                Console.WriteLine(ch + "is a number");
            }
            else
            {
                Console.WriteLine(ch + "is a special character");   
            }
        }

    }
}

