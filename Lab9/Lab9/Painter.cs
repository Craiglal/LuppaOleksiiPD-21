using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9_1
{
    class Painter
    {
        public void DrawShape(IDraw shape)
        {
            shape.Draw();
        }
        public void DrawShapes(List<IDraw> shapes)
        {
            foreach  (Shape shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
