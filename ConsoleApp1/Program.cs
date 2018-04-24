using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace ConsoleApp1
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main()
        {
            logger.Info("Начинаем запуск приложения");
            try
            {
                throw new Exception("Упс");
            }
            catch (Exception exeption)
            {
                logger.Error(exeption, "Ошибка запуска приложения");
            }
            LogManager.Flush();
        }
    }
}
