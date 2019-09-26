using System.Collections.Generic;
using Flyweight.Interface;
using Flyweight.Shapes;

namespace Flyweight
{
    class ShapeFactory
    {
        private static Dictionary<string, IShape> shapes = new Dictionary<string, IShape>();

        public IShape GetShape(string shapeName)
        {
            string sNameLow = shapeName.ToLowerInvariant();
            var shape = shapes.GetValueOrDefault(sNameLow);
            if (shape == null)
            {
                switch (sNameLow)
                {
                    case "круг":
                        shape = new Circle();
                        break;

                    case "квадрат":
                        shape = new Square();
                        break;

                    case "точка":
                        shape = new Point();
                        break;
                }
                shapes.Add(sNameLow, shape);
            }
            return shape;
        }
    }
}