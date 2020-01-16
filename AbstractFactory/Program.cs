using System;

namespace AbstractFactory
{
    //Абстрактная фабрика задаёт интерфейс создания всех доступных типов продуктов, 
    //а каждая конкретная реализация фабрики порождает продукты одной из вариаций.
    class Program
    {
        static void Main(string[] args)
        {
            new Client().TestMethod();
        }
    }
}
