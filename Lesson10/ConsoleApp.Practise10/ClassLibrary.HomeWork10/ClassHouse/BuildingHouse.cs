using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public class BuildingHouse : House
    {
        public int PercentBuildingHouse { get; set; }
        public BuildingHouse() : base()
        {
            Random rnd = new Random();
            PercentBuildingHouse = rnd.Next(0, 70);
        }

        public void Build(int percentToBuild) 
        {
            if (percentToBuild < 0 || percentToBuild > 100)
            {
                throw new ArgumentException("Ошибка, процент застройки неправильный");
            }
            else if (PercentBuildingHouse + percentToBuild <= 100)
            {
                PercentBuildingHouse += percentToBuild;
            }
            else
            {
                PercentBuildingHouse = 100;
            }
            Console.WriteLine($"Строительство дома: {PercentBuildingHouse}% завершено.");
            
        }
    }
}
