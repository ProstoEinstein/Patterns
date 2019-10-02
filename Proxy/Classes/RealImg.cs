using Proxy.Interfaces;

namespace Proxy.Classes
{
    sealed class RealImg : IImage
    {
        string file;

        public RealImg(string file)
        {
            this.file = file;
            Load();
        }

        public void Load()
        {
            System.Console.WriteLine("Загрузка картинки + {0}", file);
        }
        public void Display()
        {
            System.Console.WriteLine("Просмотр картинки + {0}", file);
        }
    }
}