using Bridge.Interfaces;

namespace Bridge.Classes
{
    abstract class Car
    {
        public IMark mark;

        public Car(IMark mark)
        {
            this.mark = mark;
        }

        void ShowDetails()
        {
            ShowType();
            mark.SetMark();
        }
        abstract public void ShowType();
    }
}