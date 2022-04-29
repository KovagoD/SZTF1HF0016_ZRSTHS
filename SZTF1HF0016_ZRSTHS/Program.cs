using System.IO;

namespace SZTF1HF0016_ZRSTHS
{
    enum Direction { North, South, West, East }
    class Robot
    {
        char[] instructions;
        int X;
        int Y;
        Direction direction;

        public Robot(string path)
        {
            string[] lines = File.ReadAllLines(path);
            instructions = new char[lines[0].Length];
            for (int i = 0; i < lines[0].Length; i++)
            {
                instructions[i] = lines[0][i];
            }

            StartSimulation();
        }

        void StartSimulation()
        {
            X = 0;
            Y = 0;
            direction = Direction.North;

            for (int i = 0; i < instructions.Length; i++)
            {
                Move(instructions[i]);
            }

            File.WriteAllText("output.txt", $"[{X},{Y}]");
        }

        public int[] Move(char instruction)
        {
            if (instruction == '.')
            {
                int[] coords = GetCoordinate();
                X = coords[0];
                Y = coords[1];
            }
            else if (instruction == '>') { direction = GetDirection(instruction); }
            else if (instruction == '<') { direction = GetDirection(instruction); }
            return null;
        }

        Direction GetDirection(char instruction)
        {
            Direction tmpDirection = direction;
            if (direction == Direction.North)
            {
                if (instruction == '>') { tmpDirection = Direction.East; }
                else if (instruction == '<') { tmpDirection = Direction.West; }
            }
            else if (direction == Direction.South)
            {
                if (instruction == '>') { tmpDirection = Direction.West; }
                else if (instruction == '<') { tmpDirection = Direction.East; }
            }
            else if (direction == Direction.West)
            {
                if (instruction == '>') { tmpDirection = Direction.North; }
                else if (instruction == '<') { tmpDirection = Direction.South; }
            }
            else if (direction == Direction.East)
            {
                if (instruction == '>') { tmpDirection = Direction.South; }
                else if (instruction == '<') { tmpDirection = Direction.North; }
            }

            return tmpDirection;
        }

        public int[] GetCoordinate()
        {
            int[] tmp = new int[] { X, Y };

            if (direction == Direction.North) { tmp[1]++; }
            else if (direction == Direction.South) { tmp[1]--; }
            else if (direction == Direction.East) { tmp[0]++; }
            else if (direction == Direction.West) { tmp[0]--; }

            return tmp;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot("input.txt");
        }
    }
}
