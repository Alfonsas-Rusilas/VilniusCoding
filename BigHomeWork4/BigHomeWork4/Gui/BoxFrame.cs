using BigHomeWork4.Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork4.Gui
{
    class BoxFrame : GuiObject
    {
        public string Name { get; }
        private const int MaxNameLength = 10;
        public bool IsActive { private set; get; }
        public BoxType BoxType { get; }

        public BoxFrame(BoxType boxtype, int x, int y, int width, int height, string name, bool IsActive = false) : base(x, y, width, height)
        {
            Name = name.Substring(0, (name.Length >= MaxNameLength)?(MaxNameLength):(name.Length));
            this.IsActive = IsActive;
            BoxType = boxtype;

        }

        public override void Render()
        {
            List<string> str_list = GetConsoleBox(Name);
            RenderConsoleBox(str_list, X, Y);
        }

        private void RenderConsoleBox(List<string> strL, int startX, int startY)
        {
            int x = startX;
            int y = startY;
            Console.SetCursorPosition(x, y);

            foreach (var strl in strL)
            {
                Console.Write(strl);
                y++;
                Console.SetCursorPosition(x, y);
            }
        }

        private List<string> GetConsoleBox(string s)
        {
            string ulCorner = "╔";
            string llCorner = "╚";
            string urCorner = "╗";
            string lrCorner = "╝";
            string vertical = "║";
            string horizontal = "═";

            string[] lines = s.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            //int longest = 0;
            //foreach (string line in lines)
            //{
            //    if (line.Length > longest)
            //        longest = line.Length;
            //}
            //int width = longest + 2; // 1 space on each side

            int width = MaxNameLength + 2; // 1 space on each side

            string h = string.Empty;
            for (int i = 0; i < width; i++)
                h += horizontal;

            // box top
            List<string> sb = new List<string>();
            sb.Add(ulCorner + h + urCorner);

            // box contents
            foreach (string line in lines)
            {
                double dblSpaces = (((double)width - (double)line.Length) / (double)2);
                int iSpaces = Convert.ToInt32(dblSpaces);

                if (dblSpaces > iSpaces) // not an even amount of chars
                {
                    iSpaces += 1; // round up to next whole number
                }

                string beginSpacing = "";
                string endSpacing = "";
                for (int i = 0; i < iSpaces; i++)
                {
                    beginSpacing += " ";

                    if (!(iSpaces > dblSpaces && i == iSpaces - 1)) // if there is an extra space somewhere, it should be in the beginning
                    {
                        endSpacing += " ";
                    }
                }
                // add the text line to the box
                sb.Add(vertical + beginSpacing + line + endSpacing + vertical);
            }

            // box bottom
            sb.Add(llCorner + h + lrCorner);

            // the finished box
            return sb;
        }



    }
}
