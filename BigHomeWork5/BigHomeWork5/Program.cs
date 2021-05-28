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
        //public BoxElement s;

        static void Main(string[] args)
        {
            AppInitializeManager.SetUpWindow();


            //Console.BackgroundColor = ConsoleColor.White;
            //Console.ForegroundColor = ConsoleColor.White;

            //CupWalls cupWalls = new CupWalls();
            CupArray.DrawArray2D(0,0);


            BoxElement s = new BoxElement(4, 1);
            s.Render();

            ConsoleKeyInfo pressedChar;
            do
            {
                pressedChar = Console.ReadKey(true);
                switch (pressedChar.Key)
                {
                    case ConsoleKey.DownArrow:

                        if (s.CanMoveDown())
                        {
                            s.MoveDown();
                            PrintInfo(s);
                            CupArray.DrawArray2D();

                        } else
                        {
                            CupArray.UpdateDownSide(s.X, s.Y);
                            s = new BoxElement(AppParam.GameCupWidth / 2, 2);
                            s.Render();
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (s.CanMoveLeft())
                        {
                            s.MoveLeft();
                            PrintInfo(s);
                            CupArray.DrawArray2D();
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (s.CanMoveRight())
                        {
                            s.MoveRight();
                            PrintInfo(s);
                            CupArray.DrawArray2D();
                        }
                        break;
                    
                    case ConsoleKey.Spacebar:
                        s = new BoxElement(8, 8);
                        s.Render();
                        break;
                }
            } while (pressedChar.Key != ConsoleKey.Escape);




            Console.ReadLine();
        }


        static void PrintInfo(BoxElement b)
        {
            
            int x = b.X;
            int y = b.Y;
            

            int c = x - 1;
            int L = CupArray.LeftArray2DValue(x, y);

            c = y; // + 1;
            int D = CupArray.DownArray2DValue(x, y);

            c = x + 1;
            int R = CupArray.RightArray2DValue(x, y);

            string str = $"Box koordinatės: ({b.X},{b.Y}); L-Masyve={L}; R-Masyve={R}; D-Masyve={D};";

            Console.SetCursorPosition(5, Console.WindowHeight - 1);
            Console.WriteLine(str);
            Debug.WriteLine(str);
        }
    }
}
