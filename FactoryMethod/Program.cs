using System;

namespace FactoryMethod
{
// Фабричный метод определяет интерфейс для создания объекта, но оставляет подклассам
//решение о том, какой класс инстанцировать.Фабричный метод это стратегия создания объектов.
    class Program
    {
        static void Main(string[] args)
        {
            Building[] buildings = { new Casern(), new ShootingRange() };
            foreach (Building building in buildings)
            {
                Warrior warrior = building.CreateWarrior();
                warrior.SetReady();
            }
        }
    }
}
