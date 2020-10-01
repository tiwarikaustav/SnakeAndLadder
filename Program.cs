using System;

namespace SnakeLadderProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            const int START_POSITION = 0;
            int currentPosition = START_POSITION;
            int winPosition = 100;
            const int NO_PLAY = 0, SNAKE = 1, LADDER = 2;
            int noOfMoves = 0;
            while (currentPosition < winPosition)
            {
                int dieNum = RandomNumber(7);
                int optionCheck = RandomNumber(3);
                //Console.WriteLine("Die Number is: {0}", dieNum);
                //Console.WriteLine("Option is: {0}", optionCheck);
                switch (optionCheck)
                {
                    case NO_PLAY:
                        break;
                    case SNAKE:
                        currentPosition -= dieNum;
                        if (currentPosition < 0) currentPosition = 0;
                        break;
                    case LADDER:
                        if(currentPosition + dieNum <= winPosition) currentPosition += dieNum;      
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Current position is: {0}", currentPosition);
                noOfMoves++;
            }
            Console.WriteLine("Total Moves to reach destination: {0}", noOfMoves);
        }

        //returns 1 to 6, rolling of a die
        static int RandomNumber(int max)
        {
            Random randObj = new Random();
            return randObj.Next(1, max);
        }
    }
}
