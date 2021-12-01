namespace RobotsFromMars
{
    public class Robot
    {
        private int _yAxis;
        private int _xAxis;
        private string _orientation;

        public void SetGridPosition(int x, int y, string orientation)
        {
            _xAxis = x;
            _yAxis = y;
            _orientation = orientation;
        }

        public string Output()
        {
            return $"{_xAxis} {_yAxis} {_orientation}";
        }
    }
}
