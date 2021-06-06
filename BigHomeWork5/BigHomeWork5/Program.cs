using BigHomeWork5.Enums;
using BigHomeWork5.Figures;
using BigHomeWork5.Managers;
using BigHomeWork5.Providers;
using BigHomeWork5.Utilites;
using System;
using System.Diagnostics;

namespace BigHomeWork5
{
    class Program
    {

        static void Main(string[] args)
        {
            AppInitializeManager.SetUpWindow();

            Engine engine = new Engine();
            engine.ShowWelcomeMenu();
        }

    }
}
