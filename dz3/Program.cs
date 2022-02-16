

namespace Myname
{
   
    struct Complex
    {
        public double im;
        public double re;

        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
    public Complex Minus(Complex x)
    {
        Complex y;
        y.im = im - x.im;
        y.re = re - x.re;
        return y;
    }

    public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }
    class classComplex
    {

        private double im, re;

        public classComplex()
        {
            im = 0;
            re = 0;
        }

        public classComplex(double _im, double re)
        {
              
            im = _im;
            this.re = re;
        }
        public classComplex classPlus(classComplex x2)
        {
            classComplex x3 = new classComplex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }
        public classComplex classMinus(classComplex x2)
        {
            classComplex x3 = new classComplex();
            x3.im = im - x2.im;
            x3.re =  re - x2.re;
            return x3;
        }
        public classComplex classMulti(classComplex x2)
        {
            classComplex x3 = new classComplex();
            x3.im = re * x2.im + im * x2.re;
            x3.re = re * x2.re - im * x2.im;
            return x3;
        }

        public string classToString()
        {
            return re + "+" + im + "i";
        }
    }
    class fraction
    {
        private int i, j;

        public fraction()
        {
            i = 0;
            j = 0;
        }

        public fraction(int _i, int j)
        {

            i = _i;
            this.j = j;
        }

        public int I
        {
            get;
            set;
        }

        public int J
        {
            get { return j; }
            set
            {
                if (value == 0) throw new ArgumentException("Знаменатель не может быть равен 0");
                j = value;
            }
        }

        

        public fraction fractionPlus(fraction x2)
        {
            fraction x3 = new fraction();
            if (x2.j == j)
            {
                x3.i = x2.i + i;
                x3.j = x2.j;

            }
            else {
                x3.j = x2.j * j;
                x3.i = (x2.i * j)+(i * x2.j);

            }
            return x3;

        }
        
        public fraction fractionMinus(fraction x2)
        {
            fraction x3 = new fraction();
            if (x2.j == j)
            {
                x3.i = i - x2.i;
                x3.j = x2.j;

            }
            else
            {
                x3.j = x2.j * j;
                x3.i = (i * x2.j) - (x2.i * j);

            }
            return x3;
        }
 
        public fraction fractionMulti(fraction x2)
        {
            fraction x3 = new fraction();

            x3.i = x2.i * i;
            x3.j = x2.j * j;

            return x3;
        }
        public fraction fractionDivision(fraction x2)
        {
            fraction x3 = new fraction();

            x3.i = i * x2.j;
            x3.j = j * x2.i ;

            return x3;
        }
      
        public double fication10
        {
            get { return  (double)i / (double)j; }
      

        }
        public string simpl(fraction x)
        {
            int b = 0;
            for(int k = 2; k < 10; k++)
            {
                while (i % k == 0 && j % k == 0) 
                {
                    i = i / k;
                    j = j / k;
                    b++;
                }
            }
            return b + " " + i + "/" + j;
        }
        public string fractionToString()
        {
            return i + "/" + j;
        }
        
       
        
        
    }


    class program
    {
        //а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
        //б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
        //в) Добавить диалог с использованием switch демонстрирующий работу класса.
        static void Task1()
        {

            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;
            Console.WriteLine("ИСпользование Структуры");
            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Minus(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString());


            

            classComplex classcomplex1;

            classcomplex1 = new classComplex(1, 1);

            classComplex classcomplex2 = new classComplex(2, 2);

            classComplex classresult;

            
            do
            {
                Console.WriteLine("ИСпользование КЛасс");
                Console.WriteLine("Выберите действие");
                Console.WriteLine("1 - Сложение");
                Console.WriteLine("2 - Вычитание");
                Console.WriteLine("3 - Умножение");
                Console.WriteLine("0 - exit");
                string classs= Console.ReadLine();
                switch (classs)
                {
                    case "1":
                        classresult = classcomplex1.classPlus(classcomplex2);
                        Console.WriteLine(classresult.classToString());
                        break;
                    case "2":
                        classresult = classcomplex1.classMinus(classcomplex2);
                        Console.WriteLine(classresult.classToString());
                        break;
                    case "3":
                        classresult = classcomplex1.classMulti(classcomplex2);
                        Console.WriteLine(classresult.classToString());
                        break;

                    case "0":
                        return;
                    default:
                        Console.WriteLine("Error");
                        break;
                }

            } while (true);

        }
        
        
        static int GetValue()
        {
            int x, sum = 0 ;
            string s;
            bool flag;

            do
            {
                
                Console.WriteLine("Введите число: ");
                s = Console.ReadLine();
                
                flag = int.TryParse(s, out x);
                 if (x % 2 == 1)
                {
                    Console.WriteLine("Число нечетное");
                    return sum = x + GetValue();
                }
                else if (s == "0")
                {
                     flag = true;
                }
                else if (x % 2 == 0)
                {
                    flag = false;
                }
                else   flag= false;
            }
            while (!flag);
            //  Пока false(!false=true), повторять цикл
           
            return sum;
            
        }

        static void Task2() //С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
        { 
            Console.WriteLine("Ссума нечетных чисел: " + GetValue());
        }
        static void Task3()
        {
            fraction fraction1;

            fraction1 = new fraction(1, 0);

            fraction1.J = 2;

            fraction fraction2 = new fraction(2, 2);

            fraction2.J = 5;

            fraction fractionresult;


            do
            {

                Console.WriteLine("Выберите действие");
                Console.WriteLine("1 - Сложение");
                Console.WriteLine("2 - Вычитание");
                Console.WriteLine("3 - Умножение");
                Console.WriteLine("4 - Деление");
                Console.WriteLine("0 - exit");
                string classs = Console.ReadLine();
                switch (classs)
                {
                    case "1":
                        fractionresult = fraction1.fractionPlus(fraction2);
                        Console.WriteLine(fractionresult.fractionToString());
                        Console.WriteLine(fractionresult.fication10);
                        Console.WriteLine(fractionresult.simpl(fractionresult));
                        break;
                    case "2":
                        fractionresult = fraction1.fractionMinus(fraction2);
                        Console.WriteLine(fractionresult.fractionToString());
                        Console.WriteLine(fractionresult.fication10);
                        Console.WriteLine(fractionresult.simpl(fractionresult));
                        break;
                    case "3":
                        fractionresult = fraction1.fractionMulti(fraction2);
                        Console.WriteLine(fractionresult.fractionToString());
                        Console.WriteLine(fractionresult.fication10);
                        Console.WriteLine(fractionresult.simpl(fractionresult));
                        break;
                    case "4":
                        fractionresult = fraction1.fractionDivision(fraction2);
                        Console.WriteLine(fractionresult.fractionToString());
                        Console.WriteLine(fractionresult.fication10);
                        Console.WriteLine(fractionresult.simpl(fractionresult));

                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Error");
                        break;
                }

            } while (true);
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
