using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
	public interface ITestingMethod
	{
		double[] TestingUniformity(IRandomMethod method, int numberOfSection, int countNumbers, out double M, out double D);
		double TestingtestingIndependence(IRandomMethod method, int countNumbers);
	}
}
