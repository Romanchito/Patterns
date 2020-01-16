using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class ElfBuilder : CharacterBuilder
    {
        private readonly Character character = new Character();
        protected internal override void GenerateAgility()
        {
            character.AddPartOfCharacter("High agility");
        }

        protected internal override void GenerateHeigt()
        {
            character.AddPartOfCharacter("Middle height");
        }

        protected internal override void GeneratePower()
        {
            character.AddPartOfCharacter("Low power");
        }

        protected internal override void GenerateTextType()
        {
            character.AddPartOfCharacter("ELF");
        }

        protected internal override void GererateIntellect()
        {
            character.AddPartOfCharacter("High intellect");
        }

        protected internal override Character GetResultCharacter()
        {
            return character;
        }
    }
}
