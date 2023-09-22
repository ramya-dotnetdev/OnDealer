using MarsRovers_DealerOn;

public class Program
{
    /// <summary>
    /// Start of the application.
    /// </summary>
    public static void Main()
    {
        // Get plateau size from user:
        Console.WriteLine("Enter plateau size (format: X Y):");
        string[] plateauSizeInput = Console.ReadLine().Split(' ');
        int plateauX = int.Parse(plateauSizeInput[0]);
        int plateauY = int.Parse(plateauSizeInput[1]);

        // Get rover positions and instructions from user
        List<MarsRover> rovers = new List<MarsRover>();
        List<string> instructions = new List<string>();

        Console.WriteLine("Enter rover positions and instructions (format: X Y Z Instructions):");
        Console.WriteLine("Example: 1 2 N LMLMLMLMM (case sensitive)");
        Console.WriteLine("Type 'done' when finished.");
        string input;
        while ((input = Console.ReadLine()).ToLower() != "done")
        {
            string[] inputParts = input.Split(' ');
            int x = int.Parse(inputParts[0]);
            int y = int.Parse(inputParts[1]);
            char heading = char.Parse(inputParts[2]);
            string instruction = inputParts[3];

            if (x > plateauX || y > plateauY)
            {
                Console.WriteLine("Rover's initial position is outside of plateau X & Y");
                break;
            }

            rovers.Add(new MarsRover(x, y, heading));
            instructions.Add(instruction);
        }

        try
        {
            for (int i = 0; i < rovers.Count; i++)
            {
                foreach (char instruction in instructions[i])
                {
                    switch (instruction)
                    {
                        case 'L':
                            rovers[i].TurnLeft();
                            break;
                        case 'R':
                            rovers[i].TurnRight();
                            break;
                        case 'M':
                            rovers[i].Move();
                            break;
                    }
                }
                Console.WriteLine("Rover's final position after the instruction " + instructions[i] + " : " + rovers[i].ToString());
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Program|Main()|Exception while processing the instructions: " + e.Message + ". InnerException: " + e.InnerException + ". StackTrace: " + e.StackTrace);
        }
    }
}