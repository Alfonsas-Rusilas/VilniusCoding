using BigHomeWork3.GameSample.Game;
using BigHomeWork3.GameSample.Gui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.GameSample.Unit
{
    class Hero: Unit
    {
        private Frame frame;
        private TextLine Label;

        public Hero(string name, int x, int y) : base(name, x, y)
        {
            int width = StaticClass.HeroWidth;
            int height = StaticClass.HeroHeight;
            frame = new Frame(x, y, width, height, 'o');
            if (name.Length > width - 2)
            {
                Label = new TextLine(x + 1, y + height / 2, width - 2, name.Substring(0, width - 2));
            }
            else
            {
                int temp = width - 2;
                temp = (temp - name.Length) / 2;
                Label = new TextLine(x + 1 + temp, y + height / 2, width - 2, name);
            }
        }

        public void Render()
        {
            frame.Render();
            Label.Render();
        }

        public void MoveRight()
        {
            frame.ClearRender();
            frame.X++;
            Label.X++;
            Render();
        }

        public void MoveLeft()
        {
            frame.X <= 


            frame.ClearRender();
            frame.X--; 
            Label.X--;
            Render();
        }


    }
}
