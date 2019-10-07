namespace ChainResponsibility.Classes
{
    sealed class EmailLogger : Logger
    {
        public EmailLogger(int priority) : base(priority)
        {
        }

        protected override void Write(string message)
        {
            System.Console.WriteLine("Email: {0}", message);
        }
    }
}