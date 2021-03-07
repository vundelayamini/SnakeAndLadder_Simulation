using System;

namespace snakeAndLadder
{
    class Program
    {
        public const int START_POSSITION = 0;
        public const int END_POSSITION = 100;
        public const int NO_PLAY = 0;
        public const int SNAKE = 1;
        public const int LADDER = 2;
        string player1 = Console.ReadLine();
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string player1 = Console.ReadLine();
            int currentPositionOfPlayer = START_POSSITION;
            for (int noOfTimesRoll = 1; currentPositionOfPlayer < 100; noOfTimesRoll++)
            {
                int rollDice = RollDice();
                Console.WriteLine("You rolled: " + rollDice);
                currentPositionOfPlayer = PlayerMovement(rollDice, currentPositionOfPlayer);
                Console.WriteLine("Your Current position: " + currentPositionOfPlayer);
                Console.WriteLine("you rolled you dice total time from stating::" + noOfTimesRoll);

                if (currentPositionOfPlayer == 100)
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                Console.ReadLine();
            }
        }
        static int RollDice()
        {
            Random random = new Random();
            int diceNumber = random.Next(1, 7);
            return diceNumber;
        }
        static int PlayerMovement(int numbRolled, int playerpossition)
        {
            Random random = new Random();
            int move = random.Next(0, 3);
            switch (move)
            {
                case NO_PLAY:
                    Console.WriteLine("No _Play");
                    break;
                case SNAKE:
                    Console.WriteLine("snake");
                    if (playerpossition - numbRolled >= 0)
                    {
                        playerpossition = playerpossition - numbRolled;
                        break;
                    }
                    else
                    {
                        playerpossition = START_POSSITION;
                        break;
                    }
                case LADDER:
                    Console.WriteLine("Ladder");
                    if (playerpossition + numbRolled <= 100)
                    {
                        playerpossition = playerpossition + numbRolled;
                        break;
                    }
                    else
                        break;
            }
            return playerpossition;

        }
    }
}

