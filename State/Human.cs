using State.Interfaces;

namespace State
{
    sealed class Human
    {
        private IActivity state;

        public void SetState(IActivity state)
        {
            this.state = state;
        }

        public void DoSomething()
        {
           state.DoSomething(this);
        }

    }
}