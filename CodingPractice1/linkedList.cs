using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice
{
    public class UnionLinkedLists
    {
        public Node? Head { get; set; }


        public void Union(Node data1, Node Data2)
        {
            Node t1 = data1, t2 = Data2;
            while (t1 != null)
            {
                //inset element in to list
                push(t1.data);
                t1 = t1.Next;
            }

            //insert 2nd list t2

            while (t2 != null)
            {
                //check if they are present before they are pushed.
                if (!isPresent(Head, t2.data))
                {
                    push(t2.data);
                }
                t2 = t2.Next;
            }
        }

        void getIntersection(Node head1, Node head2)
        {
            Node t1 = head1;

            // Traverse list1 and search each
            // element of it in list2.
            // If the element is present in
            // list 2, then insert the
            // element to result
            while (t1 != null)
            {
                if (isPresent(head2, t1.data))
                    push(t1.data);
                t1 = t1.Next;
            }
        }


        public void push(int data)
        {
            // allocate space
            Node new_node = new Node(data);

            //make next of new node as head
            new_node.Next = Head;

            //Move the head to point to new node
            Head = new_node;
        }

        bool isPresent(Node head, int data)
        {
            Node t = head;
            while (t != null)
            {
                if (t.data == data)
                {
                    return true;
                }
                t = t.Next;
            }
            return false;
        }

    }


    public class Node
    {
        public int data { get; set; }

        public Node? Next { get; set; }

        public Node(int d)
        {
            data = d;
            Next = null;
        }
    }
}
