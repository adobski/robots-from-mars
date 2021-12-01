using FluentAssertions;
using NUnit.Framework;
using RobotsFromMars;

namespace RobotsFromMarsTests
{
    public class GridTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Grid_is_has_an_x_axis_of_50_Test()
        {
            var grid = new Grid();

            grid.XMax
                .Should()
                .Be(50);
        }

        [Test]
        public void Grid_has_a_y_axis_of_50_Test()
        {
            var grid = new Grid();

            grid.YMax
                .Should()
                .Be(50);
        }

        [Test]
        public void Can_add_one_robot_to_the_grid_Test()
        {
            var grid = new Grid();

            grid.AddRobot(new Robot());

            grid.Robots.Count
                .Should()
                .Be(1);
        }
        
        [Test]
        public void Can_add_many_robots_to_the_grid_Test()
        {
            var grid = new Grid();

            grid.AddRobot(new Robot());
            grid.AddRobot(new Robot());
            grid.AddRobot(new Robot());

            grid.Robots.Count
                .Should()
                .Be(3);
        }
    }
}