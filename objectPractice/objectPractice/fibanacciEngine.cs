using System;

namespace objectPractice
{
	public class fibanacciEngine
	{
		// Property.
		// This is a variable that can be set externally
		// and used by this script to do something.
		public int Base { get; set; }

		// Method.
		// This is a functionality that can be called externally
		// and that will then do something.
		// In this case it will return the base property with an int
		// specified in the ...() on the external.

		public int AddWith(int num)
        {
			return num + Base;
        }

		// Instance Constructor.
		// This is the heart of the class. Once called it will create an
		// instance of this using custom variables.
		public fibanacciEngine()
        {
			Base = 0;
        }
	}
}
