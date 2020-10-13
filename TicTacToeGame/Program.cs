using System;

namespace TicTacToeGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game");
            char[] board = boardCreation();
        }
            private static char[] boardCreation()
            {
                char[] board = new char[10];
                for (int i = 0; i < board.Length; i++)
                {
                    board[i] = ' ';
                }
                return board;
            }
        }
    }

