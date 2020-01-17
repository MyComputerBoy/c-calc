using System;

namespace TestApp
{
    class Program
    {
        private const double V = 0.0;

        static void Main(string[] args)
        {
            double a = V;
            double c = V;
            Console.Write("A = ");
            a = Convert.ToInt32( Console.ReadLine() );
            Console.Write("B = ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Function = ");
            string v = Console.ReadLine();
            string f = v;
            switch (f)
            {
                case "+":
                    c = a + b;
                    break;
                case "-":
                    c = a - b;
                    break;
                case "*":
                    c = a * b;
                    break;
                case "/":
                    c = a / b;
                    break;
            }
            Console.WriteLine( $"C = {c}");
            Console.ReadKey();
        }
    }
}
