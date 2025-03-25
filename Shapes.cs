using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    internal class Shapes
    
        {
            public int ShapeID { get; set; }
            public string Type { get; set; }
            public string Color { get; set; }

            public Shapes(int shapeID, string shapeType, string color)
            {
                ShapeID = shapeID;
                Type = shapeType;
                Color = color;
            }

            public Shapes(Shapes other)
            {
                ShapeID = other.ShapeID;
                Type = other.Type;
                Color = other.Color;
            }

            public void Draw()
            {
                Console.WriteLine($"Shape ID: {ShapeID}");
                Console.WriteLine($"Shape Type: {Type}");
                Console.WriteLine($"Color: {Color}");
            }

            ~Shapes()
            {
                Console.WriteLine($"The shape {Type} with ID {ShapeID} is destructed.");
            }
        }
    }


