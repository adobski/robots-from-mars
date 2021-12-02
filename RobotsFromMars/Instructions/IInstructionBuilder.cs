using System.Collections.Generic;

namespace RobotsFromMars.Instructions
{
    public interface IInstructionBuilder
    {
        IEnumerable<IInstruction> Create(string instructions);
    }
}
