// Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
// а) с использованием третьей переменной;
// б) *без использования третьей переменной.
using System;

namespace Hello_CS
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.Title = "Даниил Здор";

            Console.Write("Ввндите a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Ввндите b: ");
            int b = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Значение а: {a} Значение b: {b}");

        }
    }
}