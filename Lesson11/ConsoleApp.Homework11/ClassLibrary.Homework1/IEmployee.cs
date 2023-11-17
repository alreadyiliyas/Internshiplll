using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Homework1
{
    public interface IEmployee
    {
        string Name { get; set; }
        string Position { get; set; }
        decimal Salary { get; set; }
        string Gender { get; set; }
        DateTime HireDate { get; set; }   
    }
}
