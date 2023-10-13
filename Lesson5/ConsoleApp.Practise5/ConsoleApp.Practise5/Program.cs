using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Practise5;

namespace ConsoleApp.Practise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            characteristics laptop = new characteristics("Acer", "Nitro 7", "Intel", "i7", 4, 8, 16, 512, "NVIDIA", "GTX 1660");
            laptop.PrintCharacteristicsInfo();
        }
    }
}
