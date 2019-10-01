using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Human original = new Human(18, "Вася");
            System.Console.WriteLine(original);

            Human copy = (Human)original.Copy();
            System.Console.WriteLine(copy);

            HumanFactiry humanFactory = new HumanFactiry(copy);
            Human h1 = humanFactory.MakeCopy();
            System.Console.WriteLine(h1);

            humanFactory.SetPrototype(new Human(30, "Юля"));
            Human h2 = humanFactory.MakeCopy();
            System.Console.WriteLine(h2);
        }
    }
}
