using System.Collections.Generic;

namespace RobotsFromMars
{
    public class InstructionBuilder : IInstructionBuilder
    {
        private IList<IInstruction> _instructions;

        public InstructionBuilder(IList<IInstruction> instructions)
        {
            _instructions = instructions;
        }

        public IEnumerable<IInstruction> Create(string instructions)
        {
            switch(instructions)
            {
                case "F":
                    _instructions.Add(new ForwardInstruction());
                    break;
                case "R":
                    _instructions.Add(new RightInstruction());
                    break;
                case "L":
                    _instructions.Add(new LeftInstruction());
                    break;
            }
            
            return _instructions;
        }
    }
}
