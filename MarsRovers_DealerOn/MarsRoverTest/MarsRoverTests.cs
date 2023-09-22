using MarsRovers_DealerOn;

namespace MarsRoverTest
{
    [TestClass]
    public class MarsRoverTests
    {
        [TestMethod]
        public void TestMarsRoverMovement()
        {
            int plateauX = 5;
            int plateauY = 5;

            List<MarsRover> rovers = new List<MarsRover>
        {
            new MarsRover(1, 2, 'N'),
            new MarsRover(3, 3, 'E')
        };

            List<string> instructions = new List<string>
        {
            "LMLMLMLMM",
            "MMRMMRMRRM"
        };

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
            }

            Assert.AreEqual("1 3 N", rovers[0].ToString());
            Assert.AreEqual("5 1 E", rovers[1].ToString());
        }

        [TestMethod]
        public void TestMarsRoverCollision()
        {
            int plateauX = 5;
            int plateauY = 5;

            List<MarsRover> rovers = new List<MarsRover>
        {
            new MarsRover(1, 2, 'N'),
            new MarsRover(3, 3, 'E'),
            new MarsRover(2, 3, 'S')
        };

            List<string> instructions = new List<string>
        {
            "M",
            "M",
            "M"
        };

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
            }

            Assert.AreEqual("1 3 N", rovers[0].ToString());
            Assert.AreEqual("4 3 E", rovers[1].ToString());
            Assert.AreEqual("2 2 S", rovers[2].ToString());
        }
    }
}