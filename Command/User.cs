using Command.Interfaces;

namespace Command
{
    //Invoker class
    sealed class User
    {
        ICommand start;
        ICommand stop;
        ICommand reset;

        public User(ICommand start, ICommand stop, ICommand reset)
        {
            this.start = start;
            this.stop = stop;
            this.reset = reset;
        }

        public void StartComputer()
        {
            start.Execute();
        }
        public void StopComputer()
        {
            stop.Execute();
        }
        public void ResetComputer()
        {
            reset.Execute();
        }
    }
}