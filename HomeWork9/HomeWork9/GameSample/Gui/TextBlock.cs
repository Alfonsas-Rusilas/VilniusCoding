using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9.GameSample.Gui
{
    class TextBlock : GuiObject
    {
        protected List<TextLine> textBlocks;

        public TextBlock(int x, int y, int width, List<string> list) : base(x, y, width)
        {
            textBlocks = new List<TextLine>();
            //textBlocks = (TextLine)list;
            
        }

        public void Render()
        {
            //Console.WriteLine(data);
        }
    }
}
