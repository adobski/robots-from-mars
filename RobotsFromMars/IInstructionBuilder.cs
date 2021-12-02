using System.Collections.Generic;

namespace RobotsFromMars
{
    public interface IInstructionBuilder
    {
        IEnumerable<IInstruction> Create(string instructions);
    }
}
