using System;
using q2;

namespace Q2
{
    public class Canvas
    {
        public int CanvasID { get; set; }
        private Shapes[] ShapesArray;
        private int ShapeCount;

        public Canvas(int id)
        {
            CanvasID = id;
            ShapesArray = new Shapes[10];
            ShapeCount = 0;
        }

        public Canvas(Canvas other)
        {
            CanvasID = other.CanvasID;
            ShapeCount = other.ShapeCount;
            ShapesArray = new Shapes[10];

            for (int i = 0; i < ShapeCount; i++)
            {
                if (other.ShapesArray[i] != null)
                    ShapesArray[i] = new Shapes(other.ShapesArray[i]);
            }
        }
    

        public void Addshape(Shapes shape) 
        {
            if (ShapeCount < ShapesArray.Length)
            {
                ShapesArray[ShapeCount] = shape;
                ShapeCount++;
                Console.WriteLine($"Shape {shape.Type} added to Canvas.");
            }
            else
            {
                Console.WriteLine("Canvas is full, cannot add more shapes.");
            }
        }

        public void Display()
        {
            Console.WriteLine($"Canvas ID: {CanvasID}");
            Console.WriteLine("All the shapes in the canvas:");
            Console.WriteLine("--------------------------------");

            if (ShapeCount == 0)
            {
                Console.WriteLine("No shapes added to the canvas.");
                return;
            }

            for (int i = 0; i < ShapeCount; i++)
            {
                ShapesArray[i]?.Draw();
                Console.WriteLine("----------------------------");
            }
        }
    }
}
