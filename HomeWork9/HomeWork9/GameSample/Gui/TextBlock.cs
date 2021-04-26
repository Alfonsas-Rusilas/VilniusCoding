using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.GameSample.Gui
{
    class TextBlock : GuiObject
    {
        private List<TextLine> textBlocks;

        public TextBlock(int x, int y, int width, List<TextLine> list) : base(x, y, width)
        {
            textBlocks = new List<TextLine>(list);
        }

        public void Render()
        {
            foreach (var textLine in textBlocks)
            {
                textLine.Render();
            }
        }
    }
}
