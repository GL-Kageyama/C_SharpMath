using System;

// Tihs Code is need a mono

namespace math
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// Sin
			Console.WriteLine("{0}\n", Math.Sin(1));

			// Cos
			Console.WriteLine("{0}\n", Math.Cos(1));

			// Tan
			Console.WriteLine("{0}\n", Math.Tan(1));

			// 平方根
			Console.WriteLine("{0}\n", Math.Sqrt(2));

			// 最大値
			Console.WriteLine("{0}\n", Math.Max(2.2, 2.1));

			// 最小値
			Console.WriteLine("{0}\n", Math.Min(3.8, 8.3));

			// 円周率
			Console.WriteLine("{0}\n", Math.PI);

			// 自然対数の底
			Console.WriteLine("{0}\n", Math.E);

			// Log
			Console.WriteLine("{0}\n", Math.Log(10));

			// 微分
			double v = Derivative.Compute((x) => 2.0*x*x + 3.0*x - 2.0, -1.0);

			Console.WriteLine(v);

		}
	}

	public class Derivative
	{
		private const double _h = 1e-5;

		// 導関数の計算
		public static Func<double, double> Compute(Func<double, double> f)
		{
			return x => (f(x + _h) - f(x -_h)) / (2.0 * _h);
		}

		// 微分係数の計算
		public static double Compute(Func<double, double> f, double x)
		{
			return Compute(f)(x);
		}
	}
}


