using System;
using System.Reflection;

public class MyAttribute : Attribute
{
    private string name;
    public string Name { get => name; }
    public MyAttribute(string name)
    {
        this.name = name;
    }
}

[MyAttribute("Hello,attribute")]
public class MyClass
{
    [MyAttribute("Hello")]
    public void Method1() 
    { 

    }
    [MyAttribute("world")]
    public void Method2() 
    { 

    }
}

public class Node<T>
{
    public T Data { get; set; }
    public Node<T> Next { get; set; }

    public Node(T data)
    {
        Data = data;
        Next = null;
    }
}

public class MyLinkedList<T>
{
    private Node<T> head;

    public void Add(T data)
    {
        if (head == null)
        {
            head = new Node<T>(data);
        }
        else
        {
            Node<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node<T>(data);
        }
    }

    public void ForEach(Action<T> action)
    {
        Node<T> current = head;
        while (current != null)
        {
            action(current.Data);
            current = current.Next;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyLinkedList<int> list = new MyLinkedList<int>();
        list.Add(10);
        list.Add(25);
        list.Add(15);
        list.Add(40);
        list.Add(5);

        Console.WriteLine("链表元素：");
        list.ForEach(x => Console.Write(x + " "));
        Console.WriteLine();

        int max = int.MinValue;
        list.ForEach(x => { if (x > max) max = x; });
        Console.WriteLine($"最大值：{max}");

        int min = int.MaxValue;
        list.ForEach(x => { if (x < min) min = x; });
        Console.WriteLine($"最小值：{min}");

        int sum = 0;
        list.ForEach(x => sum += x);
        Console.WriteLine($"总和：{sum}");

        PrintAttribute(typeof(MyClass));
    }

    public static void PrintAttribute(Type t)
    {
        MyAttribute classAttr =
            (MyAttribute)Attribute.GetCustomAttribute(t, typeof(MyAttribute));
        if (classAttr != null)
        {
            Console.WriteLine($"{t.Name}: {classAttr.Name}");
        }

        MethodInfo[] methods = t.GetMethods();
        foreach (var method in methods)
        {
            MyAttribute methodAttr =
                (MyAttribute)Attribute.GetCustomAttribute(method, typeof(MyAttribute));
            if (methodAttr != null)
            {
                Console.WriteLine($"{method.Name}: {methodAttr.Name}");
            }
        }
    }
}
