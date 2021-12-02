namespace RobotsFromMars.Entities
{
    public class Position
    {
        public Position(int yAxis, int xAxis, string orientation)
        {
            YAxis = yAxis;
            XAxis = xAxis;
            Orientation = orientation;
        }

        public int YAxis { get; set; }
        public int XAxis { get; set; }
        public string Orientation { get; set; }
    }
}
