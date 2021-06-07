using BigHomeWork5.Enums;
using BigHomeWork5.Figures;
using BigHomeWork5.Providers;
using BigHomeWork5.Utilites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                    GameData.ResetData();
                    Run();
                }
            } while (pressedChar.Key != ConsoleKey.Q);
            EndOfGameManager.EndOfGame();
        }

        internal void ShowContinueMenu()
        {
            GameData.timer.Stop();
            Console.ResetColor();
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
            EndOfGameManager.EndOfGame();
        }

        internal void ShowWinnerMenu()
        {
            GameData.timer.Stop();
            MessagesManager.PrintWinnerMessage();
            EndOfGameManager.EndOfGame();
        }

        internal void ShowGameOverMenu()
        {
            GameData.timer.Stop();
            MessagesManager.PrintGameOverMessage();
            Console.ReadKey();
            EndOfGameManager.EndOfGame();
        }

        internal void Run()
        {
            GameData.timer.Start();
            Console.Clear();
            TetrisArray.Render();
            MessagesManager.PrintInfoMessages();

            figure.Render();
            figureNext.Render();

            ConsoleKeyInfo pressedChar;
            do
            {
                pressedChar = Console.ReadKey(true);
                switch (pressedChar.Key)
                {
                    case ConsoleKey.DownArrow:
                        AfterDownKeyPressed();
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
            GameData.timer.Elapsed += TimerTickTock;
            GameData.GameStatus = Status.Play;

            figure = new Figure(RandomValue.RandomFigure(), RandomValue.RandomColor());
            figureNext = new Figure(RandomValue.RandomFigure(), RandomValue.RandomColor(), true);
    }

        internal void TimerTickTock(Object source, System.Timers.ElapsedEventArgs e)
        {
            if (GameData.GameStatus == Status.Play)
            {
                if (figure.CanMoveDown())
                {
                    figure.MoveDown();
                } 
                    else
                {
                    if (figure.NotMooved())
                    {
                        ShowGameOverMenu();

                    }
                    figure.MergeWithBottom();
                    figure = new Figure(figureNext.FigureType, figureNext.FigureColor);
                    GameData.points += TetrisArray.ClearFilledLines();
                    figure.Render();
                    figureNext.ClearRender();
                    figureNext = new Figure(RandomValue.RandomFigure(), RandomValue.RandomColor(), true);
                    figureNext.Render();
                    GameData.speed--;
                    GameData.points++;
                    GameData.figureCount++;
                    MessagesManager.PrintInfoMessages();
                }
                if (GameData.figureCount >= GameData.FiguresPerLevel)
                {
                    GameData.level++;
                    GameData.figureCount = 1;
                    GameData.points += GameData.PointsPerLevel;
                }
                if (GameData.level >= GameData.LevelsCount)
                {
                    ShowWinnerMenu();
                }

            }
        }

        internal void AfterDownKeyPressed()
        {
            GameData.timer.Enabled = false;
            while (figure.CanMoveDown())
            {
                figure.MoveDown();
            };
            figure.MergeWithBottom();
            figure = new Figure(figureNext.FigureType, figureNext.FigureColor);
            GameData.points += TetrisArray.ClearFilledLines();
            figure.Render();
            figureNext.ClearRender();
            figureNext = new Figure(RandomValue.RandomFigure(), RandomValue.RandomColor(), true);
            figureNext.Render();
            GameData.speed--;
            GameData.points++;
            GameData.figureCount++;
            MessagesManager.PrintInfoMessages();

            GameData.timer.Enabled = true;
        }


    }
}
