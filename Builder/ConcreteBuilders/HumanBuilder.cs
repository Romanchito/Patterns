using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class HumanBuilder : CharacterBuilder
    {
        private readonly Character character = new Character();
        protected internal override void GenerateAgility()
        {
            character.AddPartOfCharacter("Middle agility");
        }

        protected internal override void GenerateHeigt()
        {
            character.AddPartOfCharacter("Middle height");
        }

        protected internal override void GeneratePower()
        {
            character.AddPartOfCharacter("Middle power");
        }

        protected internal override void GenerateTextType()
        {
            character.AddPartOfCharacter("Human");
        }

        protected internal override void GererateIntellect()
        {
            character.AddPartOfCharacter("Middle intellect");
        }

        protected internal override Character GetResultCharacter()
        {
            return character;
        }
    }
}
