using System.Text;
using System.IO;
using System.Text.RegularExpressions;
namespace dz4
{
    struct Element
    {
        public string FIO;
        public double N;

        public override string ToString()
        {
            return FIO + N;
        }
    }

    class Program
    {

        //Создать программу, которая будет проверять корректность ввода логина.Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
        //а) без использования регулярных выражений;
        //б) **с использованием регулярных выражений. 
        static void Task1()
        {

            string s = Console.ReadLine();

            char[] b = s.ToCharArray();
            if (b[0] >= '0' && b[0] <= '9')
            {
                Console.WriteLine("Wrong");

            }
            else if (b.Length < 3 || b.Length > 11) {
                Console.WriteLine("Wrong");
            }
            else
            {
                int c = 0;
                for (int i = 0; i < b.Length; i++)
                {

                    if ((b[i] >= '0' && b[i] <= '9') || (b[i] >= 'a' && b[i] <= 'z'))
                    {
                        c++;
                    }
                    else
                    {

                        break;
                    }


                }
                if (c == b.Length)
                {
                    Console.WriteLine("authorization");
                }
                else { Console.WriteLine("Wrong"); }
            }
        }

        static void Task2()
        {

        }
        static void Task3()
        {
            StreamReader sr = new StreamReader("..\\..\\data.txt");
            int N = int.Parse(sr.ReadLine());
            Element[] a = new Element[N];

            for (int i = 0; i < N; i++)
            {
                string[] s = sr.ReadLine().Split(' ');
                a[i].FIO = s[0] + s[1];
                a[i].N = (double.Parse(s[2]) + double.Parse(s[3]) + double.Parse(s[4])) / 3;
            }
            sr?.Close();
            int[] massiv = new int[100];
            double min1 = 5;
            double min2 = 5;
            double min3 = 5;
            int d=0,b=0,c=0;
            for (int i = 0; i < N; i++)
            {
                if (a[i].N < min1 )
                {
                    min3 = min2;
                    min2 = min1;
                    min1 = a[i].N;
                    
                }
               else if (a[i].N < min2  )
                    {
                    min3 = min2;
                    min2 = a[i].N;

                }
                else  if (a[i].N < min3 )
                {

                    min3 = a[i].N;

                }
            }
            for (int i = 0; i < N; i++)
            {
                if(a[i].N <= min3)
                {
                    Console.WriteLine(a[i]);
                }
            }





        }


        static void Main(string[] args)
        {

            Console.Title = "Даниил Здор";

            Console.WriteLine("1 - task 1");
            Console.WriteLine("2 - task 2");
            Console.WriteLine("3 - task 3");


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

                    case "0":
                        return;
                    default:
                        Console.WriteLine("Error");
                        break;
                }


            } while (true);
        }
    }

}