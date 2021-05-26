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


            //Console.BackgroundColor = ConsoleColor.White;
            //Console.ForegroundColor = ConsoleColor.White;

            //CupWalls cupWalls = new CupWalls();

            BoxElement s = new BoxElement(AppParam.GameCupWidth/2, 2);

            ConsoleKeyInfo pressedChar;
            do
            {
                pressedChar = Console.ReadKey(true);
                switch (pressedChar.Key)
                {
                    //case ConsoleKey.UpArrow:
                    //    s.MoveUp();
                    //    break;
                    case ConsoleKey.DownArrow:

                        if (s.CanMoveDown())
                        {
                            s.MoveDown();
                            Debug.WriteLine(s.GetCoordinates() + " " + CupWalls.GetDownSideString());
                        } else
                        {
                            CupWalls.UpdateDownSide(s.X, s.Y);
                            s = new BoxElement(AppParam.GameCupWidth / 2, 2);
                            s.Render();
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (s.CanMoveLeft())
                        {
                            s.MoveLeft();
                            Debug.WriteLine(s.GetCoordinates() + " " + CupWalls.GetLeftSideString());
                        }
                        else
                        {
                            CupWalls.UpdateLeftSide(s.X, s.Y);
                            s = new BoxElement(AppParam.GameCupWidth / 2, 2);
                            s.Render();
                        }
                        break;

                    case ConsoleKey.RightArrow:
                        if (s.CanMoveRight())
                        {
                            s.MoveRight();
                            Debug.WriteLine(s.GetCoordinates() + " " + CupWalls.GetLeftSideString());
                        }
                        else
                        {
                            CupWalls.UpdateRightSide(s.X, s.Y);
                            s = new BoxElement(AppParam.GameCupWidth / 2, 2);
                            s.Render();
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


        static void PrintInfo(string str)
        {
            Console.SetCursorPosition(1, Console.WindowHeight - 1);
            Console.WriteLine(str);
        }
    }
}
