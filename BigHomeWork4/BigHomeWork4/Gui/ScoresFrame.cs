using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork4.Gui
{
    class ScoresFrame : GuiObject
    {
        public string Name { private set; get; }
        public bool IsActive { set; get; }

        private const string ulCorner = "╔";
        private const string llCorner = "╚";
        private const string urCorner = "╗";
        private const string lrCorner = "╝";
        private const string vertical = "║";
        private const char horizontal = '═';
        private const char point = 'X';
        //public const int BoxHeight = 7;

        public ScoresFrame(int x, int y, int width, int height, string name, bool IsActive = false) : base(x, y, width, height)
        {
            SetName(name);
            this.IsActive = IsActive;
        }

        public override void Render()
        {
            List<string> str_list = GetConsoleBox();
            RenderConsoleBox(str_list);
        }

        private void RenderConsoleBox(List<string> strL)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            int y = Y;
            Console.SetCursorPosition(X, y);
            foreach (var strl in strL)
            {
                Console.Write(strl);
                Console.SetCursorPosition(X, ++y);
            }
            Console.ResetColor();
        }

        public void SetName(string name)
        {
            Name = name.Substring(0, (name.Length >= Width - 4) ? (Width - 4) : (name.Length));
            int a = 1;
            while (Name.Length < Width - 4)
            {
                Name = (a < 0) ? Name + " " : " " + Name;
                a *= (-1);
            }
        }

        public int GetHeight()
        {
            string s = Name;
            string[] lines = s.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            return lines.Count() + 2;
        }

        public List<string> GetConsoleBox()
        {
            string s = Name;
            string[] lines = s.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            int longest = 0;
            foreach (string line in lines)
            {
                if (line.Length > longest)
                    longest = line.Length;
            }
            int width = longest + 2; // 1 space on each side
            //int width = Width-2; // 1 space on each side


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
            return sb;
        }

    }
}
