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
        public bool IsActive { set; get; }
        public BoxType BoxType { get; }

        private const string ulCorner = "╔";
        private const string llCorner = "╚";
        private const string urCorner = "╗";
        private const string lrCorner = "╝";
        private const string vertical = "║";
        private const char horizontal = '═';
        private const char point = 'X';
        public const int BoxHeight = 7;

        public BoxFrame(BoxType boxtype, int x, int y, int width, int height, string name, bool IsActive = false) : base(x, y, width, BoxHeight)
        {
            Name = name.Substring(0, (name.Length >= width-4)?(width-4):(name.Length));
            int a = 1;
            while (Name.Length < width-4)
            {
                Name = (a<0) ? Name +" " : " "+Name;
                a *= (-1);
            }
            this.IsActive = IsActive;
            BoxType = boxtype;
        }

        public override void Render()
        {
            List<string> str_list = GetConsoleBox();
            RenderConsoleBox(str_list);
        }

        private void RenderConsoleBox(List<string> strL)
        {
            int y = Y;
            Console.SetCursorPosition(X, y);
            foreach (var strl in strL)
            {
                Console.Write(strl);
                Console.SetCursorPosition(X, ++y);
            }
        }
        private List<string> GetConsoleBox()
        {
            char fill = (IsActive) ? (point) : (' ');
            List<string> sb = new List<string>();
            // Box from lines (BoxHeight = 7)
            sb.Add(ulCorner + (new String(horizontal, Width - 2)) + urCorner);
            sb.Add(vertical + (new String(fill, Width - 2)) + vertical);
            sb.Add(vertical + fill + (new String(' ', Width - 4)) + fill + vertical);
            sb.Add(vertical + fill + Name + fill + vertical);
            sb.Add(vertical + fill + (new String(' ', Width - 4)) + fill + vertical);
            sb.Add(vertical + (new String(fill, Width - 2)) + vertical);
            sb.Add(llCorner + (new String(horizontal, Width - 2)) + lrCorner);
            return sb;
        }

        /*
        private List<string> GetConsoleBoxZZ()
        {
            char fill = (IsActive) ? (point) : (' ');
            List<string> sb = new List<string>();
            sb.Add(ulCorner + (new String(horizontal, Width-2)) + urCorner);
            sb.Add(vertical + (new String(' ', Width-2)) + vertical);
            sb.Add(vertical + (new String(' ', Width - 2)) + vertical);
            sb.Add(vertical + " " + Name + " " + vertical);
            sb.Add(vertical + (new String(' ', Width - 2)) + vertical);
            sb.Add(vertical + (new String(' ', Width - 2)) + vertical);
            sb.Add(llCorner + (new String(horizontal, Width - 2)) + lrCorner);
            return sb;
        }

        private List<string> GetActiveConsoleBox()
        {
            List<string> sb = new List<string>();
            sb.Add(ulCorner + (new String(horizontal, Width - 2)) + urCorner);
            sb.Add(vertical + (new String(point, Width - 2)) + vertical);
            sb.Add(vertical + point + (new String(' ', Width - 4)) + point + vertical);
            sb.Add(vertical + point + Name + point + vertical);
            sb.Add(vertical + point + (new String(' ', Width - 4)) + point + vertical);
            sb.Add(vertical + (new String(point, Width - 2)) + vertical);
            sb.Add(llCorner + (new String(horizontal, Width - 2)) + lrCorner);
            return sb;
        }
        */

        /*
        private List<string> GetConsoleBoxBefore(string s)
        {
            string ulCorner = "╔";
            string llCorner = "╚";
            string urCorner = "╗";
            string lrCorner = "╝";
            string vertical = "║";
            string horizontal = "═";
            string point = "·";

            string str_empty = new String(' ', s.Length); 


            //string[] lines = s.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            //int width = MaxNameLength + 2; // 1 space on each side
            int width = Width;// + 2; // 1 space on each side


            string h = string.Empty;
            for (int i = 0; i < width; i++)
                h += horizontal;

            // box top
            List<string> sb = new List<string>();
            sb.Add(ulCorner + h + urCorner);

            // box contents
            //foreach (string line in lines)
            //{
                string line = s;
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
                sb.Add(vertical + beginSpacing + str_empty + endSpacing + vertical);
            //}

            sb.Add(vertical + beginSpacing + line + endSpacing + vertical);
            sb.Add(vertical + beginSpacing + str_empty + endSpacing + vertical);

            // box bottom
            sb.Add(llCorner + h + lrCorner);

            //if (IsActive && sb.Count>=5)
            //{
            //    string str = sb[1];
            //    str. = "S";

            //}

            // the finished box
            return sb;
        }
        */


    }
}
