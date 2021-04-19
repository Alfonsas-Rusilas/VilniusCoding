using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork9.GameSample.Game;

namespace HomeWork9.GameSample
{
    class GameProject
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // public static void SetCursorposition(int left, int top);

            Hero hero = new Hero("Hero1", 20, 40);
            hero.PrintInfo();
            hero.MoveRight();
            hero.PrintInfo();

            List<Enemy> enemys = new List<Enemy>();

            int universalID = 100;
            for (int x = 0; x < 10; x++)
            {
                Random rnd = new Random();
                enemys.Add(new Enemy(universalID, "Enem"+universalID, rnd.Next(0,10), rnd.Next(0,80)));
                universalID++;
            }

            for (int i = 0; i < enemys.Count; i++)
            {

            }

              Console.SetWindowSize(40, 40);
            // setting buffer size of console
            Console.SetBufferSize(80, 80);

            Console.Clear();

            /*
            for (int y = 40; y>=0; y--)
            {
                Console.SetCursorPosition(10, y);
                Console.Write($"y={y}");
            }
            */

            Console.SetCursorPosition(10, 1);
            Console.Write($"y=1");
            Console.SetCursorPosition(10, 20);
            Console.Write($"y=20");
            Console.SetCursorPosition(10, 40);
            Console.Write($"y=40");

        }
    }
}
