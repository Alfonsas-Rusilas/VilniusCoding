using BigHomeWork5.Enums;
using BigHomeWork5.Figures;
using BigHomeWork5.Providers;
using BigHomeWork5.Utilites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Threading;
using System.Timers;

namespace BigHomeWork5.Managers
{
    internal class Engine
    {
        internal Figure figure;
        internal Figure figureNext;

        internal void ShowWelcomeMenu()
        {
            MessagesManager.PrintWelcomeMessage();
            ConsoleKeyInfo pressedChar;
            do
            {
                pressedChar = Console.ReadKey(true);
                if (pressedChar.Key != ConsoleKey.Q)
                {
                    InitializeGameParameters();
                    Run();
                }
            } while (pressedChar.Key != ConsoleKey.Q);
            
        }

        internal void ShowContinueMenu()
        {
            MessagesManager.PrintContinueMessage();
            ConsoleKeyInfo pressedChar;
            do
            {
                pressedChar = Console.ReadKey(true);
                if (pressedChar.Key != ConsoleKey.Q)
                {
                    
                    Run();
                }
            } while (pressedChar.Key != ConsoleKey.Q);

        }

        internal void Run()
        {

            Console.Clear();
            CupArray.Render();
            

            //Figure figure = new Figure(RandomValue.RandomFigure(), RandomValue.RandomColor());
            figure.Render();

            //Figure figureNext = new Figure(RandomValue.RandomFigure(), RandomValue.RandomColor(), true);
            figureNext.Render();

            MessagesManager.PrepareMessages();

            ConsoleKeyInfo pressedChar;
            do
            {
                pressedChar = Console.ReadKey(true);
                switch (pressedChar.Key)
                {
                    case ConsoleKey.DownArrow:
                        GameData.timer.Enabled = true;
                        while (figure.CanMoveDown())
                        {
                            figure.MoveDown();
                        };
                        figure.MergeWithBottom();
                        figure = new Figure(figureNext.FigureType, figureNext.FigureColor);
                        MessagesManager.AddPoints(CupArray.ClearFilledLines());
                        MessagesManager.AddFigure();
                        figure.Render();
                        figureNext.ClearRender();
                        figureNext = new Figure(RandomValue.RandomFigure(), RandomValue.RandomColor(), true);
                        figureNext.Render();
                        MessagesManager.PrintInfoMessages();
                        break;

                    case ConsoleKey.LeftArrow:
                        if (figure.CanMoveLeft())
                        {
                            figure.MoveLeft();
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (figure.CanMoveRight())
                        {
                            figure.MoveRight();
                        }
                        break;

                    case ConsoleKey.Spacebar:
                        if (figure.CanRotateRight())
                        {
                            figure.RotateRight();
                        }
                        break;
                }
            } while (pressedChar.Key != ConsoleKey.Escape);

            ShowContinueMenu();
        }

        private void InitializeGameParameters()
        {
            GameData.speed = GameData.StartSpeed;
            GameData.timer = new System.Timers.Timer();
            GameData.timer.Interval = GameData.speed;
            GameData.timer.AutoReset = true;
            //GameData.timer.Enabled = true;
            GameData.timer.Elapsed += TimerTickTock;
            GameData.GameStatus = Status.Play;

            figure = new Figure(RandomValue.RandomFigure(), RandomValue.RandomColor());
            figureNext = new Figure(RandomValue.RandomFigure(), RandomValue.RandomColor(), true);
    }

        internal void TimerTickTock(Object source, System.Timers.ElapsedEventArgs e)
        {
            if (GameData.GameStatus == Status.Play)
            {
                Console.SetCursorPosition(1, AppParam.WindowHeight - 1);
                Console.Write($"Raised: {e.SignalTime}");
            }
        }


    }
}
