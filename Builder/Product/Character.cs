using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Character
    {
        private readonly List<string> partsOfCharacter =  new List<string>();

        public void AddPartOfCharacter(string part)
        {
            partsOfCharacter.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("Character parts -------");
            foreach (string part in partsOfCharacter)
            {
                Console.WriteLine(part);
            }
        }

    }
}
