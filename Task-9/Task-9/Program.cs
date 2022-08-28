using System;
using static System.Math;

namespace Task_9
{
    class Program 
    { 
        public delegate void QuadraticDelegate(int a, int b, int c);
        public delegate void FactorialDelegate(int a);
        public delegate void IsPrimeDelegate(int a);
        
        public static void Quadratic(int a, int b, int c)
        {
            double root1, root2;
            root1 = (-b + Sqrt((b * b) - (4 * a * c))) / (2 * a);
            root2 = (-b + Sqrt((b * b) - (4 * a * c))) / (2 * a);
            Console.WriteLine("1st root is : " + root1);
            Console.WriteLine("2nd root is : " + root2);

        }

        public static void Factorial(int a)
        {
            int fact = 1;
            for (int i = 1; i <= a; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial is : " + fact);
        }

        public static void IsPrime(int a)
        {
            bool ans = true;
            for (int i = 2; i < (a / 2) + 1; i++)
            {
                if (a % i == 0)
                {
                    ans = false;
                    break;
                }
            }
                if (ans == true)
                {
                    Console.WriteLine("Number is prime!");
                }
                else
                {
                    Console.WriteLine("Number is not prime!");
                }
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Iman Fazal");
            Console.WriteLine("Roll No : BSEF19M533");

            Console.WriteLine("Using Delegates: ");
            QuadraticDelegate qd = new QuadraticDelegate(Quadratic);
            FactorialDelegate fd = new FactorialDelegate(Factorial);
            IsPrimeDelegate pd = new IsPrimeDelegate(IsPrime);

            Console.WriteLine("Note : 1st number will be used to calculate factorial and to check if it is a prime number!");

            int num1 = 0, num2 = 0, num3 = 0;

            try
            {
                Console.Write("Enter 1st no. : ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter 2nd no. : ");
                num2 = int.Parse(Console.ReadLine());
                Console.Write("Enter 3rd no. : ");
                num3 = int.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            qd.Invoke(num1, num2, num3);
            fd.Invoke(num1);
            pd.Invoke(num1);

            Console.ReadKey(); 
        }
    }
}
