using AbstractFactory.Classes.Device.RuDevice;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    sealed class RuDeviceFactory : IDeviceFactory
    {
        public IKeyboard GetKeyboard()
        {
            return new RuKeyboard();
        }

        public IMouse GetMouse()
        {
            return new RuMouse();
        }

        public ITouchpad GetTouchpad()
        {
            return new RuTouchpad();
        }
    }
}