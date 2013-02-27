using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
	public class MultiplicativeCongruentialMethod : IRandomMethod
	{
		private int _current;

		private int _module;

		private int _multiplier;

		public MultiplicativeCongruentialMethod(int seed, int multiplier, int module)
		{
			_current = seed;
			_module = module;
			_multiplier = multiplier;
		}

		public int Next()
		{
			return _current = (int)(((uint)(_multiplier*_current))%_module);
		}

		public int Current
		{
			get { return _current; }
		}
	}
}
