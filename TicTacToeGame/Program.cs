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
        }
    }


