using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Runtime.CompilerServices;

namespace TicTacToeGame
{
    public class Program
    {
        const int HEAD = 0;
        const int TAILS = 1;
        public enum User { Player, Computer };
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TicTacToe Game");
            char[] board = BoardCreation();
            showBoard(board);
            int playerMove = getPlayerMove(board);
            char playerLetter = choosePlayerLetter();
            makingMove(board, playerMove, playerLetter);
            User user = getStartingFirst();
             Console.WriteLine("Check if Won " + Winner(board, playerLetter));
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
        private static char choosePlayerLetter()
        {
            Console.WriteLine("Choose Letter: ");
            string playerLetter = Console.ReadLine();
            return char.ToUpper(playerLetter[0]);
        }
        private static void showBoard(char[] board)
        {
            Console.WriteLine("\n " + board[1] + " | " + board[2] + " | " + board[3]);
            Console.WriteLine("----");
            Console.WriteLine("\n " + board[4] + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("----");
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
        public static void makingMove(char[] board, int index, char letter)
        {
            bool Free = isFree(board, index);
            if
              (Free) board[index] = letter;
            else
            {
                Console.WriteLine("Try again");
            }
        }
        private static User getStartingFirst()
        {
            int toss = getRandomChoice(2);
             return (toss == HEAD) ? User.Player : User.Computer;
        }
        private static int getRandomChoice(int choice)
        {
            Random random = new Random();
            return (int)(random.Next() * 10) % choice;
        }
        public static bool Winner(char[] b, char ch)
        {
            return ((b[1] == ch && b[2] == ch && b[3] == ch) ||
                      (b[4] == ch && b[5] == ch && b[6] == ch)  || 
                      (b[7] == ch && b[8] == ch && b[9] == ch)  || 
                      (b[1] == ch && b[4] == ch && b[7] == ch)  ||
                      (b[2] == ch && b[5] == ch && b[8] == ch)  ||
                      (b[3] == ch && b[6] == ch && b[9] == ch)  ||
                      (b[1] == ch && b[5] == ch && b[9] == ch)  ||
                      (b[7] == ch && b[5] == ch && b[3] == ch));

        }
        private static int getComputerMove(char[] board, char computerLetter, char playerLetter)
        {
            int winningMove = getWinningMove(board, computerLetter);
            if (winningMove != 0) return winningMove;
            int userWinningMove = getWinningMove(board, playerLetter);
            if (userWinningMove != 0) return userWinningMove;
             int[] cornerMoves = { 1, 3, 7, 9 };
            int computerMove = getRandomMoveFromList(board, cornerMoves);
            if (computerMove != 0) return computerMove;
            return 0;
        }
        private static int getWinningMove(char[] board, char letter)
        {
            for(int index = 1; index<board.Length; index++)
            {
                char[] copyOfBoard = getCopyOfBoard(board);
                if(isFree(copyOfBoard, index))
                {
                    makingMove(copyOfBoard, index, letter);
                    if (Winner(copyOfBoard, letter))
                        return index;
                }
            }
            return 0;
        }
        private static char[] getCopyOfBoard(char[] board)
        {
            char[] boardCopy = new char[10];
            getCopyOfBoard(boardCopy);
            return boardCopy;
        }

        private static int getRandomMoveFromList(char[] board, int[] moves)
        {
          for(int index =0;index<moves.Length; index++)
            {
                if (isFree(board, moves[index])) return moves[index];
            }
            return 0;
        }
    }
}


        
        

