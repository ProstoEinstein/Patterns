namespace AbstractFactory.Interfaces
{
    interface IDeviceFactory
    {
        IMouse GetMouse();
        IKeyboard GetKeyboard();
        ITouchpad GetTouchpad();
    }
}