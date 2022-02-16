using System;
using System.Linq;

namespace palindromo14
{
    class Program
    {
        public static bool checkPalindrome2(string mainString)
        {
            return mainString.SequenceEqual(mainString.Reverse());
        }
        static void Main(string[] args)
        {
            bool palin = checkPalindrome2("12321");
            Console.WriteLine(palin);
        }
    }
}