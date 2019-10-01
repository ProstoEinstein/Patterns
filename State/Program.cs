using System;
using State.Clasess;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.SetState(new Work());
            for (int i = 0; i < 10; i++)
            {
                human.DoSomething();
            }
        }
    }
}
