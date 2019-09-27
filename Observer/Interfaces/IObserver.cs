namespace Observer.Interfaces
{
    interface IObserver
    {
        void HandleEvent(double temperature, double pressure);
    }
}