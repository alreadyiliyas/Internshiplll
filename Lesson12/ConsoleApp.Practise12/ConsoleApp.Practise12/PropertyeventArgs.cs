using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practise12
{
	public class PropertyeventArgs : EventArgs
	{
		public string PropertyName { get; }
		public PropertyeventArgs(string propertyName)
		{
			PropertyName = propertyName;
		}
	}
}
