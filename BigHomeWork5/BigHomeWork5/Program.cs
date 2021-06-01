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

            CupArray.DrawArray2D(0,0);

            Figure figure = new Figure(FiguresTypes.L, RandomValue.RandomColor());
            figure.Render();


            ConsoleKeyInfo pressedChar;
            do
            {
                pressedChar = Console.ReadKey(true);
                switch (pressedChar.Key)
                {
                    case ConsoleKey.DownArrow:

                        if (figure.CanMoveDown())
                        {
                            figure.MoveDown();
                            CupArray.DrawArray2D();
                        } 
                            else
                        {
                            //CupArray.UpdateDownSide(s.X, s.Y);
                            //s = new BoxElement(AppParam.GameCupWidth / 2, 2);
                            //s.Render();
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (figure.CanMoveLeft())
                        {
                            figure.MoveLeft();
                             CupArray.DrawArray2D();
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (figure.CanMoveRight())
                        {
                            figure.MoveRight();
                            CupArray.DrawArray2D();
                        }
                        break;
                    
                    case ConsoleKey.Spacebar:
                        if (figure.CanRotateRight())
                        {
                            figure.RotateRight();
                            //PrintInfo(s);
                            CupArray.DrawArray2D();
                        }
                        break;
                }
            } while (pressedChar.Key != ConsoleKey.Escape);



            Console.ReadLine();
        }


        static void PrintInfo(BoxElement b)
        {
            
            int x = b.X;
            int y = b.Y;
            int L = CupArray.LeftArray2DValue(x, y);
            int D = CupArray.DownArray2DValue(x, y);
            int R = CupArray.RightArray2DValue(x, y);
            string str = $"Box koordinatės: ({b.X},{b.Y}); L-Masyve={L}; R-Masyve={R}; D-Masyve={D};";
            Console.SetCursorPosition(5, Console.WindowHeight - 1);
            Console.WriteLine(str);
            Debug.WriteLine(str);
        }


    }
}
