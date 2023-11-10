using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public class House
    {
        Basement Basement { get; set; }
        Roof Roof { get; set; }
        List<Walls> Walls { get; set; }
        List<Door> Doors { get; set; }
        List<Window> Windows { get; set; }
        public House()
        {
            Basement = new Basement(400, 200, 500);
            Roof = new Roof(400, 200, 500);
            Walls = new List<Walls>()
            {
                new Walls(100, 100, 125),
                new Walls(100, 100, 125),
                new Walls(100, 100, 125),
            };
            Doors = new List<Door>()
            {
                new Door(10, 20, 20)
            };
            Windows = new List<Window>()
            {
                new Window(20, 20, 20),
                new Window(20, 20, 20),
                new Window(20, 20, 20),
                new Window(20, 20, 20),
            };
        }

        public void PrintInfoHouse() 
        {
            Console.WriteLine("Информация о доме: ");
            Console.WriteLine("Фундатент: длина: {0}, ширина {1}, высота {2}", Basement.Length, Basement.Width, Basement.Height);
            Console.WriteLine("Крыша: длина: {0}, ширина {1}, высота {2}", Roof.Length, Roof.Width, Roof.Height);
            Console.WriteLine("Кол-во стен: {0}", Walls.Count);
            foreach (var wall in Walls)
            {
                Console.WriteLine("Стена: длина: {0}, ширина {1}, высота {2}", wall.Length,wall.Width, wall.Height);
            }
            Console.WriteLine("Кол-во дверей: {0}", Doors.Count);
            foreach (var door in Doors)
            {
                Console.WriteLine("Двери: длина: {0}, ширина {1}, высота {2}", door.Length, door.Width, door.Height);
            }
            Console.WriteLine("Кол-во окон: {0}", Windows.Count);
            foreach (var window in Windows)
            {
                Console.WriteLine("Стена: длина: {0}, ширина {1}, высота {2}", window.Length, window.Width, window.Height);
            }
        }
    }
}
