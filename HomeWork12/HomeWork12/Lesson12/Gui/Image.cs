using HomeWork12.Lesson12.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12.Lesson12.Gui
{
    class Image : GuiElement, IRenderable
    {

          public void Render()
        {
            Console.WriteLine("test");
            Console.WriteLine("test2");
        }  

    }
}
