using Bridge.Interfaces;

namespace Bridge.Classes
{
    sealed class Hatchback : Car
    {
        public Hatchback(IMark mark) : base(mark)
        {
        }

        public override void ShowType()
        {
            System.Console.WriteLine("Hatchback");
        }
    }
}