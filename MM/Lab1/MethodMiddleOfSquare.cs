using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab1
{
	public class MethodMiddleOfSquare : IRandomMethod
	{
		private int _current;
		
		public MethodMiddleOfSquare(int seed)
		{
			_current = seed % 10000;
		}

		public int Next()
		{
			return _current = (_current*_current)/100%10000;
		}

		public int Current
		{
			get { return _current; }
		}
	}
}
