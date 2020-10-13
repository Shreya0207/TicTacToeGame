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
            char playerLetter = choosePlayerLetter();
            showBoard(board);
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
            public static char choosePlayerLetter()
            {
                Console.WriteLine("Choose Letter: ");
                string playerLetter = Console.ReadLine();
                return char.ToUpper(playerLetter[0]);
            }
        private static void showBoard(char[] board)
        {
            Console.WriteLine("\n " + board[1] + " | " + board[2] + " | " + board[3]);
            Console.WriteLine("---");
            Console.WriteLine("\n " + board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("---");
            Console.WriteLine("\n " + board[7] + " | " + board[8] + " | " + board[9]);
        }
        }
    }


