using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp.Practise12.Program;

namespace ConsoleApp.Practise12
{
	public class PropertyChanged : IPropertyChanged
	{
		private string _property;

		public string Property
		{
			get { return _property; }
			set
			{
				if (_property != value)
				{
					_property = value;
					OnPropertychanged(new PropertyeventArgs(nameof(Property)));
				}
			}
		}

		public event PropertyeventHandler Propertychanged;

		protected virtual void OnPropertychanged(PropertyeventArgs e)
		{
			Propertychanged?.Invoke(this, e);
		}

		public PropertyChanged(string property)
		{
			_property = property;
		}
	}
}
