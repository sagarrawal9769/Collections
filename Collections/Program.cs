using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
      
        Program.List();
        Program.SortedList();

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

        foreach (var item in listName)
        {
            Console.WriteLine(item);
        }

        var listName2 = new List<string>() { "Raj", "Rahul", "Nitin" };

        foreach (var item in listName2)
        {
            Console.WriteLine(item);
        }

        var listAge = new List<int>() { 50, 30, 40, 10, 18, 21, };
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

        foreach (var student in studNames)
        {
            Console.WriteLine(student.Age + ", " + student.Name);
        }

        var numbers = new List<int>() { 20, 10, 33, 22, 111, 345 };
        numbers.Insert(0, 5);
        numbers.Remove(346);
        numbers.RemoveAt(1);
       
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
        SortedList<int, string> ageAndNames = new SortedList<int, string>();
        ageAndNames.Add(29, "Billy");
        ageAndNames.Add(25, "Steve");
        ageAndNames.Add(26, "Eddie");
        ageAndNames.Add(14, "Mike");
        ageAndNames.Add(12, "Eleven");
        ageAndNames.Add(23, "Nancy");
        Console.WriteLine("--------Age and Names-----------");
        foreach(var item in ageAndNames)
        {
            Console.WriteLine("Age:{0}, Name:{1}", item.Key,item.Value);
        }

        SortedList<string, string> cities = new SortedList<string, string>()
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
    }
}