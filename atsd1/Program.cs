using System;
using System.Text;

class Stack
{
    private string[] elements;
    private int top;
    private int maxSize;

    public Stack(int size)
    {
        maxSize = size;
        elements = new string[maxSize];
        top = -1;
    }

    public bool IsFull()
    {
        return top == maxSize - 1;
    }

    public bool IsEmpty()
    {
        return top == -1;
    }

    public bool Push(int number)
    {
        if (IsFull())
        {
            Console.WriteLine("Стек переповнений!");
            return false;
        }

        string octalNumber = Convert.ToString(number, 8);
        elements[++top] = octalNumber;
        return true;
    }

    public string Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Стек порожній!");
        }
        return elements[top--];
    }

    public void Print()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Стек порожній.");
            return;
        }

        Console.WriteLine("Вміст стеку:");
        for (int i = top; i >= 0; i--)
        {
            Console.WriteLine(elements[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Stack stack = new Stack(5);


        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.Push(40);
        stack.Push(50);
         

        stack.Print();

        Console.WriteLine("Видалені елементи: " + stack.Pop() + "," + stack.Pop());

        stack.Print();
    }
}
