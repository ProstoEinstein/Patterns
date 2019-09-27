using Flyweight.Interface;

namespace Flyweight.Shapes
{
    sealed class Circle : IShape
    {
        int radius = 5;
        public void Draw(int x, int y)
        {
            System.Console.WriteLine("Рисуем круг с координатами: ({0}, {1}) и радиусом {2}", x, y, radius);
        }
    }
}