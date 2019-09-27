using Command.Interfaces;

namespace Command.Commands
{
    sealed class ResetCommand : ICommand
    {
        Computer computer;

        public ResetCommand(Computer comp)
        {
            computer = comp;
        }

        public void Execute()
        {
            computer.Reset();
        }
    }
}