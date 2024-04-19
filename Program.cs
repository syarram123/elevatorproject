using ElevatorSystem;

class Program
{
    static void Main(string[] args)
    {
        ElevatorControlSystem controlSystem = new ElevatorControlSystem();

        controlSystem.CallElevator(5);
        controlSystem.CallElevator(1);


        controlSystem.PressFloorButton(2);
        controlSystem.PressFloorButton(4);
    }
}
