using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryHomeWork4;

namespace ConsoleApp.HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Airplane airplane = new Airplane();
            string newModel = "Новая модель";
            double newWeight = 10000.0;
            int newCountOfSeats = 150;

            airplane.UpdateAirplane(ref newModel, ref newWeight, ref newCountOfSeats);
        }
    }
}
