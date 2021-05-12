using BigHomeWork4.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork4.Gui
{
    class Button : Frame
    {
        public int Id { get; private set;}
        public TextLine Label { get; set; }
        public bool IsActive { set; get; } = false;
        private static int id = 0;

        public Button(int x, int y, int width, int height, string name, bool IsActive = false) : base(x, y, width, height)
        {
            Id = ++id;
            this.IsActive = IsActive;
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

        public override void Render()
        {
            FrameRenderChar = (IsActive) ? ('*') : ('%');
            base.Render();
            Label.Render();
        }
    }
}
