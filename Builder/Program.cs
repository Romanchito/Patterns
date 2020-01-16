using System;
using System.Collections.Generic;

namespace Builder
{
    //Паттерн Строитель предлагает вынести конструирование объекта за пределы его собственного класса, 
    //поручив это дело отдельным объектам, называемым строителями.
    class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game();

            CharacterBuilder humanBuilder = new HumanBuilder();
            CharacterBuilder orcBuilder = new OrcBuilder();
            CharacterBuilder elfBuilder = new ElfBuilder();

            List<Character> charaters = new List<Character>();


            charaters.Add(CreateCharacter(humanBuilder, game));
            charaters.Add(CreateCharacter(orcBuilder, game));
            charaters.Add(CreateCharacter(elfBuilder, game));

            foreach (Character character in charaters)
            {
                Console.WriteLine();
                character.Show();
            }
        }

        private static Character CreateCharacter(CharacterBuilder builder, Game game)
        {
            game.Generate(builder);
            return builder.GetResultCharacter();
        }
    }
}
