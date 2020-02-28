using System;
using Xunit;
using MarsRover_Sample;
namespace MarsRover_XUnitTests
{
    public class IsRover
    {
        [Fact]
        public void TurnLeft()
        {
            Rover rover = new Rover("1 2 N");
            rover.TurnLeft();
            Assert.Equal("W", rover.direction);
        }
        [Fact]
        public void TurnRight()
        {
            Rover rover = new Rover("1 2 N");
            rover.TurnRight();
            Assert.Equal("E", rover.direction);
        }
        [Fact]
        public void MoveForward()
        {
            Rover rover = new Rover("1 2 N");
            rover.MoveForward();
            Assert.Equal(3, rover.y);
        }
        [Fact]
        public void GoToLocation()
        {
            //Rover rover = new Rover("1 2 N");
            Rover rover = new Rover("3 3 E");
            //rover.GoToLocation("LMLMLMLMM");
            rover.GoToLocation("MMRMMRMRRM");
            //Assert.Equal("1 3 N", rover.x + " " + rover.y + " " + rover.direction);
            Assert.Equal("5 1 E", rover.x + " " + rover.y + " " + rover.direction);
        }
    }
}
