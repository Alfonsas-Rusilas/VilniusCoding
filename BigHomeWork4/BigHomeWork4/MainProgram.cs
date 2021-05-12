using BigHomeWork4.Game;
using BigHomeWork4.Gui;
using BigHomeWork4.Window;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigHomeWork4
{
    class MainProgram
    {
        static void Main(string[] args)
        {

            /*
            MenuController menuController = new MenuController();
            menuController.ShowMenu();
            */

            ConsoleKeyInfo cki;

            Console.Clear();

            // Establish an event handler to process key press events.
            Console.CancelKeyPress += new ConsoleCancelEventHandler(myHandler);
            while (true)
            {
                Console.Write("Press any key, or 'X' to quit, or ");
                Console.WriteLine("CTRL+C to interrupt the read operation:");

                // Start a console read operation. Do not display the input.
                cki = Console.ReadKey(true);

                // Announce the name of the key that was pressed .
                Console.WriteLine($"  Key pressed: {cki.Key}\n");

                // Exit if the user pressed the 'X' key.
                if (cki.Key == ConsoleKey.X) break;
            }



        }


        protected static void myHandler(object sender, ConsoleCancelEventArgs args)
        {
            Console.WriteLine("\nmyHandler: The read operation has been interrupted.");

            Console.WriteLine($"myHandler:  Key pressed: {args.SpecialKey}");

            Console.WriteLine($"myHandler:  Cancel property: {args.Cancel}");

            // Set the Cancel property to true to prevent the process from terminating.
            Console.WriteLine("myHandler: Setting the Cancel property to true...");
            args.Cancel = true;

            // Announce the new value of the Cancel property.
            Console.WriteLine($"myHandler:  Cancel property: {args.Cancel}");
            Console.WriteLine("myHandler: The read operation will resume...\n");
        }


    }
}

