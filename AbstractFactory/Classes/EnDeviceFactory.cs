using AbstractFactory.Classes.Device.EnDevice;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Classes
{
    sealed class EnDeviceFactory : IDeviceFactory
    {
        public IKeyboard GetKeyboard()
        {
            return new EnKeyboard();
        }

        public IMouse GetMouse()
        {
            return new EnMouse();
        }

        public ITouchpad GetTouchpad()
        {
            return new EnTouchpad();
        }
    }
}