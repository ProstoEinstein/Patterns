using Proxy.Interfaces;

namespace Proxy.Classes
{
    sealed class ProxyImg : IImage
    {
        string file;

        RealImg image;
        public ProxyImg(string file)
        {
            this.file = file;
        }
        
        public void Display()
        {
            if (image == null)
            {
                image = new RealImg(file);
            }
            image.Display();
        }
    }
}