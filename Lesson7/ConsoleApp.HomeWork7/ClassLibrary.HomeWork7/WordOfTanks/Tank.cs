using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.HomeWork7
{
    public class Tank
    {
        private static int nextId = 1;
        private int TankId;
        private string TankName;
        private int LevelAmmunition;
        private int LevelArmor;
        private int LevelManeuverability;
        private static Random random = new Random();
        public Tank(string name)
        {
            TankId = nextId++;
            TankName = name;
            LevelAmmunition =      random.Next(0, 101);
            LevelArmor =           random.Next(0, 101);
            LevelManeuverability = random.Next(0, 101);
        }

        public string GetTankParameters()
        {
            return "Tank Id: " + TankId +
                   ", TankName: " + TankName +
                   ", LevelAmmunition: " + LevelAmmunition +
                   ", LevelArmor: " + LevelArmor +
                   ", LevelManeuverability: " + LevelManeuverability;
        }
        public int GetTankId()
        {
            return TankId;
        }
        public string GetTankName()
        {
            return TankName;
        }
        public int GetLevelAmmunition()
        {
            return LevelAmmunition;
        }
        public int GetLevelArmor()
        {
            return LevelArmor;
        }
        public int GetLevelManeuverability()
        {
            return LevelManeuverability;
        }
    }
}
