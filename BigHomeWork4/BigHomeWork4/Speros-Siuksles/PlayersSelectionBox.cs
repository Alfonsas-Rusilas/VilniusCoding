using BigHomeWork4.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork4.Gui
{
    class PlayerSelectionBox : Frame
    {
        public TextLine Label { get; set; }
        public bool IsActive { set; get; } = false;
        public BoxType BoxType { get; }

        public PlayerSelectionBox(BoxType boxType, int x, int y, int width, int height, string name, bool IsActive = false) : base(x, y, width, height)
        {
            this.IsActive = IsActive;
            this.BoxType = boxType;

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
