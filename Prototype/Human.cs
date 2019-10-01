using System;
using Prototype.Interfaces;

namespace Prototype
{
    sealed class Human : ICopyable
    {
        int age;
        string name;

        public Human(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public object Copy()
        {
            Human human = new Human(age, name);
            return human;
        }

       public override string ToString()
       {
           return String.Format("Человек [Имя = {0}, Возраст = {1}]", name, age);
       }
    }
}