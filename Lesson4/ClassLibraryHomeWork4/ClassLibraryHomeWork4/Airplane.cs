using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryHomeWork4
{
    public class Airplane
    {
        private string Model { get; set; }
        //Тип самолета грузой/пассажирский
        private string TypeAirplane { get; set; }
        private double Weight { get; set; }
        private double OilVolume { get; set; }
        private double MaxAirplaneSpeed { get;set; }
        private int CountOfSeats { get; set; }
        public string GetModel()
        {
            return Model;
        }

        public string GetTypeAirplane()
        {
            return TypeAirplane;
        }

        public double GetWeight()
        {
            return Weight;
        }

        public double GetOilVolume()
        {
            return OilVolume;
        }
        public double GetMaxAirplaneSpeed()
        {
            return MaxAirplaneSpeed;
        }
       
        public int GetCountOfSeats()
        {
            return CountOfSeats;
        }
        public void SetModel(string model)
        {
            Model = model;
        }

        public void SetTypeAirplane(string type)
        {
            TypeAirplane = type;
        }

        public void SetWeight(double weight)
        {
            Weight = weight;
        }

        public void SetOilVolume(double oilVolume)
        {
            OilVolume = oilVolume;
        }

        public void SetMaxAirplaneSpeed(double maxSpeed)
        {
            MaxAirplaneSpeed = maxSpeed;
        }

        public void SetCountOfSeats(int seats)
        {
            CountOfSeats = seats;
        }
        public void UpdateAirplane(ref string model, ref double weight, ref int countOfSeats)
        {
            Model = model;
            Weight = weight;
            CountOfSeats = countOfSeats;
        }
    }
}
