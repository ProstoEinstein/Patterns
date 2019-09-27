namespace Command
{
    sealed class Computer
    {
        void Start()
        {
            System.Console.WriteLine("Start");
        }

        void Stop()
        {
            System.Console.WriteLine("Stop");
        }

        void Reset()
        {
            System.Console.WriteLine("Reset");
        }
    }
}