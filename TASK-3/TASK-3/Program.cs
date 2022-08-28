using System;

namespace TASK_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IMAN FAZAL");
            Console.WriteLine("ROLL NO. : BSEF19M533");
            Console.WriteLine("Sum of 5 and 4 is " + Add.add(5,4));
            Console.WriteLine("Product of 5 and 4 is "+ Multiply.multiply(5,4));
            Console.WriteLine("Difference of 5 and 4 is "+ Subtract.subtract(4,5));
            Console.WriteLine("Remainder of 5 and 4 is "+ Mode.mode(4,5));
            Console.WriteLine("Division of 5 and 4 is "+ Divide.divide(4, 5));
            Console.ReadKey();
        }
    }
}
