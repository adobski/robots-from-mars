using FluentAssertions;
using NUnit.Framework;
using RobotsFromMars;
using System.Collections.Generic;

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
            var grid = new Grid(new List<Robot>());

            grid.XMax
                .Should()
                .Be(50);
        }

        [Test]
        public void Grid_has_a_y_axis_of_50_Test()
        {
            var grid = new Grid(new List<Robot>());

            grid.YMax
                .Should()
                .Be(50);
        }

        [Test]
        public void Can_add_one_robot_to_the_grid_Test()
        {
            var grid = new Grid(new List<Robot>());

            grid.AddRobot(new Robot());

            grid.Robots.Count
                .Should()
                .Be(1);
        }
        
        [Test]
        public void Can_add_many_robots_to_the_grid_Test()
        {
            var grid = new Grid(new List<Robot>());

            grid.AddRobot(new Robot());
            grid.AddRobot(new Robot());
            grid.AddRobot(new Robot());

            grid.Robots.Count
                .Should()
                .Be(3);
        }

        [Test]
        public void Can_add_robot_on_grid_at_set_position_Test()
        {
            var grid = new Grid(new List<Robot>());

            var robot = new Robot();
            robot.SetGridPosition(5, 5, "N");
            grid.AddRobot(robot);

            grid.Robots[0]
                .Output()
                .Should()
                .Be("5 5 N");
        }
    }
}