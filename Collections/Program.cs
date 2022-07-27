using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {

        Program.List();
        Program.SortedList();
        Program.Stack();
        Program.Queue();

    }
    public static void List()
    {
        Console.WriteLine();
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("List()");
        Console.WriteLine();
        var listName = new List<string>();
        listName.Add("Sagar");
        listName.Add("Tisha");
        listName.Add("Riya");

        Console.WriteLine("List:-");;

        foreach (var item in listName)
        {
            Console.WriteLine(item);
        }

       

        var listName2 = new List<string>() { "Raj", "Rahul", "Nitin" };
        Console.WriteLine();
        Console.WriteLine("List2:-");
        foreach (var item in listName2)
        {
            Console.WriteLine(item);
        }

        var listAge = new List<int>() { 50, 30, 40, 10, 18, 21, };
        Console.WriteLine();
        Console.WriteLine("List3:-");
        foreach (var item in listAge)
        {
            Console.WriteLine(item);
        }
        var students = new List<Student>()
        {
            new Student(){Age = 26,Name = "Billy"},
            new Student(){Age = 23,Name = "Mike"},
            new Student(){Age = 19,Name = "Will"},
            new Student(){Age = 21, Name = "Dustin"},
            new Student(){Age= 26 , Name = "Steve"},
            new Student(){Age = 27, Name = "Eddie"}
        };

        var studNames = from s in students
                        where s.Age > 21
                        where s.Name == "Eddie"
                        select s;
        Console.WriteLine();
        Console.WriteLine("List4:-");
        foreach (var student in studNames)
        {
            Console.WriteLine(student.Age + ", " + student.Name);
        }

        var numbers = new List<int>() { 20, 10, 33, 22, 111, 345 };
        numbers.Insert(0, 5);
        numbers.Remove(346);
        numbers.RemoveAt(1);
        Console.WriteLine();
        Console.WriteLine("List4:-");
        foreach (var student in numbers)
        {
            Console.Write(student + " ");
        }
        int[] containsOrNot = { 12, 20, 111, 112 };
        Console.WriteLine();
        foreach (var item in containsOrNot)
        {
            Console.WriteLine(numbers.Contains(item));
        }
        Console.WriteLine();



    }
    public static void SortedList()
    {
        Console.WriteLine();
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("SortedList()");
        Console.WriteLine();
        var ageAndNames = new SortedList<int, string>();
        ageAndNames.Add(29, "Billy");
        ageAndNames.Add(25, "Steve");
        ageAndNames.Add(26, "Eddie");
        ageAndNames.Add(14, "Mike");
        ageAndNames.Add(12, "Eleven");
        ageAndNames.Add(23, "Nancy");
        Console.WriteLine("--------Age and Names-----------");
        foreach (var item in ageAndNames)
        {
            Console.WriteLine("Age:{0}, Name:{1}", item.Key, item.Value);
        }

        var cities = new SortedList<string, string>()
                                    {
                                        {"London", "UK"},
                                        {"New York", "USA"},
                                        { "Mumbai", "India"},
                                        {"Delhi", "India"}

                                    };
        Console.WriteLine("---Cities---");
        foreach (var kvp in cities)
        {
            Console.WriteLine("City:{0}, Country:{1}", kvp.Key, kvp.Value);
        }
        Console.WriteLine();
    }
    public static void Stack()
    {
        Console.WriteLine();
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Stack()");
        Console.WriteLine();
        var names = new Stack<string>();
        names.Push("sagar");
        names.Push("Raj");
        names.Push("Tisha");
        names.Push("Riya");
        Console.WriteLine("List:-");
        foreach (var item in names)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        Console.WriteLine("Doing Pop:-");
        Console.WriteLine();
        Console.WriteLine("Peek Element: " + names.Peek());
        Console.WriteLine("Pop Element: " + names.Pop());
        Console.WriteLine("After Pop, Peek Element: " + names.Peek());
       
        Console.WriteLine();
        Console.WriteLine("After Pop list:-");
        foreach (var item in names)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
    public static void Queue()
    {
        Console.WriteLine();
        Console.WriteLine("------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine("Queue()");
        Console.WriteLine();
        var names = new Queue<string>();
        names.Enqueue("Tisha");
        names.Enqueue("Sagar");
        names.Enqueue("Raj");
        names.Enqueue("Riya");
        names.Enqueue("Rahul");

        Console.WriteLine("List:-");

        foreach (var item in names)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();
        Console.WriteLine("Doing Dequeue:-");
        Console.WriteLine("Peek Element: " + names.Peek());
        Console.WriteLine("Dequeue Element; " + names.Dequeue());
        Console.WriteLine("After Dequeue, Peek Element: " + names.Peek());
        Console.WriteLine();
        Console.WriteLine("After Dequeue list:-");
        foreach(var item in names)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

    }
    public static void LinkedList()
    {

    }
}