using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12.Lesson12.Interfaces
{
    interface IMoovable
    {
        int X { get; set; }
        int Y { get; set; }



        void Move();

        //event EventHandler onClick;

    }
}
