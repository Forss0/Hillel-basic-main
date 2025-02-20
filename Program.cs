

using System;

class TicTacToe
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static char currentPlayer = 'X';

    static void Main()
    {
        bool gameRunning = true;

        while (gameRunning)
        {
            Console.Clear();
            PrintBoard();

            Console.Write($"Гравець {currentPlayer}, оберіть клітинку (1-9): ");
            if (int.TryParse(Console.ReadLine(), out int move) && move >= 1 && move <= 9 && board[move - 1] != 'X' && board[move - 1] != 'O')
            {
                board[move - 1] = currentPlayer;

                if (CheckWin())
                {
                    Console.Clear();
                    PrintBoard();
                    Console.WriteLine($"Переміг гравець {currentPlayer}!");
                    gameRunning = false;
                }
                else if (CheckDraw())
                {
                    Console.Clear();
                    PrintBoard();
                    Console.WriteLine("Нічия!");
                    gameRunning = false;
                }
                else
                {
                    currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                }
            }
            else
            {
                Console.WriteLine("Некоректний хід, спробуйте ще раз.");
                Console.ReadLine();
            }
        }
    }

    static void PrintBoard()
    {
        Console.WriteLine($" {board[0]} | {board[1]} | {board[2]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
        Console.WriteLine("---+---+---");
        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
    }

    static bool CheckWin()
    {
        int[,] winCombinations =
        {
            {0, 1, 2}, {3, 4, 5}, {6, 7, 8}, // Горизонтальні
            {0, 3, 6}, {1, 4, 7}, {2, 5, 8}, // Вертикальні
            {0, 4, 8}, {2, 4, 6}             // Діагоналі
        };

        for (int i = 0; i < winCombinations.GetLength(0); i++)
        {
            if (board[winCombinations[i, 0]] == currentPlayer &&
                board[winCombinations[i, 1]] == currentPlayer &&
                board[winCombinations[i, 2]] == currentPlayer)
            {
                return true;
            }
        }
        return false;
    }

    static bool CheckDraw()
    {
        foreach (char c in board)
        {
            if (c != 'X' && c != 'O') return false;
        }
        return true;
    }
}