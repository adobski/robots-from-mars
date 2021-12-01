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
    }
}