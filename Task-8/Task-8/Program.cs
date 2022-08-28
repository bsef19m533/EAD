using System;

namespace Task_8
{
    public delegate void Operations(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iman Fazal");
            Console.WriteLine("BSEF19M533");
            Console.WriteLine("Enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Operations myDelegate = new Operations(sum);
            myDelegate.Invoke(a, b);
            myDelegate = mul;
            myDelegate.Invoke(a, b);
            myDelegate = div;
            myDelegate.Invoke(a, b);
            myDelegate = mod;
            myDelegate.Invoke(a, b);
            
        }

        public static void sum(int a, int b)
        {
            Console.WriteLine("Addition" + (a + b));
        }
        public static void sub(int a, int b)
        {
            Console.WriteLine("Subtraction " + (a - b));
        }
        public static void mul(int a, int b)
        {
            Console.WriteLine("Multiplication" + (a * b));
        }
        public static void div(int a, int b)
        {
            Console.WriteLine("Division " + ((float)a / b));
        }
        public static void mod(int a, int b)
        {
            Console.WriteLine("Remainder " + (a % b));
        }
    }
}
