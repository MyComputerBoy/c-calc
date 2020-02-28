using System;

namespace TestApp
{
    class Program
    {
        private const double V = 0.0;
        private const string V1 = "c";
        private const string V2 = "q";
        private const string V3 = "setMode";
        private const string V4 = "bin";
        private const string V5 = "dec";
        private const string V6 = "0";
        static void Main(string[] args)
        {
            bool wl = true;
            double c = V;
            string mode = "decimal";
            Console.WriteLine("Set a to q for quit.");
            Console.WriteLine("Set a or b to c for previus result.");
            Console.WriteLine("Set a to setMode for decimal/binary mode");
            while (wl)
            {
                Console.Write("A = ");
                string a = Console.ReadLine();
                if (a == V1)
                {
                    a = Convert.ToString(c);
                }
                else if (a == V2)
                {
                    break;
                }
                if (a == V3)
                {
                    Console.Write("Mode: ");
                    string s = Console.ReadLine();
                    mode = s;
                }
                else
                {
                    Console.Write("B = ");
                    string b = Console.ReadLine();
                    if (b == V1)
                    {
                        b = Convert.ToString(c);
                    }
                    Console.Write("Function = ");
                    string f = Console.ReadLine();
                    double ta = V;
                    double tb = V;
                    int i = 0;
                    int t;

                    if (mode == V4)
                    {
                        bool does = true;
                        while (does)
                        {
                            if (a == V6)
                            {
                                break;
                            }
                            t = Convert.ToInt32(a) % 10;
                            a = Convert.ToString(Math.Floor(Convert.ToDouble(a) / 10));
                            ta += t * Math.Pow(2, i);
                            i += 1;
                        }
                        does = true;
                        i = 0;
                        while (does)
                        {
                            if (b == V6)
                            {
                                break;
                            }
                            t = Convert.ToInt32(b) % 10;
                            b = Convert.ToString(Math.Floor(Convert.ToDouble(b) / 10));
                            tb += t * Math.Pow(2, i);
                            i += 1;
                        }
                        a = Convert.ToString(ta);
                        b = Convert.ToString(tb);
                    }
                    ta = Convert.ToDouble(a);
                    tb = Convert.ToDouble(b);
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
                            c = ta - (Math.Floor(ta / tb) * tb);
                            break;
                        case "%":
                            c = ta * (tb / 100);
                            break;
                    }
                    int tc = 0;
                    i = 0;
                    if (mode == V4)
                    {
                        bool does = true;
                        while (does)
                        {
                            if (c==V)
                            {
                                break;
                            }
                            t = Convert.ToInt32(c) % 2;
                            c = Math.Floor(c / 2);
                            tc += Convert.ToInt32(Convert.ToInt32(t) * Math.Pow(10, i));
                            i += 1;
                        }
                        c = tc;
                    }
                    Console.WriteLine($"C = {c}");
                }
            }
        }
    }
}
