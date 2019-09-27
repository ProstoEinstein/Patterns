namespace Observer.Interfaces
{
  interface IObsevable
  {
        void AddObserver(IObserver obj);
        void RemoveObserver(IObserver obj);
        void NotifyObserver();
  }
}