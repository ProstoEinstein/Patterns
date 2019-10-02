using Bridge.Interfaces;

namespace Bridge.Classes.Marks
{
    sealed class Skoda : IMark
    {
        public void SetMark()
        {
            System.Console.WriteLine("Skoda");
        }
    }
}