using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures
{
    class LinkedListArray
    {
        private string[] items = new string[100];
        private int Count = 0;

        public int Length()
        {
            return Count;
        }
        public bool Insert(string newItem)
        {
            if (Count == items.Length)
            {
                return false;
            }
            items[Count] = newItem;
            Count++;
            return true;
        }
        public bool IsFull()
        {
            if (Count == items.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsEmpty()
        {
            if (Count == 0)
            {
                return true;
            }
            return false;
        }
        public void PrintList()
        {
            int counter = 0;
            Console.Write("Start of list ->    ");
            while (counter < Count)
            {
                Console.Write(items[counter]);
                Console.Write(" -> ");
                counter++;
            }
            Console.WriteLine("end of list");
        }
        public bool RemoveAt(int index)
        {
            if (index > Count || index < 0)
            {
                return false;
            }
            return true;
        }
        public bool InsertAT(int index, object o)
        {
            if (index > Count || index < 0)
            {
                return false;
            }
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }
        public static void Start()
        {
            /*LinkedListArray myList = new LinkedListArray();
            Console.WriteLine("my list's length is " + myList.Length());
            Console.WriteLine("is empty = " + myList.IsEmpty());
            Console.WriteLine("is full = " + myList.IsFull());


            myList.Insert("Dan");
            myList.Insert("Jacky");
            myList.Insert("Mace");
            myList.Insert("Yolanda");
            myList.Insert("David");
            myList.Insert("daviD");

            myList.PrintList();

            Console.WriteLine("my list's length is " + myList.Length());
            Console.WriteLine("is empty = " + myList.IsEmpty());
            Console.WriteLine("is full = " + myList.IsFull());*/

            LinkedListNode myLists = new LinkedListNode();
            myLists.Add("Steve");
            myLists.Add("Mauricio");
            myLists.Add("Evan");
            myLists.Add("Dan");

            Console.WriteLine("my list's count is " + myLists.Count);
            myLists.PrintReverse();

            Node tempNode = myLists.GetNode(3);
            tempNode.Data = "Ty";
            myLists.PrintList();

            Console.ReadLine();
        }
    }
}
