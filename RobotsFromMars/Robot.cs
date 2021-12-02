using RobotsFromMars.Entities;
using RobotsFromMars.Instructions;
using System.Collections.Generic;

namespace RobotsFromMars
{
    public class Robot
    {
        private Position _position;

        public void SetGridPosition(int x, int y, string orientation)
        {
            _position = new Position(y, x, orientation);
        }

        public void Move(IEnumerable<IInstruction> instructions)
        {
            foreach(var instruction in instructions)
            {
                _position = instruction.Move(_position);
            }
        }

        public string Output()
        {
            return $"{_position.XAxis} {_position.YAxis} {_position.Orientation}";
        }
    }
}
