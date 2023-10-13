using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.HomeWork5
{
    public class Practise5_DataJson
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class Car
    {
        public void StartEngine()
        {
            Console.WriteLine("Двигатель машины запущен");
        }
    }

    public class CheckEngineCar : Car
    {
        public bool CheckEngine { get; set; }

        public CheckEngineCar(bool checkEngine)
        {
            CheckEngine = checkEngine;
        }

        public void Drive()
        {
            if (CheckEngine)
            {
                Console.WriteLine("Машина движется");
            }
            else
            {
                Console.WriteLine("Машина не может двигаться из-за неисправности двигателя.");
                throw new EngineException("Ошибка: Двигатель неисправен");
            }
        }
    }
    public class EngineException : Exception
    {
        public EngineException(string message) : base(message)
        {
        }
    }
}
