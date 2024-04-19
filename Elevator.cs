using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorSystem
{
    public class Elevator
    {
        public int CurrentFloor { get; private set; }
        public Direction CurrentDirection { get; private set; }
        public DoorStatus DoorStatus { get; private set; }

        public Elevator()
        {
            CurrentFloor = 1;
            CurrentDirection = Direction.None;
            DoorStatus = DoorStatus.Closed;
        }

        public void MoveToFloor(int targetFloor)
        {
            if (targetFloor < 1 || targetFloor > 5)
            {
                Console.WriteLine("Invalid floor number.");
                return;
            }

            if (targetFloor > CurrentFloor)
                CurrentDirection = Direction.Up;
            else if (targetFloor < CurrentFloor)
                CurrentDirection = Direction.Down;
            else
                CurrentDirection = Direction.None;

            Console.WriteLine($"Elevator moving {CurrentDirection.ToString().ToLower()} to floor {targetFloor}...");
            CurrentFloor = targetFloor;
        }

        public void OpenDoor()
        {
            if (DoorStatus == DoorStatus.Open)
            {
                Console.WriteLine("Door is already open.");
                return;
            }

            Console.WriteLine("Elevator door opening...");
            DoorStatus = DoorStatus.Open;
        }

        public void CloseDoor()
        {
            if (DoorStatus == DoorStatus.Closed)
            {
                Console.WriteLine("Door is already closed.");
                return;
            }

            Console.WriteLine("Elevator door closing...");
            DoorStatus = DoorStatus.Closed;
        }
    }


}
