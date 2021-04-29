using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.Lesson14
{
    sealed class Client : Human
    {
        private static int clientCount = 0;
        public int ClientId { set; get; }

        public Client(int lspan, string name) : base(lspan, name)
        {
            clientCount++;
            ClientId = clientCount;
        }

        public int ClientsCount()
        {
            return clientCount;
        }


        //public void SetClientClount(int c)
        //{
        //    clientCount++;
        //}
    }
}
