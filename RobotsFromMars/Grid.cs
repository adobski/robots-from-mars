using System.Collections.Generic;

namespace RobotsFromMars
{
    public class Grid
    {
        public Grid(IList<Robot> robots)
        {
            XMax = 50;
            YMax = 50;

            Robots = robots;
        }

        public void AddRobot(Robot robot)
        {
            Robots.Add(robot);
        }

        public int XMax { get; private set; }  
        public int YMax { get; private set; }
        public IList<Robot> Robots { get; private set; }
    }
}
