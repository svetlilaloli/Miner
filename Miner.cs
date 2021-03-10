using System;
using System.Linq;

namespace Miner
{
    class Miner
    {
        static void Main()
        {
            int fieldSize = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split();
            char[][] field = new char[fieldSize][];
            int[] currentPosition = new int[2];
            int allCoals;
            int coalsCollected = 0;
            bool gameOver = false;
            
            // populate the field
            for (int i = 0; i < fieldSize; i++)
            {
                field[i] = Array.ConvertAll(Console.ReadLine().Split(), char.Parse);
            }

            currentPosition = Start(field);
            allCoals = CoalsCount(field);

            // process the commands
            for (int i = 0; i < commands.Length; i++)
            {
                switch (commands[i])
                {
                    case "left":
                        if (currentPosition[1] - 1 >= 0)
                        {
                            currentPosition[1] -= 1;
                            coalsCollected += CheckNewPosition(ref currentPosition, ref field, ref gameOver);
                        }
                        break;
                    case "right":
                        if (currentPosition[1] + 1 <= fieldSize - 1)
                        {
                            currentPosition[1] += 1;
                            coalsCollected += CheckNewPosition(ref currentPosition, ref field, ref gameOver);
                        }
                        break;
                    case "up":
                        if (currentPosition[0] - 1 >= 0)
                        {
                            currentPosition[0] -= 1;
                            coalsCollected += CheckNewPosition(ref currentPosition, ref field, ref gameOver);
                        }
                        break;
                    case "down":
                        if (currentPosition[0] + 1 <= fieldSize - 1)
                        {
                            currentPosition[0] += 1;
                            coalsCollected += CheckNewPosition(ref currentPosition, ref field, ref gameOver);
                        }
                        break;
                    default:
                        break;
                }
            }

            allCoals -= coalsCollected;

            // output
            if (allCoals == 0)
            {
                Console.WriteLine("You collected all coals! ({0}, {1})", currentPosition[0], currentPosition[1]);
            }
            else if (gameOver)
            {
                Console.WriteLine("Game over! ({0}, {1})", currentPosition[0], currentPosition[1]);
            }
            else
            {
                Console.WriteLine("{0} coals left. ({1}, {2})", allCoals, currentPosition[0], currentPosition[1]);
            }
        }
        private static int[] Start(char[][] field)
        {
            int fieldSize = field.Length;
            int[] startPosition = new int[2];

            for (int i = 0; i < fieldSize; i++)
            {
                if (field[i].Contains('s'))
                {
                    startPosition[0] = i;
                    startPosition[1] = Array.IndexOf(field[i], 's');
                }
            }
            return startPosition;
        }

        private static int CoalsCount(char[][] field)
        {
            int fieldSize = field.Length;
            int coalsCount = 0;

            for (int i = 0; i < fieldSize; i++)
            {
                for (int j = 0; j < fieldSize; j++)
                {
                    if (field[i][j] == 'c')
                    {
                        coalsCount++;
                    }
                }
            }
            return coalsCount;
        }
        private static int CheckNewPosition(ref int[] position, ref char[][] field, ref bool gameOver)
        {
            if (field[position[0]][position[1]] == 'c')
            {
                field[position[0]][position[1]] = '*';
                return 1;
            }
            else if (field[position[0]][position[1]] == 'e')
            {
                gameOver = true;
            }
            return 0;
        }
    }
}
