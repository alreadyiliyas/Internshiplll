using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Practise5
{
    public class Laptop
    {
        protected int ID { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }
        public string LaptopType { get; set; }
        public DateTime LaptopRelease { get; set; }
        public Laptop(string name, string model)
        {
            Name = name;
            Model = model;
        }
        public void PrintMainInfo()
        {
            Console.WriteLine("Название: " + Name);
            Console.WriteLine("Модель: " + Model);
            Console.WriteLine("Вес: " + Weight);
            Console.WriteLine("Тип ноутбука" + LaptopType);
            Console.WriteLine("Дата выхода ноутбука: " + LaptopRelease);
        }
        public double CalculatePowerCoefficient()
        {
            return 0.0; // Реализуйте вычисление коэффициента мощности здесь
        }
    }

    public class characteristics : Laptop
    { 
        public string ProcessorName { get; set; }
        public string ProcessorVersion { get; set; }
        public int ProcessorCoreCount { get; set; }
        public int ProcessorFrequency { get; set; }
        public int CountRam { get; set; }   
        public int RamMemory { get; set; }
        public string NameVideoCard { get; set; }
        public string VersionVideoCard { get; set; }

        public characteristics(string Name, string Model, string processorName, string processorVersion, int processorCoreCount, int processorFrequency, int countRam, int ramMemory, string nameVideoCard, string versionVideoCard)
            : base(Name, Model)
        {
            ProcessorName = processorName;
            ProcessorVersion = processorVersion;
            ProcessorCoreCount = processorCoreCount;
            ProcessorFrequency = processorFrequency;
            CountRam = countRam;
            RamMemory = ramMemory;
            NameVideoCard = nameVideoCard;
            VersionVideoCard = versionVideoCard;
        }
        public double CalculatePowerCoefficient()
        {
            try
            {
                double coefficient = (ProcessorCoreCount * ProcessorFrequency * CountRam * RamMemory) / 1000000.0;
                return coefficient;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль.");
                throw; // Поднимаем исключение выше
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
                throw; // Поднимаем исключение выше
            }
        }

        public void PrintCharacteristicsInfo()
        {
            Laptop mainInfo = new Laptop(Name, Model);
            mainInfo.PrintMainInfo();
            Console.WriteLine("Имя процессора: " + ProcessorName);
            Console.WriteLine("Версия процессора: " + ProcessorVersion);
            Console.WriteLine("Количество ядер процессора: " + ProcessorCoreCount);
            Console.WriteLine("Частота процессора: " + ProcessorFrequency + " ГГц");
            Console.WriteLine("Количество оперативной памяти: " + CountRam + " ГБ");
            Console.WriteLine("Объем оперативной памяти: " + RamMemory + " ГБ");
            Console.WriteLine("Имя видеокарты: " + NameVideoCard);
            Console.WriteLine("Версия видеокарты: " + VersionVideoCard);

            double powerCoefficient = CalculatePowerCoefficient();
            Console.WriteLine("Коэффициент мощности: " + powerCoefficient);
        }
    }
}