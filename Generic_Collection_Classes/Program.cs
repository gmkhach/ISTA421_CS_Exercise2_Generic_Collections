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
            PrintDescription("List<int>");
            foreach (var x in myList) { Console.WriteLine(x); }

            LinkedList<string> myLinkedList = new LinkedList<string>();
            myLinkedList.AddFirst("first");
            myLinkedList.AddLast("second");
            myLinkedList.AddLast("third");
            myLinkedList.AddLast("fourth");
            myLinkedList.AddLast("fifth");
            PrintDescription("LinkedList<strign>");
            foreach (var x in myLinkedList) { Console.WriteLine(x); }

            Queue<char> myQueue = new Queue<char>();
            foreach (var ch in "abcdef") { myQueue.Enqueue(ch); }
            PrintDescription("Queue<char>");
            foreach (var x in myQueue) { Console.WriteLine(x); }

            Stack<bool> myStack = new Stack<bool>();
            for (int i = 1; i <= 5; i++) { myStack.Push(i % 2 == 0); }
            PrintDescription("Stack<bool>");
            foreach (var x in myStack) { Console.WriteLine(x); }

            Dictionary<string, int> myDictionary = new Dictionary<string, int>();
            string number = "";
            for (int i = 1; i <= 5; i++)
            {
                switch (i)
                    {
                    case 1:
                        number = "one";
                        break;
                    case 2:
                    number = "two";
                        break;
                    case 3:
                        number = "three";
                        break;
                    case 4:
                        number = "four";
                        break;
                    case 5:
                        number = "five";
                        break;
                }
                myDictionary.Add(number, i);
            }
            PrintDescription("myDictionary<string, int>");
            foreach (var x in myDictionary) { Console.WriteLine(x); }

            SortedList<char, string> mySortedList = new SortedList<char, string>();
            char symbol = ' ';
            string name = "";
            for (int i = 1; i <= 5; i++)
            {
                switch (i)
                {
                    case 1:
                        symbol = '@';
                        name = "at";
                        break;
                    case 2:
                        symbol = '#';
                        name = "hashtag";
                        break;
                    case 3:
                        symbol = '&';
                        name = "ampersand";
                        break;
                    case 4:
                        symbol = '%';
                        name = "percent";
                        break;
                    case 5:
                        symbol = '*';
                        name = "asterisk";
                        break;
                }
                mySortedList.Add(symbol, name);
            }
            PrintDescription("StoredList<char, string>");
            foreach (var x in mySortedList) { Console.WriteLine(x); }

            HashSet<bool> myHashSet = new HashSet<bool>();
        }

        static void PrintDescription(string dataStruct) => Console.WriteLine($"\nValues of {dataStruct}:");
    }
}
