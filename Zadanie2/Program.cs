//  Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
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

            double m, h, I;
            string x;
            Console.Write("Введите вес человекав килограммах: ");
            x = Console.ReadLine();
            m = double.Parse(x);

            Console.Write("Введите рост человека в метрах: ");
            x = Console.ReadLine();
            h = double.Parse(x);

           I = I = m / (h * h);
            Console.Write("Индек массы тела равен: {0:N} кг/м^2", I);
        }
    }
}