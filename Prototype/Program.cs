using System;

namespace Prototype
{
    //Паттерн Прототип поручает создание копий самим копируемым объектам.Он вводит общий интерфейс для всех объектов, 
    //поддерживающих клонирование. Это позволяет копировать объекты, не привязываясь к их конкретным классам.
    //Обычно такой интерфейс имеет всего один метод clone.
    class Program
    {
        static void Main(string[] args)
        {
            IHumanClonable human = new Human("Mark", "Blaston", 12);
            IHumanClonable cloneedHuman = human.Clone();
            human.GetHumanInfo();
            cloneedHuman.GetHumanInfo();

            Console.WriteLine();

            human = new Human("Jhon", "Wick", 42);
            cloneedHuman = human.Clone();
            human.GetHumanInfo();
            cloneedHuman.GetHumanInfo();

        }
    }
}
