using Airplane.Models;

namespace Airplane.Services
{
    public interface IReadInputService
    {
        List<KeyValuePair<Movement,int>> ReadCommandsFromFile(string fileName);
    }
    public class ReadInputService: IReadInputService
    {
        public List<KeyValuePair<Movement, int>> ReadCommandsFromFile(string fileName)
        {
            var commands = new List<KeyValuePair<Movement, int>>();
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    string[] input = line.Split(' ');
                    commands.Add(KeyValuePair.Create(ParseMovement.GetMovement(input[0]), int.Parse(input[1])));
                }
            }
            return commands;
        }


    }
}
