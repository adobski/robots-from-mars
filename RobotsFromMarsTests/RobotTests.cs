using FluentAssertions;
using NUnit.Framework;
using RobotsFromMars;

namespace RobotsFromMarsTests
{
    [TestFixture]
    public  class RobotTests
    {
        [Test]
        public void Set_start_position_for_robot_on_grid_Test()
        {
            var robot = new Robot();

            robot.SetGridPosition(0, 0, "N");

            robot.Output()
                .Should()
                .Be("0 0 N");
        }
    }
}
