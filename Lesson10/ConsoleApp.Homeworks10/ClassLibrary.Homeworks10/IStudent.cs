using Homeworks10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks10
{
    public interface IStudent
    {
        List<Subject> Subjects { get; set; }
        int StudCourse { get; set; }

        void PrintPersonInfo();
    }
}
