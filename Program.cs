using System;

namespace SnakeLadderProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            const int START_POSITION = 0;
            int dieNum = RandomNumber();
            Console.WriteLine("Die Number is: {0}", dieNum);
        }

        //returns 1 to 6, rolling of a die
        static int RandomNumber()
        {
            Random randObj = new Random();
            return randObj.Next(1, 7);
        }
    }
}
