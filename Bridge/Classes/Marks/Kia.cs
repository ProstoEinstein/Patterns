using Bridge.Interfaces;

namespace Bridge.Classes.Marks
{
    sealed class Kia : IMark
    {
        public void SetMark()
        {
            System.Console.WriteLine("Kia");
        }
    }
}