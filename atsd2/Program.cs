using System;
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

    public LinkedList()
    {
        head = null;
    }

    public bool IsEmpty()
    {
        return head == null;
    }

    public void AddToHead(int number)
    {
        Node newNode = new Node(number);
        newNode.Next = head;
        head = newNode;
    }

    public int RemoveFromHead()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Список порожній!");
        }

        int removedData = head.Data;
        head = head.Next;
        return removedData;
    }

    public void Print()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Список порожній.");
            return;
        }

        Console.WriteLine("Вміст списку:");
        Node current = head;
        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        LinkedList list = new LinkedList();

        list.AddToHead(10);
        list.AddToHead(20);
        list.AddToHead(30);
        list.AddToHead(40);
        list.AddToHead(50);
        list.AddToHead(50);
        list.AddToHead(50);
        list.Print();

        Console.WriteLine("Видалені елементи: " + list.RemoveFromHead() + "," + list.RemoveFromHead());

        list.Print();
    }
}
