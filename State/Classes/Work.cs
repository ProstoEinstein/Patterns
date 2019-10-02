using State.Interfaces;

namespace State.Clasess
{
    sealed class Work : IActivity
    {
        public void DoSomething(Human context)
        {
           System.Console.WriteLine("Работаем!");
           context.SetState(new Rest());
        }
    }
}