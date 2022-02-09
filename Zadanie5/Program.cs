//а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) Сделать задание, только вывод организовать в центре экрана.
//в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x, int y).
using System;

namespace Hello_CS
{
    internal class Program
    {

        static void Print()
        {
            Console.Write("Ввндите ширину экрана: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Ввндите высоту экрана: ");

            int y = int.Parse(Console.ReadLine());
            Console.WindowHeight = y;
            Console.WindowWidth = x;
            Console.BufferHeight = y;
            Console.BufferWidth = x;
            Console.SetCursorPosition(x/2-10, y/2);

        }
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.Title = "Даниил Здор";


            Print();

            Console.Write("Daniil Zdor Minsk");

        }
    }
}