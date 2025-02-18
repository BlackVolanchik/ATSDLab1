using System;
using System.Collections.Generic;
using System.Text;

class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class LinkedList
{
    private Node head;

    public void Add(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }
    }

    public void RemoveNegative()
    {
        while (head != null && head.Data < 0)
        {
            head = head.Next;
        }

        if (head == null) return;

        Node current = head;
        while (current.Next != null)
        {
            if (current.Next.Data < 0)
            {
                current.Next = current.Next.Next;
            }
            else
            {
                current = current.Next;
            }
        }
    }

    public Stack<string> ConvertToStack()
    {
        Stack<string> stack = new Stack<string>();
        List<int> values = new List<int>();

        Node current = head;
        while (current != null)
        {
            values.Add(current.Data);
            current = current.Next;
        }

        values.Reverse();

        foreach (int value in values)
        {
            stack.Push(Convert.ToString(value, 8));
        }

        return stack;
    }

    public void Print()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        LinkedList list = new LinkedList();

 
        list.Add(10);
        list.Add(-10);
        list.Add(20);
        list.Add(-20);
        list.Add(30);
        list.Add(40);

        Console.WriteLine("Початковий список:");
        list.Print();

        list.RemoveNegative();
        Console.WriteLine("Список після видалення від'ємних елементів:");
        list.Print();

        Stack<string> stack = list.ConvertToStack();

        Console.WriteLine("Стек(до видалення):");
        foreach (string item in stack)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();


        Console.WriteLine("Стек:");
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }
    }
}
