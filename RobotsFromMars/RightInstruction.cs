using System.Collections.Generic;

namespace RobotsFromMars
{
    public class RightInstruction : IInstruction
    {
        private readonly IList<string> _orientations;

        public RightInstruction(IList<string> orientations)
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
            if(position.Orientation == "W")
            {
                position.Orientation = _orientations[0];
            }
            else
            {
                position.Orientation = _orientations[_orientations.IndexOf(position.Orientation) + 1];
            }

            return position.Orientation;
        }
    }
}
