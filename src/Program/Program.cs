using System;
using System.IO;
using System.Text;
using System.Threading;


namespace Game_of_life_2023
{
    public class Program
    {
        static void Main(string[] args)
        {
            string url = @"..\..\assets\board.txt";
            
            bool[,] gameBoard = Input.LoadGameBoard(url);

            
            int boardWidth = gameBoard.GetLength(0);
            int boardHeight = gameBoard.GetLength(1);

            
            while (true)
            {
                // Print game board
                Output.PrintBoard(gameBoard);

                // Calculate next generation
                bool[,] nextBoard = Logic.GenerateNextBoard(gameBoard);


                // Wait for a bit before printing next board
                System.Threading.Thread.Sleep(300);
            }
        }
    }
}
