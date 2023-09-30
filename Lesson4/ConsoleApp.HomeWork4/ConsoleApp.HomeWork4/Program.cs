using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.HomeWork4;
namespace ConsoleApp.HomeWork4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Airplane> airplanes = new List<Airplane>();
            int StopBtn = 1;

            while (StopBtn != 0)
            {
                Airplane airplane = new Airplane(); // Создаем новый экземпляр самолета

                Console.Write("Введите название самолета: ");
                string model = Console.ReadLine();
                airplane.SetModel(model);

                Console.WriteLine("Введите тип самолета: \n 1) Грузовой, напишите 1; \n 2) Пассажирский, напишите 2;");
                int typeAirplane = Convert.ToInt32(Console.ReadLine());
                airplane.SetTypeAirplane(typeAirplane);

                Console.Write("Введите вес самолета: ");
                double Weight = Convert.ToDouble(Console.ReadLine());
                airplane.SetWeight(Weight);

                Console.Write("Введите емкость бака самолета: ");
                double OilVolume = Convert.ToDouble(Console.ReadLine());
                airplane.SetOilVolume(OilVolume);

                Console.Write("Введите максимальную скорость самолета: ");
                double MaxAirplaneSpeed = Convert.ToDouble(Console.ReadLine());
                airplane.SetMaxAirplaneSpeed(MaxAirplaneSpeed);

                Console.Write("Введите общее количество мест в самолете: ");
                int CountOfSeats = Convert.ToInt32(Console.ReadLine());
                airplane.SetCountOfSeats(CountOfSeats);

                Airplane.AddAirplane(airplanes, model, typeAirplane, Weight, OilVolume, MaxAirplaneSpeed, CountOfSeats);


                Console.WriteLine("Остановить ввод: 0, Продолжить: 1"); // Поменяли порядок значений
                StopBtn = Convert.ToInt32(Console.ReadLine());
            }


            foreach (var airplane in airplanes)
            {
                airplane.PrintAirplaneInfo();
            }

            Console.WriteLine("Обновить данные самолета? \n Да - 1, Нет - 2");
            int chooseUpdate = Convert.ToInt32(Console.ReadLine());
            if (chooseUpdate == 1)
            {
                Console.WriteLine("Введите ID самолета для изменения данных: ");
                int airplaneId = Convert.ToInt32(Console.ReadLine());

                Airplane airplaneToUpdate = Airplane.GetAirplaneById(airplanes, airplaneId);
                if (airplaneToUpdate != null)
                {
                    Console.Write("Введите новое название самолета: ");
                    string newModel = Console.ReadLine();

                    Console.Write("Введите новый вес самолета: ");
                    double newWeight = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Введите новое количество мест в самолете: ");
                    int newCountOfSeats = Convert.ToInt32(Console.ReadLine());

                    Airplane.UpdateAirplaneById(airplanes, airplaneId, newModel, newWeight, newCountOfSeats);

                    Console.WriteLine("Обновленный список: ");
                    foreach (var airplane in airplanes)
                    {
                        airplane.PrintAirplaneInfo();
                    }
                }
                else
                {
                    Console.WriteLine("Самолет с указанным ID не найден.");
                }
            }
        }
    }
}
