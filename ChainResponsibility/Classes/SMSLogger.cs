namespace ChainResponsibility.Classes
{
    sealed class SMSLogger : Logger
    {
        public SMSLogger(int priority) : base(priority)
        {
        }

        protected override void Write(string message)
        {
            System.Console.WriteLine("SMS: {0}", message);
        }
    }
}