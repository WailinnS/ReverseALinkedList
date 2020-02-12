using System;

namespace ReverseALinkedList
{
    class Program
    {
        static void changeDirection(Node<int> aList)
        {

            if(aList.Next == null)
            {
                return;
            }
            Node<int> temp = aList.Next;
            changeDirection(temp);
            //temp 4 - a list 3
            temp.Next = aList;
            aList.Next = null;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //making a list
            LinkedList<int> myList = new LinkedList<int>();

            //adding some stuff (0,1,2,3,4,5)
            myList.AddFirst(5);
            myList.AddFirst(4);
            myList.AddFirst(3);
            myList.AddFirst(2);
            myList.AddFirst(1);
            myList.AddFirst(0);
            
            //display
            foreach (var item in myList)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();


            //change the list direction
            myList.changeDirection(myList.Head);

            foreach (var item in myList)
            {
                Console.Write($"{item} ");
            }

        }
    }
}
