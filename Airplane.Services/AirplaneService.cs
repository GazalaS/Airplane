using Airplane.Models;

namespace Airplane.Services
{
    public interface IAirplaneService
    {
        int Navigate(string fileName);
    }
    public class AirplaneService : IAirplaneService
    {
        public List<KeyValuePair<Movement,int>> Commands { get; set; }
        public Position Position { get; }
        public IReadInputService ReadInputService { get; }

        public AirplaneService(IReadInputService reader)
        {
            Commands = new List<KeyValuePair<Movement, int>>();
            Position = new Position();
            ReadInputService = reader;
        }

        public int Navigate(string fileName)
        {
            int totalCount = 0;

            Commands = ReadInputService.ReadCommandsFromFile(fileName);
            foreach(KeyValuePair<Movement, int> command in Commands)
            {
                Movement movement = command.Key;
                int steps = command.Value;
                CalculateTotal(movement,steps);
            }

            totalCount = Position.Horizontal * Position.Vertical;
            return totalCount;
        }

        private void CalculateTotal(Movement movement, int steps)
        {
            switch (movement)
            {
                case Movement.forward:
                     if (Position.Horizontal !=0)
                        { 
                            Position.Vertical +=(steps * Position.Direction);
                        }
                        Position.Horizontal += steps;
                    return;
                case Movement.up:
                    Position.Direction += steps;
                    return;
                case Movement.down:
                    Position.Direction -= steps;
                    return;
                default:
                    return;
            }
        }
    }
}