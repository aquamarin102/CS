//  а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
//  Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
//  б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
using System;

namespace Hello_CS
{
    internal class Program
    {
        static double Range(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.Title = "Даниил Здор";

            Console.Write("Ввндите координату x первой точки: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Ввндите координату x второй точки: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Ввндите координату y первой точки: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Ввндите координату y второй точки: ");
            double y2 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Расстояние между точками: {0:f2}", Range(x1, x2, y1, y2));
            
        }
    }
}