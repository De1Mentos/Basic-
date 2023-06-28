using System;

namespace C__Pack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an exercise (1-2):");
            int exerciseNumber = int.Parse(Console.ReadLine());

            switch (exerciseNumber)
            {
                case 1:
                    Exercise1();
                    break;
                case 2:
                    Exercise2();
                    break;
            }
        }

        static void Exercise1()
        {
            Console.WriteLine("Exercise 1");

            Console.WriteLine("Starting Tic-Tac-Toe game...");
            TicTacToeGame.StartGame();
        }

        static void Exercise2()
        {
            Console.WriteLine("Exercise 2");
        }
    }

    public class TicTacToeGame
    {
        private static char[,] board = new char[3, 3];
        private static bool gameOver = false;
        private static char currentPlayer;

        public static void StartGame()
        {
            InitializeBoard();
            Random random = new Random();
            int startingPlayer = random.Next(2);
            currentPlayer = startingPlayer == 0 ? 'X' : 'O';

            while (!gameOver)
            {
                DrawBoard();
                MakeMove();
                CheckGameOver();
                SwitchPlayer();
            }
        }

        private static void InitializeBoard()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    board[row, col] = '-';
                }
            }
        }

        private static void DrawBoard()
        {
            Console.Clear();
            Console.WriteLine("-------------");
            for (int row = 0; row < 3; row++)
            {
                Console.Write("| ");
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(board[row, col] + " | ");
                }
                Console.WriteLine("\n-------------");
            }
        }

        private static void MakeMove()
        {
            bool validMove = false;
            while (!validMove)
            {
                Console.WriteLine("Player {0}'s turn. Enter row (0-2):", currentPlayer);
                int row = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter column (0-2):");
                int col = int.Parse(Console.ReadLine());

                if (row >= 0 && row < 3 && col >= 0 && col < 3 && board[row, col] == '-')
                {
                    board[row, col] = currentPlayer;
                    validMove = true;
                }
                else
                {
                    Console.WriteLine("Invalid move! Please try again.");
                }
            }
        }

        private static void CheckGameOver()
        {
            if (CheckWin())
            {
                Console.WriteLine("Player {0} wins!", currentPlayer);
                gameOver = true;
            }
            else if (CheckTie())
            {
                Console.WriteLine("It's a tie!");
                gameOver = true;
            }
        }

        private static bool CheckWin()
        {
            for (int row = 0; row < 3; row++)
            {
                if (board[row, 0] != '-' && board[row, 0] == board[row, 1] && board[row, 1] == board[row, 2])
                {
                    return true;
                }
            }

            for (int col = 0; col < 3; col++)
            {
                if (board[0, col] != '-' && board[0, col] == board[1, col] && board[1, col] == board[2, col])
                {
                    return true;
                }
            }

            if (board[0, 0] != '-' && board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return true;
            }

            if (board[0, 2] != '-' && board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                return true;
            }

            return false;
        }

        private static bool CheckTie()
        {
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (board[row, col] == '-')
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static void SwitchPlayer()
        {
            currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
        }
    }
}