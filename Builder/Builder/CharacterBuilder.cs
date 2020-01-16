using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public abstract class CharacterBuilder
    {
        protected internal virtual void GenerateHeigt() { }
        protected internal virtual void GeneratePower() { }
        protected internal virtual void GenerateAgility() { }
        protected internal virtual void GererateIntellect() { }
        protected internal abstract void GenerateTextType();
        protected internal abstract Character GetResultCharacter();
    }
}
