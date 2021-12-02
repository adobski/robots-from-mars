using System.Collections.Generic;

namespace RobotsFromMars
{
    public class InstructionBuilder : IInstructionBuilder
    {
        private IList<IInstruction> _instructions;
        private IList<string> _orientations;

        public InstructionBuilder(
            IList<IInstruction> instructions,
            IList<string> orientations)
        {
            _instructions = instructions;
            _orientations = orientations;
        }

        public IEnumerable<IInstruction> Create(string instructions)
        {
            foreach(char instruction in instructions)
            {
                switch (instruction)
                {
                    case 'F':
                        _instructions.Add(new ForwardInstruction());
                        break;
                    case 'R':
                        _instructions.Add(new RightInstruction(_orientations));
                        break;
                    case 'L':
                        _instructions.Add(new LeftInstruction(_orientations));
                        break;
                }
            }
            
            return _instructions;
        }
    }
}
