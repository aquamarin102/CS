using System.IO;

namespace dz4
{
    static class myarray : Object
    {


        public static int Rand(int[] a)
        {
            Random r = new Random();
            int coincidences = 0;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(-10000, 10000);
                if (i >= 1 && a[i - 1] % 3 == 0 && a[i] % 3 != 0)
                {
                    coincidences++;
                }
            }


            return coincidences;
        }

        public static string readfile(string filename)
        {
            int[] a;
            string b = null;
            try
            {
                string s = System.IO.File.ReadAllText("..\\..\\data.txt");
                string[] ss = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                a = new int[ss.Length];
                for (int i = 0; i < ss.Length; i++)
                {
                    a[i] = int.Parse(ss[i]);
                    b = b + " " + ss[i] + " ";
                }

                return b;
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);

                return "Проверьте правильность имени файла!";
            }



        }

    }

    class myarray2
    {
        private int[] a;//правило инкапсуляции

        public myarray2(int n, int start, int step)
        {
            a = new int[n];
            a[0] = start;
            for (int i = 1; i < a.Length; i++)
                a[i] = a[i - 1] + step;
        }

        public int Sum
        {
            get
            {
                int sum = a[0];
                for (int i = 1; i < a.Length; i++)
                    sum = sum + a[i];
                return sum;
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (int element in a)
                s = s + element + " ";
            return s;
        }
        public string Inverse()
        {
            string end = "";
            int[] b;
            b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = -a[i];
                end = end + b[i] + ", ";
            }
            return end;
        }
        public string Multi()
        {
            int factor = 2;
            string end = "";

            for (int i = 0; i < a.Length; i++)
                a[i] = a[i] * factor;


            return end;
        }

    }
        class Account
        {
            string login;
            string password;

            public Account(string login, string password)
            {
                this.login = login;
                this.password = password;
            }

            public string Login { get { return login; } set { login = value; } }
            public string Password { get { return password; } set { password = value; } }
            public bool Check(string login, string password)
            {
                return login == Login && password == Password;
            }

        public bool Check(Account account)
        {
            return Login == account.Login && password == account.Password;
        }
        public bool Check(Account[] data)
        {
            foreach (Account account in data)
            { if (Check(account)) return true; }
            return false;
        }

        static public Account[] Load(string filename ="..\\..\\TextFile1.txt", int accountCount = 3)
        {
            Account[] accounts = new Account[accountCount];
            StreamReader sr = new StreamReader(filename);
            try
            {
                for (int i = 0; i < accountCount; i++)
                {
                    accounts[i] = new Account(sr.ReadLine(), sr.ReadLine());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sr?.Close();
            }
            return accounts;
            }
        }
    

    

        
        class Program
        {
            //1.Дан целочисленный  массив из 20 элементов.Элементы массива  могут принимать  целые значения  от –10 000 до 10 000 включительно.Заполнить случайными числами.Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых только одно число делится на 3.
            //В данной задаче под парой подразумевается два подряд идущих элемента массива.Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2. 
            //2.Реализуйте задачу 1 в виде статического класса StaticClass;
            //а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
            //б) *Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
            //в)**Добавьте обработку ситуации отсутствия файла на диске.

            static void Task1()
            {
                int[] a;
                a = new int[20];


                Console.WriteLine(myarray.Rand(a));
                Console.WriteLine(myarray.readfile("data.txt"));

            }
            //а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.Создать свойство Sum, которое возвращает сумму элементов массива, метод Inverse,
            //возвращающий новый массив с измененными знаками у всех элементов массива(старый массив, остается без изменений),  метод Multi, умножающий каждый элемент массива на определённое число, свойство MaxCount, возвращающее количество максимальных элементов.
            //б)** Создать библиотеку содержащую класс для работы с массивом.Продемонстрировать работу библиотеки
            //в) *** Подсчитать частоту вхождения каждого элемента в массив(коллекция Dictionary<int, int>)
            static void Task2()
            {
                int n, start, step;


                Console.WriteLine("Введите размер массива: ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите первое значение массива: ");
                start = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите шаг массива: ");
                step = int.Parse(Console.ReadLine());
                myarray2 a = new myarray2(n, start, step);
                Console.WriteLine(a);
                Console.WriteLine(a.Sum);
                Console.WriteLine(a.Inverse());
                Console.WriteLine(a.Multi());
            }
            static void Task3()//Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив. Создайте структуру Account, содержащую Login и Password.
        {
            int countAttempt = 0;
            bool authentic;
            Account[] accountsData = Account.Load();
            Account account = new Account(String.Empty, String.Empty);

            do
            {
                Console.WriteLine("Please enter login: ");
                account.Login = Console.ReadLine();

                Console.WriteLine("Please enter password: ");
                    account.Password = Console.ReadLine();

                authentic = account.Check(accountsData);
                if (authentic)
                {
                    Console.WriteLine("Authorization successfull");
                }
                else
                {
                    Console.WriteLine("No such user or wrong password");
                }
                countAttempt++;
            }while (countAttempt < 3 && !authentic);

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
    
