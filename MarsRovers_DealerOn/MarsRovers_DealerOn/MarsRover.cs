namespace MarsRovers_DealerOn
{
    /// <summary>
    /// MarsRover class.
    /// </summary>
    public class MarsRover
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Heading { get; set; }

        /// <summary>
        /// MarsRover class constructor.
        /// </summary>
        /// <param name="x">x position of the rover</param>
        /// <param name="y">y position of the rover</param>
        /// <param name="heading">rover's initial heading</param>
        public MarsRover(int x, int y, char heading)
        {
            X = x;
            Y = y;
            Heading = heading;
        }

        /// <summary>
        /// TurnLeft instruction. Changing the direction of rover when the nstruction is 'L'
        /// </summary>
        public void TurnLeft()
        {
            switch (Heading)
            {
                case 'N':
                    Heading = 'W';
                    break;
                case 'E':
                    Heading = 'N';
                    break;
                case 'S':
                    Heading = 'E';
                    break;
                case 'W':
                    Heading = 'S';
                    break;
            }
        }

        /// <summary>
        /// TurnRight instruction. Changing the direction of rover when the nstruction is 'R'
        /// </summary>
        public void TurnRight()
        {
            switch (Heading)
            {
                case 'N':
                    Heading = 'E';
                    break;
                case 'E':
                    Heading = 'S';
                    break;
                case 'S':
                    Heading = 'W';
                    break;
                case 'W':
                    Heading = 'N';
                    break;
            }
        }

        /// <summary>
        /// Increasing the position of rover when the instruction is 'M'
        /// </summary>
        public void Move()
        {
            switch (Heading)
            {
                case 'N':
                    Y++;
                    break;
                case 'E':
                    X++;
                    break;
                case 'S':
                    Y--;
                    break;
                case 'W':
                    X--;
                    break;
            }
        }

        public override string ToString()
        {
            return $"{X} {Y} {Heading}";
        }
    }

}
