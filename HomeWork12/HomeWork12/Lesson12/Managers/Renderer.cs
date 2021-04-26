using HomeWork12.Lesson12.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12.Lesson12.Managers
{
    class Renderer
    {
        private List<IRenderable> renderItems = new List<IRenderable>();

        public void AddRenderItem(IRenderable ra)
        {
            renderItems.Add(ra);
        }

        internal void RenderAll()
        {
            foreach (var item in renderItems)
            {
                item.Render();
            }
        }
    }
}
