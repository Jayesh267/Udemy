using System;
using System.Collections.Generic;
using System.Text;

namespace Udemy
{
    public class SingleDimensionalArray
    {
        public int[] arr = null;

        public SingleDimensionalArray (int sizeOfArray)
        {
            arr = new int[sizeOfArray];
            for (int i=0; i< arr.Length; i++)
            {
                arr[i] = Int32.MinValue;
            }
        }

        public void insert (int location, int valueToBeAdded)
        {
            try
            {
                if (arr[location] == Int32.MinValue)
                {
                    arr[location] = valueToBeAdded;
                    Console.WriteLine("Item successfully added");
                }
                else
                {
                    Console.WriteLine("This cell is already occupied");
                }
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range");
            }
        }

        //Array traversal
        public void traverseArray()
        {
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Array no longer exists!!");
            }
        }
        
        //Search for an element in an array
        public void searchArray(int valueToSearch)
        {
            for (int i=0; i<arr.Length; i++)
            {
                if (arr[i] == valueToSearch)
                {
                    Console.WriteLine("Value found at " + i);
                    return;
                }
            }
            Console.WriteLine("Value not found");
        }

        //Delete value from an array item
        public void deleteValue(int indexToBeDeleted)
        {
            try
            {
                arr[indexToBeDeleted] = Int32.MinValue;
                Console.WriteLine("Value deleted successfully");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range");
            }
        }
    }
}