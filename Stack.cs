using System;

public class Stack
{
    int[] arr;
    int topOfStack;

    public Stack(int size)
    {
        this.arr = new int[size];
        this.topOfStack = -1;
        Console.WriteLine("The stack is created with size of " + size);
    }

    //Check if stack is empty
    public Boolean isEmpty()
    {
        if (topOfStack == -1)
        {
            Console.WriteLine("Stack is empty");
            return true;
        }
        else
        {
            return false;
        }
    }

    //Check if stack is full
    public Boolean isFull()
    {
        if (topOfStack == arr.Length - 1)
        {
            //Console.WriteLine("Stack is full");
            return true;
        }
        else
        {
            return false;
        }
    }
    //Push element in the stack
    public int push(int value)
    {
        if (isFull())
        {
            Console.WriteLine("The stack is full");
            return -1;
        }
        else
        {
            arr[topOfStack + 1] = value;
            topOfStack++;
            Console.WriteLine("Value is successfully inserted");
            return topOfStack;
        }
    }

    //Pop element from the stack
    public int pop()
    {
        if (isEmpty())
        {
            Console.WriteLine("The stack is empty");
            return -1;
        }
        else
        {
            int element = arr[topOfStack];
            topOfStack--;
            Console.WriteLine(element);
            return element;
        }
    }

    //Stack peek method
    public int peek()
    {
        if (isEmpty())
        {
            Console.WriteLine("The stack is empty");
            return -1;    
        }
        else
        {
            int element = arr[topOfStack];
            Console.WriteLine(element);
            return element;
        }
    }

    //Delete entire stack
    public void deleteStack()
    {
        arr = null;
        Console.WriteLine("Stack is successfully deleted");
    }
}