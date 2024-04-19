
using NUnit.Framework;
using ElevatorSystem;
namespace ElevatorControlSystemTests
{
    [TestFixture]
    public class ElevatorControlSystemTests
    {
        private ElevatorControlSystem _controlSystem;

        [SetUp]
        public void SetUp()
        {
            _controlSystem = new ElevatorControlSystem();
        }

        [Test]
        public void CallElevator_ShouldMoveToSpecifiedFloor_AndOpenAndCloseDoor()
        {
            // Arrange
            int floor = 3;

            // Act
            _controlSystem.CallElevator(floor);

            // Assert
            Assert.That(_controlSystem.Elevator.CurrentFloor, Is.EqualTo(floor));
            Assert.That(_controlSystem.Elevator.DoorStatus, Is.EqualTo(DoorStatus.Closed));
        }

        [Test]
        public void PressFloorButton_ShouldMoveToSpecifiedFloor_AndOpenAndCloseDoor()
        {
            // Arrange
            int targetFloor = 4;

            // Act
            _controlSystem.PressFloorButton(targetFloor);

            // Assert
            Assert.That(_controlSystem.Elevator.CurrentFloor, Is.EqualTo(targetFloor));
            Assert.That(_controlSystem.Elevator.DoorStatus, Is.EqualTo(DoorStatus.Closed));
        }

        [Test]
        public void CallElevator_WithInvalidFloor_ShouldNotMoveElevator_AndNotOpenDoor()
        {
            // Arrange
            int invalidFloor = 6;

            // Act
            _controlSystem.CallElevator(invalidFloor);

            // Assert
            Assert.That(_controlSystem.Elevator.CurrentFloor, Is.Not.EqualTo(invalidFloor));
            Assert.That(_controlSystem.Elevator.DoorStatus, Is.EqualTo(DoorStatus.Closed));
        }

        [Test]
        public void PressFloorButton_WithInvalidFloor_ShouldNotMoveElevator_AndNotOpenDoor()
        {
            // Arrange
            int invalidFloor = 0;

            // Act
            _controlSystem.PressFloorButton(invalidFloor);

            // Assert
            Assert.That(_controlSystem.Elevator.CurrentFloor, Is.Not.EqualTo(invalidFloor));
            Assert.That(_controlSystem.Elevator.DoorStatus, Is.EqualTo(DoorStatus.Closed));
        }
    }
}
