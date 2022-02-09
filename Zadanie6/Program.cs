// * Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).

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
            Console.SetCursorPosition(x / 2 - 10, y / 2);

            
        }
        static void Pause()
        {
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            Console.Title = "Даниил Здор";
            Print();
            Pause();

        }
    }
}