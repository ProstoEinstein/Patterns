using Command.Interfaces;


namespace Command.Commands
{
    sealed class StartCommand : ICommand
    {
        Computer computer;

        public StartCommand(Computer comp)
        {
            computer = comp;
        }

        public void Execute()
        {
            computer.Start();
        }
    }
}