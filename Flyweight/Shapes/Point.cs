using Flyweight.Interface;

namespace Flyweight.Shapes
{
    class Point : IShape
    {
        public void Draw(int x, int y)
        {
            System.Console.WriteLine("Рисуем точку с координатами: ({0}, {1})", x, y);
        }
    }
}