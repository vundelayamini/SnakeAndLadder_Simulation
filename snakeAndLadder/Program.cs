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
            int player1Position = START_POSSITION;
            int player2Position = START_POSSITION;
            bool player1 = true;
            Console.WriteLine("Enter your name:");
            Console.WriteLine("Both Players are at the currently starting position");

            while (player1Possition != WINNING_POSITION && player2Possition != WINNING_POSITION)
            {
                if (player1)
                {
                    Random random = new Random();
                    int diceValue = random.Next(1, 7);
                    Console.WriteLine("Player rolled : " + diceValue);
                    int actionTaken = random.Next(0, 3);
                   if (actionTaken == NO_PLAY)
                   {
                        player1 = false;
                   }
                   else if (actionTaken == LADDER)
                   {
						player1Pos += diceValue;
						if (player1Possition > WINNING_POSITION)
						{
							player1Possition = diceValue;
						}
					}
					else
					{
						player1 = false;
						player1Possition = diceValue;
						if (player1Possition < START_POSITION)
						{
							player1Possition = START_POSITION;
						}
					}
				}
				else
				{
					Random random = new Random();
					int diceValue = random.Next(1, 7);
					Console.WriteLine("Player rolled : " + diceValue);
					int actionTaken = random.Next(0, 3);
					if (actionTaken == NO_PLAY)
					{
						player1 = true;
					}
					else if (actionTaken == LADDER)
					{
						player2Possition += diceValue;
						if (player2Possition > 100)
						{
							player2Possition = diceValue;
						}
					}
					else
					{
						player1 = true;
						player2Possition = diceValue;
						if (player2Possition < START_POSITION)
						{
							player2Possition = START_POSITION;
						}
					}
				}
			}
			if (player1Possiton == WINNING_POSITION)
			{
				Console.WriteLine("Player 1 won the game");
			}
			else
			{
				Console.WriteLine("Player 2 won the game");
			}


		}
    }
}

