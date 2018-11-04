using System;
using System.Collections.Generic;

namespace Generic_Collection_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            
            LinkedList<string> myLinkedList = new LinkedList<string>();

            Queue<char> myQueue = new Queue<char>();

            Stack<double> myStack = new Stack<double>();

            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            SortedList<char, string> mySortedList = new SortedList<char, string>();

            HashSet<bool> myHashSet = new HashSet<bool>();
        }
    }
}
