using System;

namespace TestApp
{
    class Program
    {
        private const double V = 0.0;
        private const string V1 = "c";
        private const string V2 = "q";

        static void Main(string[] args)
        {
            bool wl = true;
            double c = V;
            Console.WriteLine("Set a to q for quit.");
            Console.WriteLine("Set a or b to c for previus result.");
            while (wl)
            {
                Console.Write("A = ");
                string a = Console.ReadLine();
                if (a == V1) 
                {
                    a = Convert.ToString(c);
                } else if ( a == V2 )
                {
                    break;
                }
                Console.Write("B = ");
                string b = Console.ReadLine();
                if (b == V1)
                {
                    b = Convert.ToString(c);
                }
                Console.Write("Function = ");
                string f = Console.ReadLine();
                double ta = Convert.ToDouble(a);
                double tb = Convert.ToDouble(b);
                switch (f)
                {
                    case "+":
                        c = ta + tb;
                        break;
                    case "-":
                        c = ta - tb;
                        break;
                    case "*":
                        c = ta * tb;
                        break;
                    case "/":
                        c = ta / tb;
                        break;
                    case "mod":
                        c = ta-(Math.Floor(ta/tb)*tb);
                        break;
                    case "%":
                        c = ta * (tb / 100);
                        break;
                }
                Console.WriteLine($"C = {c}");
            }
        }
    }
}
