using System;
using System.Collections.Generic;
using System.Text;

//Главными недостатками синглтонов считаются невозможность юнит-тестирования классов, 
//которые пользуются услугами синглтона,и низкая гибкость.
//В оригинальном описании паттерна «Синглтон» «бандой четырех» . От класса Singleton можно порождать подклассы,
//и приложение легко можно сконфигурировать экземпляром расширенного класса.
//Можно конкретизировать приложение экземпляром того класса, который необходим во время исполнения.
//Использование данного аспекта приводит к вариации синглтона, называемой Ambient Context


namespace Singleton.AmbientContext
{
    public class GlobalLogger
    {
        private static ILogger _logger = new DefaultLogger();
        public static ILogger Logger
        {
            get { return _logger; }
            internal set { _logger = value; }
        } 
    }
}
