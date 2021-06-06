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

            //return;

            //AppInitializeManager.SetUpWindow();

            //CupArray.Render();

            //Figure figure = new Figure(RandomValue.RandomFigure(), RandomValue.RandomColor());
            //figure.Render();

            //Figure figureNext = new Figure(RandomValue.RandomFigure(), RandomValue.RandomColor(), true);
            //figureNext.Render();

            //MessagesManager.PrepareMessages();

            //ConsoleKeyInfo pressedChar;
            //do
            //{
            //    pressedChar = Console.ReadKey(true);
            //    switch (pressedChar.Key)
            //    {
            //        case ConsoleKey.DownArrow:

            //            while (figure.CanMoveDown())
            //            {
            //                figure.MoveDown();
            //            };
            //                // reikia sulieti figūrą prie apačios:
            //                figure.MergeWithBottom();
            //                //figure = new Figure(RandomValue.RandomFigure(), RandomValue.RandomColor());
            //                figure = new Figure(figureNext.FigureType, figureNext.FigureColor);
            //                MessagesManager.AddPoints(CupArray.ClearFilledLines());
            //                MessagesManager.AddFigure();


            //                figure.Render();

            //                figureNext.ClearRender();
            //                figureNext = new Figure(RandomValue.RandomFigure(), RandomValue.RandomColor(), true);
            //                figureNext.Render();
            //                MessagesManager.PrintInfoMessages();
            //            break;

            //            //if (figure.CanMoveDown())
            //            //{
            //            //    figure.MoveDown();
            //            //} 
            //            //    else
            //            //{
            //            //    // reikia sulieti figūrą prie apačios:
            //            //    figure.MergeWithBottom();
            //            //    figure = new Figure(RandomValue.RandomFigure(), RandomValue.RandomColor());
            //            //    CupArray.ClearFilledLines();
            //            //    figure.Render();
            //            //}
            //            //break;
            //        case ConsoleKey.LeftArrow:
            //            if (figure.CanMoveLeft())
            //            {
            //                figure.MoveLeft();
            //             }
            //            break;
            //        case ConsoleKey.RightArrow:
            //            if (figure.CanMoveRight())
            //            {
            //                figure.MoveRight();
            //            }
            //            break;

            //        case ConsoleKey.Spacebar:
            //            if (figure.CanRotateRight())
            //            {
            //                figure.RotateRight();
            //            }
            //            break;
            //    }
            //} while (pressedChar.Key != ConsoleKey.Escape);

            ////Console.ReadLine();
        }


        //static void PrintInfo(Figure figure)
        //{
            
        //    string str = $"After right rotate - Figure type: {figure.FigureType}; Figure Angle: {figure.FigureAngle}" +
        //        $"Figure[1] coord.X = {figure.FigureElementCoordinatesX(1)}, Figure[1] coord.Y = {figure.FigureElementCoordinatesY(1)}";

        //    Console.SetCursorPosition(5, Console.WindowHeight - 1);
        //    Console.WriteLine(str);
        //    Debug.WriteLine(str);
        //}

        //static void PrintInfoBefore(Figure figure)
        //{
        //    string str = $"Before right rotate - Figure type: {figure.FigureType}; Figure Angle: {figure.FigureAngle}, " +
        //        $"Figure[1] coord.X = {figure.FigureElementCoordinatesX(1)}, Figure[1] coord.Y = {figure.FigureElementCoordinatesY(1)}";

        //    Console.SetCursorPosition(5, Console.WindowHeight - 4);
        //    Console.WriteLine(str);
        //    Debug.WriteLine(str);
        //}


    }
}
