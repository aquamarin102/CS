namespace dz6
{
 
    public delegate double Fun(double x, double a);
    public delegate double F(double x);

    class Program
    {
        // Создаем метод, который принимает делегат
        // На практике этот метод сможет принимать любой метод
        // с такой же сигнатурой, как у делегата
        public static void Table(Fun F, double x,double a, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x,a));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }
        // Создаем метод для передачи его в качестве параметра в Table
        public static double MyFunc(double x, double a)
        {
            return a * x * x;
        }

        public static double MyFuncSin(double x, double a)
        {
            return a * Math.Sin(x);
        }

            public static double Func(double x)
            {
                return x * x - 50 * x + 10;
            }
            public static void SaveFunc(F f, string fileName, double a, double b, double h)
            {
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                double x = a;
                while (x <= b)
                {
                    bw.Write(f(x));
                    x += h;// x=x+h;
                }
                bw.Close();
                fs.Close();
            }
            
            public static double[] Load(string fileName, out double min)
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryReader bw = new BinaryReader(fs);
                min = double.MaxValue;
                double[] d = new double[fs.Length];
                for (int i = 0; i < fs.Length / sizeof(double); i++)
                {
                    // Считываем значение и переходим к следующему
                    d[i] = bw.ReadDouble();

                    if (d[i] < min) min = d[i];
                }
                Console.WriteLine("");
                bw.Close();
                fs.Close();
                return d;

            }
            

        //Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). Продемонстрировать работу на функции с функцией a* x^2 и функцией a* sin(x).
        static void Task1()
        {
           
            Console.WriteLine("Таблица функции a*x^2:");
                        
            Table(MyFunc, -2, 2, 2);
            Console.WriteLine("Таблица функции a*Sin(x):");
            Table(MyFuncSin, -2, 2, 2);
           

        }
        //Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
        //б) *Переделать функцию Load, чтобы она возвращала массив считанных значений.Пусть она возвращает минимум через параметр (с использованием модификатора out). 
        static void Task2()
        {
            double min;
            
            SaveFunc(Func,"data.bin", -100, 100, 0.5);
            Load("data.bin", out min);
            Console.WriteLine(min);
            Console.ReadKey();

        }

        static void Main()
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