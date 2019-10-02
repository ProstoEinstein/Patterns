using System;
using Proxy.Interfaces;
using Proxy.Classes;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IImage image = new ProxyImg("D:\\1.jpg");
            image.Display();
        }
    }
}
