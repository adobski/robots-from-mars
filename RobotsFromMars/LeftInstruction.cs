using System.Collections.Generic;

namespace RobotsFromMars
{
    public class LeftInstruction : IInstruction
    {
        private readonly IList<string> _orientations;

        public LeftInstruction(IList<string> orientations)
        {
            _orientations = orientations;
        }

        public Position Move(Position position)
        {
            position.Orientation = GetOrientation(position);

            return position; ;
        }

        private string GetOrientation(Position position)
        {
            if (position.Orientation == "N")
            {
                position.Orientation = _orientations[3];
            }
            else
            {
                position.Orientation = _orientations[_orientations.IndexOf(position.Orientation) - 1];
            }

            return position.Orientation;
        }
    }
}
