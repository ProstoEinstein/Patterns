using System.Collections.Generic;
using System;
using Flyweight.Interface;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory factory = new ShapeFactory();
            List<IShape> shapes = new List<IShape>();
            int x = 0;
            int y = 0;
            
            shapes.Add(factory.GetShape("квадрат"));
            shapes.Add(factory.GetShape("круг"));
            shapes.Add(factory.GetShape("круг"));
            shapes.Add(factory.GetShape("точка"));
            shapes.Add(factory.GetShape("квадрат"));
            shapes.Add(factory.GetShape("круг"));
            shapes.Add(factory.GetShape("точка"));

            Random random = new Random();
            foreach (var shape in shapes)
            {
                x = random.Next(100);
                y = random.Next(100);
                shape.Draw(x, y);
            }
        }
    }
}
