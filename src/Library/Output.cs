using System;
using System.Text;
using System.Threading;

namespace Game_of_life_2023
{
    public class Output
    {
        public static void PrintBoard(bool[,] board)
        {
            int width = board.GetLength(0);
            int height = board.GetLength(1);

            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        if (board[x, y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }

                Console.WriteLine(s.ToString());

                //=================================================
                //Invocar método para calcular siguiente generación
                //=================================================

                Thread.Sleep(300);
            }
        }
    }
}