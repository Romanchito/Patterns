using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Game
    {
        public void Generate(CharacterBuilder builder)
        {
            builder.GenerateTextType();
            builder.GenerateHeigt();
            builder.GeneratePower();
            builder.GenerateAgility();
            builder.GererateIntellect();
        }
    }
}
