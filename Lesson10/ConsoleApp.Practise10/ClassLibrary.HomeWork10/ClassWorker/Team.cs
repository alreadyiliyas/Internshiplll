using ClassLibrary.HomeWork10.InterfaceWorkerPart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{
    public class Team
    {
        public TeamLeader TeamLeader { get; set; }
        public List<Worker> Workers { get; set; }
        public Team() 
        {
            TeamLeader = new TeamLeader("", 0);
            Workers = new List<Worker>();
        }
        public void AddWorker(Worker worker)
        {
            Workers.Add(worker);
        }
        public void AddTeamLeader(string name, int age)
        {
            TeamLeader = new TeamLeader(name, age);
        }
    }
}
