using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.Lesson14
{
    sealed class Worker : Human
    {
        private int salary;
        

        public Worker(int lspan, string name, int salary) : base(lspan, name)
        {
            this.salary = salary;
        }
            
        public int GetSalary()
        {
            return salary;
        }

        public void SetSalary(int salary)
        {
            this.salary = salary;
        }

        public string GetAboutWorker()
        {
            return base.GetName();
        }

    }
}
