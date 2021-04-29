using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.Lesson14
{
    class Company
    {
        private Human boss;
        private readonly string name;
        private List<Client> clientList = new List<Client>();
        private List<Worker> workerList = new List<Worker>();
        public Dog OfficePet { get; set; }
        //public Worker HireWorker { get; set ; }
        //public Worker FireWorker { get; set; }

        private Worker hireWorker;
        private Worker fireWorker;

        public int ClientId { set; get; }

        public Company(Human human, string name) 
        {
            boss = human;
            this.name = name;
        }

        public void HireWorker(Worker w)
        {
            hireWorker = w;
        }

        public void FireWorker(Worker f)
        {
            fireWorker = f;
        }


        public void AddClient(Client client)
        {
            clientList.Add(client);
        }

        public void AddWorker(Worker worker)
        {
            workerList.Add(worker);
        }

        public void PrintAllClients()
        {
            foreach (var cl in clientList)
            {
                Console.WriteLine("Company.Client = " + cl.GetName() + "; Client ID = " + cl.ClientId);
            }
        }

        public void PrintAllWorker()
        {
            foreach (var w in workerList)
            {
                Console.WriteLine("Company.Worker = " + w.GetName());
            }
        }



        public void PrintInfo()
        {
            Console.WriteLine("Company class: " + this.name);
            Console.WriteLine("Company boss name: " + this.boss.GetName() + ", metų " + this.boss.GetLiveSpan());
            Console.WriteLine($"Company.OfficePet: {this.OfficePet.GetName()}");
            Console.WriteLine("Company fire worker: " + this.fireWorker.GetName() + "; alga - " + this.fireWorker.GetSalary());
            Console.WriteLine("Company hire worker: " + this.hireWorker.GetName() + "; alga - " + this.hireWorker.GetSalary());
            Console.WriteLine("Clients count: " + clientList[0].ClientsCount());
            PrintAllWorker();
            PrintAllClients();
        }


    }
}
