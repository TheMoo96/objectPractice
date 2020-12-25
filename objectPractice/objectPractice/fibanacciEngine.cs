using System;
using System.Collections.Generic;

namespace objectPractice
{
	public class FibonacciEngine
	{
		// Property.
		// This is a variable that can be set externally
		// and used by this script to do something.
		private int _Layer { get; set; }

		private List<int> _fibList = new List<int> { 1, 1 };

		// When this is called upon it find fibonacci number _Layer
		// then return that one.
		public int FibonacchiReturn()
        {
			var fibFind = new List<int>();
			while( fibFind.Count < _Layer)
            {
				int pre = _fibList[_fibList.Count - 1];
				int pre2 = _fibList[_fibList.Count - 2];
				_fibList.Add(pre + pre2);
            }
			int fibFound = _fibList[_fibList.Count - 1];
			return fibFound;
        }

		// Instance Constructor.
		// This is the heart of the class. Once called it will create an
		// instance of this using custom variables.
		public FibonacciEngine(int layer)
        {
			_Layer = layer;
        }
	}
}
