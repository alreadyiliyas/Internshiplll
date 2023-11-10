using ClassLibrary.HomeWork10.InterfaceWorkerPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public class Worker : IWorker
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int WorkDone { get; private set; }
        public Worker(string name, int age) 
        {
            Name = name;
            Age = age;
        }
        public void DoWork(BuildingHouse buildingHouse, int workAmount)
        {
            if (buildingHouse.PercentBuildingHouse < 100)
            {
                WorkDone += workAmount;
                buildingHouse.Build(workAmount);
            }
            else
            {
                Console.WriteLine("Дом уже построен, рабочий не может больше работать.");
            }
        }
    }
}
