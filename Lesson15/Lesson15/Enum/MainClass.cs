using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.Enum
{
    class MainClass
    {
        enum Day { Mon, Tue, Wed }

        static void Main()
        {
            Day siandien = Day.Mon;
            EducationLevel elevel = EducationLevel.Good;
            WriteEducationLevel(elevel);

            WriteText("Testas", TextAligment.Left);
            Console.WriteLine(siandien);

            int keyCode = (int)ConsoleKey.Enter;

        }

        private static void WriteText(string str, TextAligment textAligment)
        {
            Console.WriteLine("Lygiuotė: " + textAligment);

        }

        private static void WriteEducationLevel(EducationLevel level)
        {
            switch (level)
            {
                case EducationLevel.Bad:
                    Console.WriteLine("Tavo levelis: " + level);
                    break;
                case EducationLevel.Good:
                    Console.WriteLine("Tavo levelis: " + level);
                    break;
                case EducationLevel.Perfect:
                    Console.WriteLine("Tavo levelis: " + level);
                    break;
                default:
                    break;
            }
        }

    }
}
