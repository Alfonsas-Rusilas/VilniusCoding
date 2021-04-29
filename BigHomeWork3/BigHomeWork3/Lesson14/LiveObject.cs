using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigHomeWork3.Lesson14
{
    abstract class LiveObject
    {
        private int lifeSpan;

        public LiveObject(int lifeSpan = 10)
        {
            this.lifeSpan = lifeSpan;
        }

        public int GetLiveSpan()
        {
            return lifeSpan;
        }

    }
}
