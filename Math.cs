using System;

namespace math
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Sine
            Console.WriteLine("{0}\n", Math.Sin(1));

            // Cosine
            Console.WriteLine("{0}\n", Math.Cos(1));

            // Tangent
            Console.WriteLine("{0}\n", Math.Tan(1));

            // Square root
            Console.WriteLine("{0}\n", Math.Sqrt(2));

            // Maximum value
            Console.WriteLine("{0}\n", Math.Max(2.2, 2.1));

            // Minimum value
            Console.WriteLine("{0}\n", Math.Min(3.8, 8.3));

            // π
            Console.WriteLine("{0}\n", Math.PI);

            // e (base of the natural logarithm)
            Console.WriteLine("{0}\n", Math.E);

            // Logarithm
            Console.WriteLine("{0}\n", Math.Log(10));

            // Differential
            double v = Derivative.Compute((x) => 2.0*x*x + 3.0*x - 2.0, -1.0);

            Console.WriteLine(v);

        }
    }

    public class Derivative
    {
        private const double _h = 1e-5;

        // Calculating derivatives
        public static Func<double, double> Compute(Func<double, double> f)
        {
            return x => (f(x + _h) - f(x -_h)) / (2.0 * _h);
        }

        // Calculating Differential Coefficients
        public static double Compute(Func<double, double> f, double x)
        {
            return Compute(f)(x);
        }
    }
}


