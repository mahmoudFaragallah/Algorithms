using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.datastructures.GeeksForGeeks_Eamples
{
    // Simple linkedList
    public class Linkedlist_Init
    {
        // The first object of linkedList (head) will be 
        // an object of type Node (null by default)
        Node head;
        //Private class to represent node
        class Node
        {
            int data;
            Node next; // reference or pointer
            //construtor to create a new node
            public Node(int d)
            {
                data = d; 
            }
        }
    }
    // LinkedList with three node
    public class Linkedlist
    {
        Node head;
       public class Node
        {
            public int data;
            public Node next;

            public Node(int d)
            {
                data = d;
                next = null;
            }// constructor
        }
        // To test our code
        //public static void Main(String[] args)
        //{
        //    // start with empty list
        //    Linkedlist linkedlist = new Linkedlist();
            
        //    linkedlist.head = new Node(1);
        //    Node second = new Node(2);
        //    Node third = new Node(3);

        //    //Link nodes with each other dynamically
        //    linkedlist.head.next = second;
        //    second.next = third;
        //}
        //Linked List Traversal 
        public void DisplayLinkedList()
        {
            Node n = head;
            while (n != null)
            {
                Console.WriteLine(n.data + ' ');
                n = n.next;
            }
        }
    }


}
