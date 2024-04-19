namespace ElevatorSystem
{
    public class ElevatorControlSystem
    {
        public Elevator Elevator { get; private set; }

        public ElevatorControlSystem()
        {
            Elevator = new Elevator();
        }

        public void CallElevator(int floor)
        {
            if (floor < 1 || floor > 5)
            {
                Console.WriteLine("Invalid floor number.");
                return;
            }

            Elevator.MoveToFloor(floor);
            Elevator.OpenDoor();
            Elevator.CloseDoor();
        }

        public void PressFloorButton(int targetFloor)
        {
            if (targetFloor < 1 || targetFloor > 5)
            {
                Console.WriteLine("Invalid floor number.");
                return;
            }

            Elevator.MoveToFloor(targetFloor);
            Elevator.OpenDoor();
            Elevator.CloseDoor();
        }
    }
}
