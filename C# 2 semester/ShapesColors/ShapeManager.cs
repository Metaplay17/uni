using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesColors
{
    internal class ShapeManager
    {
        private static ShapeManager instance;
        private List<Shape> shapes = new List<Shape>();
        private int selectedInd = -1;

        private ShapeManager() { }

        public static ShapeManager GetInstance()
        {
            if (instance == null)
            {
                instance = new ShapeManager();
            }
            return instance;
        }

        public void AddShape(Shape shape) {  shapes.Add(shape); }

        public void Draw(Graphics graph)
        {
            foreach (Shape shape in shapes)
            {
                shape.Draw(graph);
            }
        }

        public int CheckShape(int x, int y)
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
        public bool CheckCollisions(int deltaX, int deltaY)
        {
            shapes[selectedInd].Move(deltaX, deltaY);
            for (int i = 0; i < shapes.Count; i++)
            {
                if (i != selectedInd && Shape.IsIntersect(shapes[selectedInd], shapes[i]))
                {
                    shapes[selectedInd].Move(-deltaX, -deltaY);
                    return false;
                }
            }
            shapes[selectedInd].Move(-deltaX, -deltaY);
            return true;
        }
        public bool CheckCollisions(Shape newShape)
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                if (i != selectedInd && Shape.IsIntersect(newShape, shapes[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsMoveAble(int edge, int deltaY) => shapes[selectedInd].GetHighEdge() + deltaY > edge;
        public void SelectShape(int ind) => selectedInd = ind;
        public void UnselectShape() => selectedInd = -1;
        public bool IsSelectShape() => selectedInd != -1;

        public void MoveShape(int deltaX, int deltaY)
        {
            if (selectedInd == -1)
            {
                throw new Exception("No selected shape");
            }
            shapes[selectedInd].Move(deltaX, deltaY);
        }
    }
}
