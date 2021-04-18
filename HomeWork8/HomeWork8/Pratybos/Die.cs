using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8.Pratybos
{
    class Die
    {
        private int MaxPoint;
        private int CurrentPoint;

        // Žaidimo tikslas - kuo greičiau surinkti 20 kauliuko taškų
        public Die(int maxPoints = 20)
        {
            CurrentPoint = 0;
            MaxPoint = maxPoints;

        }

        public void TaskaiPoMetimo(int point)
        {
            SetPoints(point);
            if (IsGameOver() == true)
            {
                Console.WriteLine("You win!");
            }
        }

        public void SetPoints(int points)
        {
            CurrentPoint += points;

        }

        public bool IsGameOver()
        {
            if (CurrentPoint >= MaxPoint)
            {
                return true; //You win!
            } 
            else
            {
                return false;
            }
        }

    }
}
