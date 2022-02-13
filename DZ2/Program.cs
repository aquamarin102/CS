using System;

namespace Hello_CS
{
    internal class Program
    {
        static void Task1() //Написать метод, возвращающий минимальное из трёх чисел.
        {

            Console.WriteLine("Введите 3 значения:");
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            double c = double.Parse(Console.ReadLine());


            if (a < b && a < c)
            {
                Console.WriteLine("Наименьшее значение: a=" + a);
            }
            else if (b < c && b < a)
            {
                Console.WriteLine("Наименьшее значение: b=" + b);
            }
            else
            { Console.WriteLine("Наименьшее значение: c=" + c); }
        }
        static void Task2() //Написать метод подсчета количества цифр числа.
        {
            Console.WriteLine("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            int i = 0;
            while(a >= 0)
            {
                ++i;
                a = a / 10;
            }
            Console.WriteLine("В вашем числе " + i + " цифр");
        }
        static void Task3() //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
        {
            Console.WriteLine("Вводите числа: ");
            
            double sum = 0;
            
                double d = double.Parse(Console.ReadLine());
            while (d != 0)
            {
                
                if ( d % 2 == 1)
                {
                    sum = sum + d;
                }
                
                d = double.Parse(Console.ReadLine());
            }
            

            Console.WriteLine("Сумма нечетных чисел:" + sum);
        }
        static void Task4() //Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. На выходе истина, если прошел авторизацию,
                            //и ложь, если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу:
                            //пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
        {
            int i=0;
            do
            {
                Console.WriteLine("Введите логин");
                String l = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                String p = Console.ReadLine();
                if (Check(l, p) == true)
                {
                    Console.WriteLine("Логин и пароль верны");
                    break;
                }
                else
                {
                    Console.WriteLine("Попробуйте еще раз");
                    i++;
                }

            } while (i < 3);
             
        }

        static void Task5() //а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть,
                            //набрать вес или всё в норме.
                            //б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        {
            double m, h, I, mI, mN;
            string x;
            Console.Write("Введите вес человекав килограммах: ");
            x = Console.ReadLine();
            m = double.Parse(x);

            Console.Write("Введите рост человека в метрах: ");
            x = Console.ReadLine();
            h = double.Parse(x);

            I = I = m / (h * h);
            Console.Write("Индек массы тела равен: {0:N} кг/м^2", I);
            
            if(I< 20)
            {
                mN = 20 * h * h;
                Console.WriteLine("Недостаток веса. Для нормального веса необходимо набрать {0:f2} кг", (mN-m));
            }
            else if (I > 25)
            {
                mI=25* h * h;
                Console.WriteLine("Избыточный вес. Для похудения нужно сбросить {0:f2} кг", (m-mI));
            }
            else
            {
                Console.WriteLine("Нормальный вес");
            }
        }
        static void Task6() //*Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
                            //«Хорошим» называется число, которое делится на сумму своих цифр. Реализовать подсчёт времени выполнения программы, используя структуру DateTime.
        {
            DateTime start = DateTime.Now;
            int a=0;
            for(int i = 1;i <= 1000000000; i++)
            { 
              if (i%sum(i) == 0)
                {
                    a++;
                }
              

            }
            Console.WriteLine(a);
            DateTime end = DateTime.Now;
            Console.WriteLine("Время выполнения:" + (end - start));
        }
        static void Task7()//a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
                           //б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
        {
            Console.WriteLine("Введите число a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b = int.Parse(Console.ReadLine());
            recurs(a, b);
            Console.WriteLine(recursum(a, b));
        }

        static   bool Check(string login, string password)
        {
            string reallogin = "root";
            string realpassword = "GeekBrains";


            if (login == reallogin && password == realpassword)
            {


                return true;
            }
            else
            {
                
                return false;
            }
        }

        static long sum(long a)
        {
            if (a == 0)
                return 0;
            else return sum(a / 10) + a % 10;
        }
        static void recurs(int a, int b)
        {
            
            Console.Write(a+" ");
        
            if (a < b) recurs(a + 1, b);
           
        }
        static int recursum(int a, int b)
        {

            

            if (a <= b)
            {
              return  recursum(a + 1, b) + a; }
            else return 0;
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.Title = "Даниил Здор";

            Console.WriteLine("1 - task 1");
            Console.WriteLine("2 - task 2");
            Console.WriteLine("3 - task 3");
            Console.WriteLine("4 - task 4");
            Console.WriteLine("5 - task 5");
            Console.WriteLine("6 - task 6");
            Console.WriteLine("7 - task 7");
            Console.WriteLine("0 - exit");

            

            do
            {
                Console.WriteLine("Выберите задание");
                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        Task1();
                        break;
                    case "2":
                        Task2();
                        break;
                    case "3":
                        Task3();
                        break;
                    case "4":
                        Task4();
                        break;
                    case "5":
                        Task5();
                        break;
                    case "6":
                        Task6();
                        break;
                    case "7":
                        Task7();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Error");
                        break;
                }


            }while (true);  
        }
    }
}