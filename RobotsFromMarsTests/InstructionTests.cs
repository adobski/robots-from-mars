using FluentAssertions;
using NUnit.Framework;
using RobotsFromMars;
using System.Collections.Generic;

namespace RobotsFromMarsTests
{
    [TestFixture]
    public class InstructionTests
    {
        [Test]
        public void ForwardInstruction_moves_yaxis_to_1_position_Test()
        {
            var position = new Position(0, 0, "N");

            var forwardInstruction = new ForwardInstruction();
            var newPosition = forwardInstruction.Move(position);

            newPosition.YAxis
                .Should()
                .Be(1);
        }

        [Test]
        public void ForwardInstruction_moves_yaxis_to_0_position_Test()
        {
            var position = new Position(1, 1, "S");

            var forwardInstruction = new ForwardInstruction();
            var newPosition = forwardInstruction.Move(position);

            newPosition.YAxis
                .Should()
                .Be(0);
        }

        [Test]
        public void ForwardInstruction_moves_xaxis_to_1_position_Test()
        {
            var position = new Position(0, 0, "E");

            var forwardInstruction = new ForwardInstruction();
            var newPosition = forwardInstruction.Move(position);

            newPosition.XAxis
                .Should()
                .Be(1);
        }

        [Test]
        public void ForwardInstruction_moves_xaxis_to_0_position_Test()
        {
            var position = new Position(1, 1, "W");

            var forwardInstruction = new ForwardInstruction();
            var newPosition = forwardInstruction.Move(position);

            newPosition.XAxis
                .Should()
                .Be(0);
        }

        [Test]
        public void RightInstruction_moves_to_east_orientation_Test()
        {
            var position = new Position(1, 1, "N");

            var orientations = new List<string> { "N", "E", "S", "W" };

            var rightInstruction = new RightInstruction(orientations);
            var newPosition = rightInstruction.Move(position);

            newPosition.Orientation
                .Should()
                .Be("E");
        }

        [Test]
        public void RightInstruction_moves_to_south_orientation_Test()
        {
            var position = new Position(1, 1, "E");

            var orientations = new List<string> { "N", "E", "S", "W" };

            var rightInstruction = new RightInstruction(orientations);
            var newPosition = rightInstruction.Move(position);

            newPosition.Orientation
                .Should()
                .Be("S");
        }

        [Test]
        public void RightInstruction_moves_to_west_orientation_Test()
        {
            var position = new Position(1, 1, "S");

            var orientations = new List<string> { "N", "E", "S", "W" };

            var rightInstruction = new RightInstruction(orientations);
            var newPosition = rightInstruction.Move(position);

            newPosition.Orientation
                .Should()
                .Be("W");
        }

        [Test]
        public void RightInstruction_moves_to_north_orientation_Test()
        {
            var position = new Position(1, 1, "W");

            var orientations = new List<string> { "N", "E", "S", "W" };

            var rightInstruction = new RightInstruction(orientations);
            var newPosition = rightInstruction.Move(position);

            newPosition.Orientation
                .Should()
                .Be("N");
        }
    }
}
