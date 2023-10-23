using System;
using System.Collections.Generic;
using ClassLibrary.HomeWork7;

namespace ConsoleApp.HomeWork7
{
    internal class TanksWars
    {
        public static bool operator ^(Tank t34, Tank panther)
        {
            int t34Exceeds = 0;
            int pantherExceeds = 0;

            if (t34.GetLevelAmmunition() > panther.GetLevelAmmunition())
            {
                t34Exceeds++;
            }
            else if (panther.GetLevelAmmunition() > t34.GetLevelAmmunition())
            {
                pantherExceeds++;
            }
            if (t34.GetLevelArmor() > panther.GetLevelArmor())
            {
                t34Exceeds++;
            }
            else if (panther.GetLevelArmor() > t34.GetLevelArmor())
            {
                pantherExceeds++;
            }
            if (t34.GetLevelManeuverability() > panther.GetLevelManeuverability())
            {
                t34Exceeds++;
            }
            else if (panther.GetLevelManeuverability() > t34.GetLevelManeuverability())
            {
                pantherExceeds++;
            }

            if (t34Exceeds + pantherExceeds == 0)
            {
                throw new InvalidOperationException("Невозможно провести бой. Оба танка имеют одинаковые параметры.");
            }

            return t34Exceeds >= 2 || pantherExceeds >= 2;
        }
    }
}
