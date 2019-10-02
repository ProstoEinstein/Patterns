using State.Interfaces;

namespace State.Clasess
{
    sealed class Rest : IActivity
    {
        private int count = 0;
        public void DoSomething(Human context)
        {
            if (count < 3)
            {
                System.Console.WriteLine("Отдыхаем...");
                count++;
            }
            else
            {
                context.SetState(new Work());
            }
        }
    }
}