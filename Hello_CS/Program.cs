using System;

namespace Hello_CS
{
    internal class Program
    {
        public static void Pause(string message= "klass")
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }
        static int Sum(int a, int b)
        { 
            int s = a + b;
            return s;
        }
        static double Sum(double a, double b)
        {
            double s = a + b;
            return s;
        }
        static void Main(string[] args)
        {
           
            Console.WriteLine((Sum(1.2, 2.6)));
            Pause("Press ane key");
            
        
        }
    }
}