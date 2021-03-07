using System;

namespace snakeAndLadder
{
    class Program
    {
        public const int NO_OF_PLAYERS = 1;
        public const int START_POSSITION = 0;
        public const int WINNING_POSSITION = 100;
        public const int NO_PLAY = 0;
        public const int SNAKE = 1;
        public const int LADDER = 2;

        static void Main(string[] args)
        {
            int currPosition = STARTING_POSITION;
            int moves = 0;
            Console.WriteLine("Enter your name:");
            Console.WriteLine("Player is at the currently starting position");

            while (currentPosition != WINNING_POSSITION)
            {
                Random random = new Random();
                int diceValue = random.Next(1, 7);
                Console.WriteLine("Player rolled : " + diceValue);
                int actionTaken = random.Next(0, 3);
                if (actionTaken == NO_PLAY)
                {
                    Console.WriteLine("No action taken");
                }
                else if (actionTaken == LADDER)
                {
                    currPosition += diceValue;
                    if (currentPosition > WINNING_POSITION)
                    {
                        currentPosition -= diceValue;
                    }
                }
                else
                {
                    currentPosition -= diceValue;
                    if (currentPosition < STARTING_POSITION)
                    {
                        currentPosition = STARTING_POSITION;
                    }
                }
                moves++;
                Console.WriteLine(" The Player is at position is : " + currentPosition);
            }
            Console.WriteLine("Player reaches exact winning position in : " + moves + " moves");

        }
    }
}

