namespace RobotsFromMars
{
    public class ForwardInstruction : IInstruction
    {
        public Position Move(Position position)
        {
            if(position.Orientation == "N")
            {
                position.YAxis++;
            }
            else if(position.Orientation == "E")
            {
                position.XAxis++;
            }
            else if(position.Orientation == "S")
            {
                position.YAxis--;
            }
            else if(position.Orientation == "W")
            {
                position.XAxis--;
            }

            return position;
        }
    }
}
