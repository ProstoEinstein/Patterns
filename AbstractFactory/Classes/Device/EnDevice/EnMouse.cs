using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes.Device.EnDevice
{
    sealed class EnMouse : IMouse
    {
        public void Click()
        {
           System.Console.WriteLine("Mouse click");
        }

        public void DblClick()
        {
            System.Console.WriteLine("Mouse double click");
        }

        public void Scroll(int direction)
        {
            if (direction > 0)
            {
                System.Console.WriteLine("Scroll up");
            }
            else
            {
                if (direction < 0)
                {
                    System.Console.WriteLine("Scroll down");
                }
                else
                {
                    System.Console.WriteLine("No scrolling");
                }
            }
        }
    }
}