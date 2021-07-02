using System;

namespace VowelOrConso
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a character");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch=='a'|| ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'O' || ch == 'U' || ch == 'I' )
            {
               Console.WriteLine(ch + " is Vowel.");
            }
            else
            {
                Console.WriteLine(ch + "is consonate");
            }

        }
    }
}
