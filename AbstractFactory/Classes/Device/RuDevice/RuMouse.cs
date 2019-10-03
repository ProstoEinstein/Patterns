using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes.Device.RuDevice
{
    sealed class RuMouse : IMouse
    {
        public void Click()
        {
           System.Console.WriteLine("Щелчок мышью");
        }

        public void DblClick()
        {
            System.Console.WriteLine("Двойной щелчок мышью");
        }

        public void Scroll(int direction)
        {
            if (direction > 0)
            {
                System.Console.WriteLine("Скроллим верх");
            }
            else
            {
                if (direction < 0)
                {
                    System.Console.WriteLine("Скроллим вниз");
                }
                else
                {
                    System.Console.WriteLine("Не скроллим");
                }
            }
        }
    }
}