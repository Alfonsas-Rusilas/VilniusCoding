using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork4.Speros
{
    class KeysDelegate
    {
        private delegate void KeyCommand();

        

        public static void Main()
        {
            Dictionary<ConsoleKey, KeyCommand> KeysToCommands = new Dictionary<ConsoleKey, KeyCommand>
            {
                {ConsoleKey.RightArrow, Right},
                {ConsoleKey.LeftArrow, Left},
                {ConsoleKey.DownArrow, Down},
                {ConsoleKey.UpArrow, Up}
            };

            KeysToCommands[ConsoleKey.UpArrow]();


            // Using this Dictionary, we can execute any method by using the ConsoleKey value to access the executable code:
            // KeysToCommands[ConsoleKey.Up](); // executes 'Up
            Console.ReadKey();




            //Console.Write("Įveskite sveiką skaičių: ");
            int skaicius = Convert.ToInt32(Console.ReadLine());


        }

        public static void Right()
        {
            Console.WriteLine("Right: ");
        }
        
        public static void  Left()
        {
            Console.WriteLine("Left: ");
        }      
        
        public static void  Down()
        {
            Console.WriteLine("Down: ");
        }
        
        public static void Up()
        {
            Console.WriteLine("Up: ");
        }
    }
}
