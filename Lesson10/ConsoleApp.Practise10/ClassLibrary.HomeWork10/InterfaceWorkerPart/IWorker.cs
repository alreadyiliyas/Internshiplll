using HomeWork10;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.HomeWork10.InterfaceWorkerPart
{
    public interface IWorker
    {
        string Name { get; set; }
        int Age { get; set; }
        void DoWork(BuildingHouse buildingHouse, int workAmount);
    }
}
