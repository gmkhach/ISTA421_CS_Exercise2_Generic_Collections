using System;
using System.Collections.Generic;

namespace Generic_Collection_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            for (int i = 1; i <= 5; i++) { myList.Add(i); }
            PrintDescription("List");
            foreach (var x in myList) { Console.WriteLine(x); }

            LinkedList<string> myLinkedList = new LinkedList<string>();
            myLinkedList.AddFirst("first");
            myLinkedList.AddLast("second");
            myLinkedList.AddLast("third");
            myLinkedList.AddLast("fourth");
            myLinkedList.AddLast("fifth");
            PrintDescription("LinkedList");
            foreach (var x in myLinkedList) { Console.WriteLine(x); }

            Queue<char> myQueue = new Queue<char>();

            Stack<double> myStack = new Stack<double>();

            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            SortedList<char, string> mySortedList = new SortedList<char, string>();

            HashSet<bool> myHashSet = new HashSet<bool>();
        }

        static void PrintDescription(string dataStruct) => Console.WriteLine($"\nValues of {dataStruct}:");
    }
}
