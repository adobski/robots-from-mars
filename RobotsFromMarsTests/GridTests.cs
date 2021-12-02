using FluentAssertions;
using NUnit.Framework;
using RobotsFromMars;
using System.Collections.Generic;

namespace RobotsFromMarsTests
{
    public class GridTests
    {
        private Grid _grid;

        [SetUp]
        public void Setup()
        {
            _grid = new Grid(new List<Robot>());
        }

        [Test]
        public void Grid_is_has_an_x_axis_of_50_Test()
        {
            _grid.XMax
                .Should()
                .Be(50);
        }

        [Test]
        public void Grid_has_a_y_axis_of_50_Test()
        {
            _grid.YMax
                .Should()
                .Be(50);
        }

        [Test]
        public void Can_add_one_robot_to_the_grid_Test()
        {
            _grid.AddRobot(new Robot());

            _grid.Robots.Count
                .Should()
                .Be(1);
        }
        
        [Test]
        public void Can_add_many_robots_to_the_grid_Test()
        {
            _grid.AddRobot(new Robot());
            _grid.AddRobot(new Robot());
            _grid.AddRobot(new Robot());

            _grid.Robots.Count
                .Should()
                .Be(3);
        }

        [Test]
        public void Can_add_robot_on_grid_at_set_position_Test()
        {
            var robot = new Robot();
            robot.SetGridPosition(5, 5, "N");
            _grid.AddRobot(robot);

            _grid.Robots[0]
                .Output()
                .Should()
                .Be("5 5 N");
        }

        [Test]
        public void Can_move_robot_across_the_grid_Test()
        {
            var instructionBuilder = new InstructionBuilder(
                new List<IInstruction>(), 
                new List<string> { "N", "E", "S", "W" }
            );

            var robot = new Robot();
            robot.SetGridPosition(0, 0, "N");
            _grid.AddRobot(robot);

            _grid.Robots[0]
                .Output()
                .Should()
                .Be("0 0 N");

            _grid.Robots[0].Move(instructionBuilder.Create("FFRFF"));

            _grid.Robots[0]
                .Output()
                .Should()
                .Be("2 2 E");
        }
    }
}