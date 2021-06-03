using BigHomeWork5.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork5.Utilites
{
    internal static class RandomValue
    {
        private static Random random = new Random();

        internal static int ZeroRange(int maxNumber)
        {
            return random.Next(maxNumber);
        }

        internal static int InRange(int min, int max)
        {
            return ZeroRange(max - min + 1) + min;
        }

        internal static FiguresTypes RandomFigure()
        {
            return (FiguresTypes)InRange(0, 6);
        }

        internal static ConsoleColor RandomColor()
        {
            //ConsoleColor color;
            //int 
            //do
            //{
            //    color = (ConsoleColor)RandomNumber.ZeroBasedRange(16);
            //} while (color.Equals(FieldData.BackgroundColor));
            //return color;

            return (ConsoleColor)InRange(1, 15);
        }
    }
}
