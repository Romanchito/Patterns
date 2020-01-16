using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public class Human : IHumanClonable
    {
        string name , surname;
        int age;

        public Human(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public IHumanClonable Clone()
        {
            return new Human(this.name, this.surname, this.age);
        }

        public void GetHumanInfo()
        {
            Console.WriteLine($"{name} {surname} age: {age} ");
        }
    }
}
