using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.HomeWork4
{
    public class Airplane
    {
        private static int nextID = 1; 
        private int ID { get; set; }
        private string Model { get; set; }
        //Тип самолета грузой/пассажирский
        private int TypeAirplane { get; set; }
        private double Weight { get; set; }
        private double OilVolume { get; set; }
        private double MaxAirplaneSpeed { get; set; }
        private int CountOfSeats { get; set; }
        public string GetModel()
        {
            return Model;
        }

        public int GetTypeAirplane()
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

        public void SetTypeAirplane(int type)
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
        public Airplane()
        {
            ID = nextID;
            nextID++;
        }
        static Airplane() { }
        public Airplane(string model, int type)
        {
            ID = nextID;
            nextID++;

            SetModel(model);
            SetTypeAirplane(type);
        }
        public Airplane(string model, int type, double weight, double oilVolume, double maxSpeed, int seats)
        {
            ID = nextID;
            nextID++;

            SetModel(model);
            SetTypeAirplane(type);
            SetWeight(weight);
            SetOilVolume(oilVolume);
            SetMaxAirplaneSpeed(maxSpeed);
            SetCountOfSeats(seats);
        }
        public static int TotalAirplanesCount { get; private set; } = 0;
        public static double AverageAirplaneWeight { get; private set; } = 0;
        public static void AddAirplane(List<Airplane> airplanes, string model, int type, double weight, double oilVolume, double maxSpeed, int seats)
        {
            Airplane airplane = new Airplane();
            airplane.SetModel(model);
            airplane.SetTypeAirplane(type);
            airplane.SetWeight(weight);
            airplane.SetOilVolume(oilVolume);
            airplane.SetMaxAirplaneSpeed(maxSpeed);
            airplane.SetCountOfSeats(seats);
            airplanes.Add(airplane);
            AverageAirplaneWeight = (airplanes.Sum(a => a.GetWeight())) / airplanes.Count;
        }

        public static Airplane GetAirplaneById(List<Airplane> airplanes, int id)
        {
            return airplanes.FirstOrDefault(plane => plane.ID == id);
        }
        public void PrintAirplaneInfo()
        {
            Console.WriteLine("ID самолета: " + ID);
            Console.WriteLine("Модель самолета: " + GetModel());
            Console.WriteLine("Тип самолета: " + GetTypeAirplane());
            Console.WriteLine("Вес самолета: " + GetWeight());
            Console.WriteLine("Объем топлива: " + GetOilVolume());
            Console.WriteLine("Максимальная скорость: " + GetMaxAirplaneSpeed());
            Console.WriteLine("Количество мест: " + GetCountOfSeats());
            Console.WriteLine("Средняя масса самолетов: " + AverageAirplaneWeight);
        }
        public static void UpdateAirplaneById(List<Airplane> airplanes, int id, string model, double weight, int countOfSeats)
        {
            Airplane airplane = GetAirplaneById(airplanes, id);
            if (airplane != null)
            {
                double previousWeight = airplane.GetWeight(); // Запоминаем текущий вес самолета
                airplane.SetModel(model);
                airplane.SetWeight(weight);
                airplane.SetCountOfSeats(countOfSeats);

                // Обновляем среднюю массу самолетов
                AverageAirplaneWeight = ((airplanes.Sum(a => a.GetWeight())) / airplanes.Count);

                airplane.PrintAirplaneInfo();
            }
            else
            {
                Console.WriteLine("Самолет с указанным ID не найден.");
            }
        }
        
        
    }
}
