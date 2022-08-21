using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Zadacha58()
            {
                //Заполните спирально массив 4 на 4.
                //Например, на выходе получается вот такой массив:
                //1 2 3 4
                //12 13 14 5
                //11 16 15 6
                //10 9 8 7

                Random random = new Random();
                int m = 4;
                int n = 4;
                int[,] array = new int[m, n];
                FillArray(array);
                PrintArray(array);
               

                void PrintArray(int[,] Array)
                {
                    int rows = array.GetLength(0);
                    int columns = array.GetLength(1);
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            Console.Write(array[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                }

                void FillArray(int[,] Array)
                {
                    int rows = array.GetLength(0);
                    int columns = array.GetLength(1);
                    int row = 0;
                    int column = 0;
                    int changeRow = 0;
                    int changeColumn = 1;
                    int steps = columns;
                    int turn = 0;

                    for (int i = 0; i < array.Length; i++)
                    {
                        array[row, column] = i + 1;
                        steps--;
                        if (steps == 0)
                        {
                            steps = columns * (turn % 2) + rows * ((turn + 1) % 2) - 1 - turn / 2;

                            int temp = changeRow;
                            changeRow = changeColumn;
                            changeColumn = -temp;
                            turn++;
                        }
                        row += changeRow;
                        column += changeColumn;
                        
                    }
                }
            }
        Zadacha58();
        }
    }
}

