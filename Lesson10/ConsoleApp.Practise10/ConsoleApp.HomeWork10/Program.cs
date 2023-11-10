using HomeWork10;
using ClassLibrary.HomeWork10.InterfaceWorkerPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.HomeWork10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team();
            TeamLeader teamLeader = new TeamLeader("Райан Гослинг", 38);
            IWorker worker1 = new Worker("Iliyas", 20); 
            IWorker worker2 = new Worker("Islam", 21);
            IWorker worker3 = new Worker("Olzhas", 21);
            IWorker worker4 = new Worker("Elkhan", 21);

            team.AddTeamLeader(teamLeader.Name, teamLeader.Age);

            team.AddWorker((Worker)worker1);    
            team.AddWorker((Worker)worker2);
            team.AddWorker((Worker)worker3);
            team.AddWorker((Worker)worker4);

            Console.WriteLine("Лидер команды: Имя: {0}, Возраст: {1}", teamLeader.Name, teamLeader.Age);

            int counter = 0;
            foreach (var worker in team.Workers)
            {
                counter++;
                Console.WriteLine("Рабочий {0}, Имя: {1}, Возраст: {2}", counter, worker.Name, worker.Age);
            }

            House house = new House();
            house.PrintInfoHouse();

            BuildingHouse buildingHouse = new BuildingHouse();

            worker1.DoWork(buildingHouse, 25);
            worker2.DoWork(buildingHouse, 25);
            worker3.DoWork(buildingHouse, 25);
            worker4.DoWork(buildingHouse, 25);


        }
    }
}
