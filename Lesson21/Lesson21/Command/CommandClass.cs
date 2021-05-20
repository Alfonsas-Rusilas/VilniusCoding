using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson21.Command
{
    public abstract class Command
    {
        public abstract void Execute();
    }


    public class MyCommand : Command
    {
        public override void Execute()
        {
            Console.WriteLine("MyCommand - Execute()");
        }
    }

    class CommandClass
    {
        public void Main()
        {
            MyCommand testCommand = new MyCommand();
            testCommand.Execute();

            Console.ReadKey();
        }

    }
}
