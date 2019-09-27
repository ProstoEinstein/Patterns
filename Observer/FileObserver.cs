using System;
using System.IO;
using Observer.Interfaces;

namespace Observer
{
    sealed class FileObserver : IObserver
    {
        public void HandleEvent(double temperature, double pressure)
        {
            using (StreamWriter sw = new StreamWriter(@"newFile.txt", true, System.Text.Encoding.Default))
            {
                sw.Write(String.Format("Погода изменилась. Температура {0}, Давление {1}", temperature, pressure));
                sw.WriteLine("");
                sw.Close();
            }
        }
    }
}