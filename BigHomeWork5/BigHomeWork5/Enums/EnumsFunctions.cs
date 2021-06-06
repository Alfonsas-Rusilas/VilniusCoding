using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork5.Enums
{
    internal class EnumsFunctions
    {
        internal static FiguresAngle GetNextFigureAngleEnumValue(FiguresAngle e)
        {
            Array all = FiguresAngle.GetValues(e.GetType());
            int i = Array.IndexOf(all, e);
            if ((i >= all.Length - 1) || (i < 0))
            {
                return (FiguresAngle)all.GetValue(0);
            }
            return (FiguresAngle)all.GetValue(i + 1);
        }
    }
}
