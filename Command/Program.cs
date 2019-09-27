using System;
using Command.Commands;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            User user = new User(new StartCommand(computer), new StopCommand(computer), new ResetCommand(computer));


            user.StartComputer();
            user.StopComputer();
            user.ResetComputer();
        }
    }
}
