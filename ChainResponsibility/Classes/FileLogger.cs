
namespace ChainResponsibility.Classes
{
    sealed class FileLogger : Logger
    {
        public FileLogger(int priority) : base(priority)
        {
        }

        protected override void Write(string message)
        {
            System.Console.WriteLine("Записываем в файл: {0}", message);
        }
    }
}