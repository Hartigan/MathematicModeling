using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
	public interface IRandomMethod
	{
		int Next();
		int Current { get; }
	}
}
