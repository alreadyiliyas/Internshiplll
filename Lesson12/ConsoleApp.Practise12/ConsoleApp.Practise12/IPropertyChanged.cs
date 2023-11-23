using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Practise12
{
	public delegate void PropertyeventHandler(object sender, PropertyeventArgs e);

	public interface IPropertyChanged
	{
		event PropertyeventHandler Propertychanged;
	}
}
