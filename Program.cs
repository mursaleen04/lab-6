using System;
using q2;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shapes s1 = new Shapes(1, "Circle", "black");
            Shapes s2 = new Shapes(2, "Triangle", "Blue");
            Shapes s3 = new Shapes(3, "Rectangle", "yellow");
            Shapes s4 = s1; 
            Shapes s5 = new Shapes(s2); 
          

            Console.WriteLine("Shallow Copy:");
            Console.WriteLine("----------------------------");
            s4.Draw();
            Console.WriteLine("----------------------------");

            Console.WriteLine("Deep Copy:");
            Console.WriteLine("----------------------------");
            s5.Draw();
            Console.WriteLine("----------------------------");

            Canvas c1 = new Canvas(12345);
            c1.Addshape(s1);
            c1.Addshape(s2);
            c1.Addshape(s3);

            Console.WriteLine("Displaying Canvas:");
            Console.WriteLine("------------------------------------");
            c1.Display();

            Console.ReadKey();
        }
    }
}
