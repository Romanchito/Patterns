using System;

namespace FactoryMethod
{
// Фабричный метод определяет интерфейс для создания объекта, но оставляет подклассам
//решение о том, какой класс инстанцировать.Фабричный метод это стратегия создания объектов.
    class Program
    {
        static void Main(string[] args)
        {
           
            Building b = new Casern();
            Warrior warrior = b.CreateWarrior();
            warrior.SetReady();

            b = new ShootingRange();
            warrior = b.CreateWarrior();
            warrior.SetReady();
        }
    }
}
