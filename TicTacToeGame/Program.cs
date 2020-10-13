using System;
using System.Runtime.CompilerServices;

namespace TicTacToeGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game");
            char[] board = BoardCreation();
            showBoard(board);
            int playerMove = getPlayerMove(board);
        }
        private static char[] BoardCreation()
        {
            char[] board = new char[10];
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
        private static void showBoard(char[] board)
        {
            Console.WriteLine("\n " + board[1] + " | " + board[2] + " | " + board[3]);
            Console.WriteLine("---");
            Console.WriteLine("\n " + board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("---");
            Console.WriteLine("\n " + board[7] + " | " + board[8] + " | " + board[9]);
        }
        private static int getPlayerMove(char[] board)
        {
            int[] spaces = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            while (true)
            {
                Console.WriteLine("Tell me your next move from 1-9");
                int indexOfBoard = Convert.ToInt32(Console.ReadLine());
                if (Array.Find<int>(spaces, element => element == indexOfBoard) != 0 && isFree(board, indexOfBoard))
                    return indexOfBoard;
            }
        }
        private static bool isFree(char[] board, int index)
        {
            return board[index] == ' ';
        }
    }
}


