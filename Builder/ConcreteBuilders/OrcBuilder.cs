using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class OrcBuilder : CharacterBuilder
    {
        private readonly Character character = new Character();
        protected internal override void GenerateAgility()
        {
            character.AddPartOfCharacter("Low agility");
        }

        protected internal override void GenerateHeigt()
        {
            character.AddPartOfCharacter("High height");
        }

        protected internal override void GeneratePower()
        {
            character.AddPartOfCharacter("High power");
        }

        protected internal override void GenerateTextType()
        {
            character.AddPartOfCharacter("ORC");
        }

        protected internal override void GererateIntellect()
        {
            character.AddPartOfCharacter("Low intellect");
        }

        protected internal override Character GetResultCharacter()
        {
            return character;
        }
    }
}
