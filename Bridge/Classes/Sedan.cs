using Bridge.Interfaces;

namespace Bridge.Classes
{
    sealed class Sedan : Car
    {
        public Sedan(IMark mark) : base(mark)
        {
        }

        public override void ShowType()
        {
            System.Console.WriteLine("Sedan");
        }
    }
}