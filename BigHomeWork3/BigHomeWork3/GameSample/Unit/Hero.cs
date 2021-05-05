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
            int width = AppSettings.HeroWidth;
            int height = AppSettings.HeroHeight;
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

        public void MoveRight(int x)
        {
            // jei atsiremiam į dešinę sieną, išeiname
            if ((frame.X + frame.Width) >= x-1)
            {
                return;
            }
            frame.ClearRender();
            frame.X++;
            Label.X++;
            X = frame.X;
            Render();
        }

        public void MoveLeft(int x)
        {
            // jei atsiremiam į kairę sieną, išeiname
            if (frame.X <= x+1)
            {
                return;
            }  
            frame.ClearRender();
            frame.X--; 
            Label.X--;
            X = frame.X;
            Render();
        }

        public int HeroMidX()
        {
            return (frame.X + frame.Width/2);
        }

        public int HeroY()
        {
            return frame.Y;
        }



    }
}
