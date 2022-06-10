public class Node<T>
{
    public Node<T>? next;
    public T? data;
}

public class LinkedList<T>
{
    private Node<T>? head;

    public void printAllNodes()
    {
        Node<T>? current = head;
        while (current != null)
        {
            Console.WriteLine(current.data);
            current = current.next;
        }
    }

    public void AddFirst(T data)
    {
        Node<T>? toAdd = new Node<T>();

        toAdd.data = data;
        toAdd.next = head;

        head = toAdd;
    }

    public void AddLast(T data)
    {
        if (head == null)
        {
            head = new Node<T>();

            head.data = data;
            head.next = null;
        }
        else
        {
            Node<T>? toAdd = new Node<T>();
            toAdd.data = data;

            Node<T>? current = head;
            while (current.next != null)
            {
                current = current.next;
            }

            current.next = toAdd;
        }
    }
    
    public LinkedList<T> filter(T value)
    {
        LinkedList<T>? filtered = new LinkedList<T>();
        Node<T>? current = head;
        while (current != null)
        {
            if(current.data.Equals(value))
            {
                filtered.AddLast(current.data);
            }
            current = current.next;
        }
        return filtered;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Add First:");
        LinkedList<String>? myList1 = new LinkedList<String>();

        myList1.AddFirst("Hello");
        myList1.AddFirst("Magical");
        myList1.AddFirst("World");
        myList1.printAllNodes();

        Console.WriteLine("Filtered Hello:   ");
        myList1.filter("Hello").printAllNodes();

        Console.WriteLine();

        Console.WriteLine("Add Last:");
        LinkedList<String>? myList2 = new LinkedList<String>();

        myList2.AddLast("Hello");
        myList2.AddLast("Magical");
        myList2.AddLast("World");
        myList2.printAllNodes();

        Console.WriteLine("Filtered World:   ");
        myList2.filter("World").printAllNodes();

        Console.ReadLine();
    }
}