using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.HomeWork10Add
{
    public interface IStorable
    {
        void SaveState(string path);
        void LoadState(string path);
    }
}
