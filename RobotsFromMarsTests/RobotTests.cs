using FluentAssertions;
using NUnit.Framework;
using RobotsFromMars;
using RobotsFromMars.Instructions;
using System.Collections.Generic;

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

        [Test]
        public void Can_move_robot_on_grid_Test()
        {
            var instructionBuilder = new InstructionBuilder(
                new List<IInstruction>(),
                new List<string> { "N", "E", "S", "W" }
            );

            var robot = new Robot();
            robot.SetGridPosition(0, 0, "N");
           
            robot.Output()
                .Should()
                .Be("0 0 N");

            robot.Move(instructionBuilder.Create("FFRFF"));

            robot
                .Output()
                .Should()
                .Be("2 2 E");
        }
    }
}
