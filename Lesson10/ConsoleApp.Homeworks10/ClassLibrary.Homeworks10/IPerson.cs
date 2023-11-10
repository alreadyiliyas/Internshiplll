using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks10
{
    public interface IPerson
    {
        int Id { get; set; }
        string FName { get; set; }
        string SName { get; set; }
        DateTime DateOfBirthday { get; set; }
        void PrintPersonInfo();
    }
}
