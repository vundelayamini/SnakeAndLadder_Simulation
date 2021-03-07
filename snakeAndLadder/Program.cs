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

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string player1 = Console.ReadLine();
            int currentplayerPosition = START_POSSITION;
            for (int noOfTimeDiceRolled = 1; currentplayerPosition >= 0; noOfTimeDiceRolled++)
            {
                int rollDice = RollDice();
                Console.WriteLine("You Rolled:-" + rollDice);
                currentplayerPosition = userMovement(rollDice, currentplayerPosition);
                Console.WriteLine("Your position is:-" + currentplayerPosition);
                if (currentplayerPosition >= 100)
                {
                    Console.WriteLine("GAME OVER");
                    break;
                }
                Console.ReadLine();
            }
        }
        static int RollDice()
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            return randomNumber;
        }
        static int userMovement(int rolledNumber, int playerPosition)
        {
            Random random = new Random();
            int move = random.Next(0, 3);
            switch (move)
            {
                case NO_PLAY:
                    Console.WriteLine("NO PLAY");
                    break;
                case SNAKE:
                    Console.WriteLine("SNAKE");
                    if (playerPosition - rolledNumber >= 0)
                    {
                        playerPosition = playerPosition - rolledNumber;
                        break;
                    }
                    else
                    {
                        playerPosition = START_POSSITION;
                        break;
                    }
                case LADDER:
                    Console.WriteLine("LADDER");
                    playerPosition = playerPosition + rolledNumber;
                    break;
            }
            return playerPosition;



        }
    }
}

