using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork5.Utilites
{
    internal struct AppParam
    {
        internal const int InfoPanelWidth = 21;
        internal const int DebugPanelWidth = 21;

        internal const int GameCupWidth = 17;
        internal const int WindowWidth = InfoPanelWidth + GameCupWidth;

        internal const int WindowHeight = 26;
        internal const int GameCupHeight = WindowHeight - 1;
    }
}
