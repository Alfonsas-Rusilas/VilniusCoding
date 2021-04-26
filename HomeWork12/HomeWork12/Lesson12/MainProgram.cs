using HomeWork12.Lesson12.Animals;
using HomeWork12.Lesson12.Gui;
using HomeWork12.Lesson12.Interfaces;
using HomeWork12.Lesson12.Managers;
using System;

namespace HomeWork12
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            // interface (polimorfizmas)
            // ką mūsų objektai galės padaryti, koks funkcionalumas, bet be implementacijos
            //
            //
            //
            //

            Pet pet = new Pet();

            Animal animal = pet;

            IRenderable renderable = pet;

            Renderer renderer = new Renderer();
            renderer.AddRenderItem(pet);



            Image image = new Image();

            //Console.WriteLine("Hello World!");


        }
    }
}
