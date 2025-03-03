
using System;
using System.Text;

class TicTacToe
{
    static char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static char[] players = { 'A', 'B', 'C' };
    static int currentPlayerIndex = 0;

    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        int move;
        bool gameRunning = true;

        while (gameRunning)
        {
            Console.Clear();
            PrintBoard();
            Console.Write($"Гравець {players[currentPlayerIndex]}, оберіть номер клітинки: ");

            if (int.TryParse(Console.ReadLine(), out move) && move >= 1 && move <= 9 && board[move - 1] != 'X' && board[move - 1] != 'O' && board[move - 1] != 'A' && board[move - 1] != 'B' && board[move - 1] != 'C')
            {
                board[move - 1] = players[currentPlayerIndex];
                if (CheckWin())
                {
                    Console.Clear();
                    PrintBoard();
                    Console.WriteLine($"Переміг гравець {players[currentPlayerIndex]}!");
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
                    currentPlayerIndex = (currentPlayerIndex + 1) % players.Length; //Наступний гравець
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
        Console.WriteLine("-----------");
        Console.WriteLine($" {board[3]} | {board[4]} | {board[5]} ");
        Console.WriteLine("-----------");
        Console.WriteLine($" {board[6]} | {board[7]} | {board[8]} ");
    }

    static bool CheckWin()
    {
        int[,] winCombinations =
        {
            {0, 1, 2}, {3, 4, 5}, {6, 7, 8}, // Горизонталі
            {0, 3, 6}, {1, 4, 7}, {2, 5, 8}, // Вертикалі
            {0, 4, 8}, {2, 4, 6}             // Діагоналі
        };

        for (int i = 0; i < winCombinations.GetLength(0); i++)
        {
            if (board[winCombinations[i, 0]] == players[currentPlayerIndex] &&
                board[winCombinations[i, 1]] == players[currentPlayerIndex] &&
                board[winCombinations[i, 2]] == players[currentPlayerIndex])
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
            if (char.IsDigit(c))
            {
                return false;
            }
        }
        return true;
    }
}
