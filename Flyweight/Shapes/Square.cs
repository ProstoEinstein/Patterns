using Flyweight.Interface;

namespace Flyweight.Shapes
{
    sealed class Square : IShape
    {
        int side = 10;
        public void Draw(int x, int y)
        {
           System.Console.WriteLine("Рисуем квадрат с координатами: ({0}, {1}) и стороной {2}", x, y, side);
        }
    }
}