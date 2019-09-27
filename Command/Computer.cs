namespace Command
{
    sealed class Computer
    {
        public void Start()
        {
            System.Console.WriteLine("Start");
        }

        public void Stop()
        {
            System.Console.WriteLine("Stop");
        }

        public void Reset()
        {
            System.Console.WriteLine("Reset");
        }
    }
}