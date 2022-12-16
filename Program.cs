using System;
using static System.Console;
    class Program
    {
        static void Main(string[] args)
        {
            char ACodeInput = char.Parse(Console.ReadLine());
            int ascii = Convert.ToInt32(ACodeInput);
            Console.WriteLine(ascii);
        }
    }