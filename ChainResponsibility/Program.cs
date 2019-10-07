using System.Threading;
using System;
using ChainResponsibility.Classes;

namespace ChainResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new SMSLogger(Level.Erorr);

            logger.Next = new FileLogger(Level.Debug);
            logger.Next = new EmailLogger(Level.Info);
            
            logger.WriteMessage("Всё хорошо", Level.Info);
            logger.WriteMessage("Идёт режим отладки", Level.Debug);
            logger.WriteMessage("Ошибка !", Level.Erorr);
            
        }
    }
}
