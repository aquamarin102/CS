//1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
//а) используя склеивание;
//б) используя форматированный вывод;
//в) используя вывод со знаком $.
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

            string name, surname, x;
            int age, high, weigh;

            Console.Write("Введите свое имя: ");
            name = Console.ReadLine();

            Console.Write("Введите свою фамилию : ");
            surname = Console.ReadLine();

            Console.Write("Введите свой возраст : ");
            x = Console.ReadLine();
            age = int.Parse(x);

            Console.Write("Введите свой рост : ");
            x = Console.ReadLine();
            high = int.Parse(x);

            Console.Write("Введите свой вес : ");
            x = Console.ReadLine();
            weigh = int.Parse(x);

            Console.WriteLine(name + " " + surname + " " + age.ToString() + " " + high.ToString() + " " + weigh.ToString());//Склейка строк
            Console.WriteLine("{0} {1} {2} {3} {4}" ,name, surname, age, high, weigh);//строка форматирования 
            Console.WriteLine($"{name} {surname} {age} {high} {weigh}", name, surname, age, high, weigh);// Строка интерполяции

           
        }
    }
}