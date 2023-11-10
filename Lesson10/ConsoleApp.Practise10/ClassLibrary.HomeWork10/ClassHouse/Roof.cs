using ClassLibrary.HomeWork10.InterfaceWorkerPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public class Roof : IPart
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }
        public Roof(int w, int h, int l) 
        {
            Width = w;
            Height = h; 
            Length = l;
        }
    }
}
