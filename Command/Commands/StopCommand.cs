using Command.Interfaces;

namespace Command.Commands
{
    sealed class StopCommand : ICommand
    {
        Computer computer;

        public StopCommand(Computer comp)
        {
            computer = comp;
        }

        public void Execute()
        {
            computer.Stop();
        }
    }
}