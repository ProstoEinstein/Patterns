using System;
using Bridge.Classes;
using Bridge.Classes.Marks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Sedan(new Kia());
            c.ShowType();
        }
    }
}
