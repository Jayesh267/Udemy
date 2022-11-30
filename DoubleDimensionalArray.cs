using System;

namespace Udemy
{
    public class DoubleDimensionalArray
    {
        int[,] arr2 = null;
        public DoubleDimensionalArray(int numberOfRows, int numberOfCols)
        {
            this.arr2 = new int[numberOfRows, numberOfCols];
            for (int i=0; i<numberOfRows; i++)
            {
                for (int j=0; j<numberOfCols; j++)
                {
                    arr2[numberOfRows, numberOfCols] = Int32.MinValue;
                }
            }
        }

        public void insertInArray(int row, int col, int value)
        {
            try
            {
                if (arr2[row, col] == Int32.MinValue)
                {
                    arr2[row, col] = value;
                    Console.WriteLine("Successfully inserted the value");
                }
                else
                {
                    Console.WriteLine("Cell is already occupied");
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Invalid index for 2D array");
            }
            
        }

        public void traverse2DArray()
        {
            //Display 2D Array

            //Step 1 - Declare
            int[,] arr2 = new int[2, 3];

            //Step 3 - Initialize
            arr2[0, 0] = 2;
            arr2[0, 1] = 3;
            arr2[1, 0] = 6;
            arr2[1, 1] = 7;
            int rowLen = arr2.GetLength(0);
            int colLen = arr2.GetLength(1);

            for (int i = 0; i < rowLen; i++)
            {
                for (int j = 0; j < colLen; j++)
                {
                    Console.WriteLine(string.Format("{0} ", arr2[i, j]));
                }
                Console.WriteLine();
            }
        }
        
        public void searchInArray(int value)
        {
            for (int i=0; i<arr2.Length; i++)
            {
                for (int j=0; j<arr2.GetLength(1); j++)
                {
                    if (arr2[i,j] == value)
                    {
                        Console.WriteLine("Item found at row " + i + " and column " + j);
                        return;
                    }
                }
            }
            Console.WriteLine("Item not found");
        }

        public void deleteItemInArray(int row, int col)
        {
            try
            {
                Console.WriteLine("Successfully deleted");
                arr2[row, col] = Int32.MinValue;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index is invalid for this array");
            }
        }
    }
}