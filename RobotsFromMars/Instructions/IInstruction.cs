using RobotsFromMars.Entities;

namespace RobotsFromMars.Instructions
{
    public interface IInstruction
    {
        Position Move(Position position);
    }
}
