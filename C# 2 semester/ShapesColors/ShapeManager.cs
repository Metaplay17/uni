using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesColors
{
    internal static class ShapeManager
    {
        private static List<Shape> shapes = new List<Shape>();
        private static int selectedInd = -1;

        public static void AddShape(Shape shape) {  shapes.Add(shape); }

        public static void Draw(Graphics graph)
        {
            foreach (Shape shape in shapes)
            {
                shape.Draw(graph);
            }
        }

        public static int CheckShape(int x, int y)
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].IsPointContained(x, y))
                {
                    return i;
                }
            }
            return -1;
        }
        public static void SelectShape(int ind) => selectedInd = ind;
        public static void UnselectShape() => selectedInd = -1;
        public static bool IsSelectShape() => selectedInd != -1;

        public static void MoveShape(int deltaX, int deltaY)
        {
            if (selectedInd == -1)
            {
                throw new Exception("No selected shape");
            }
            shapes[selectedInd].Move(deltaX, deltaY);
        }
    }
}
