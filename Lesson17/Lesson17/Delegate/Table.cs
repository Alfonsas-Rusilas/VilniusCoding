using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson17.Delegate
{
    class Table
    {
        private int legCount;
        public event MyAction action;

        public int Data;



        public void Unfold()
        {
            //
        }

        public void Fold()
        {
            //
        }

        public void AddFood(string v)
        {
            //throw new NotImplementedException();
        }

        internal void AddActionToTable(MyAction customAction)
        {
            action = customAction;
        }

        internal void DoSpecialAction()
        {
            if (action != null)
            {
                int result = action(40, 50, true);
            }
        }

        public void DoAction(MyAction customAction)
        {
            action = customAction;
        }
    }
}
