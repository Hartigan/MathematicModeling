using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
	public class EasyTesting : ITestingMethod
	{
		public double[] TestingUniformity(IRandomMethod method, int numberOfSection, int countNumbers, out double M, out double D)
		{
			double[] result = new double[numberOfSection];
			double[] numbers = new double[countNumbers];

			for (int i = 0; i < countNumbers; i++)
			{
				numbers[i] = method.Next();
			}

			double max = numbers.Max();

			for (int i = 0; i < countNumbers; i++)
			{
				result[(int)(numbers[i]*numberOfSection/max)%numberOfSection]++;
			}

			numbers = numbers.Select(x => x/max).ToArray();

			double m = CalcM(numbers);
			double d = CalcD(numbers);

			M = m;
			D = d;
			return result;
		}

		private static double CalcD(double[] numbers)
		{
			double m = CalcM(numbers);
			return numbers.Select(x => x*x - m*m).Sum()/numbers.Length;
		}

		private static double CalcM(double[] numbers)
		{
			return numbers.Sum()/(double) numbers.Length;
		}

		public double TestingtestingIndependence(IRandomMethod method, int countNumbers)
		{
			double result;

			double[] numbers1 = new double[countNumbers];

			double[] numbers2 = new double[countNumbers];

			numbers1 = numbers1.Select(x => (double)method.Next()).ToArray();

			double max = numbers1.Max();

			numbers2 = numbers2.Select(x => (double)method.Next()).ToArray();

			max = Math.Max(max, numbers2.Max());

			numbers1 = numbers1.Select(x => x/max).ToArray();

			numbers2 = numbers2.Select(x => x/max).ToArray();

			double[] multiply = new double[countNumbers];

			for (int i = 0; i < countNumbers; i++)
			{
				multiply[i] = numbers1[i]*numbers2[i];
			}

			result = (CalcM(multiply) - CalcM(numbers1)*CalcM(numbers2))/Math.Sqrt(CalcD(numbers1)*CalcD(numbers2));

			return result;
		}
	}
}
