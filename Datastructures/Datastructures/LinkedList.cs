using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures
{
    class LinkedList
    {
        static Node head = null;
        public static void insertAtBeginning(int data)
        {

            if (head == null)
            {
                //Console.WriteLine(data);
                Node new_node = new Node(data);

                head = new_node;
            }
            else
            {
                Node new_node = new Node(data);
                new_node.next = head;
                head = new_node;

            }

        }
        public static void InsertAtEnd(int data)
        {
            Node curr_node = head;
            Node new_node = new Node(data);
            while (curr_node.next != null)
            {
                curr_node = curr_node.next;
            }

            curr_node.next = new_node;
            new_node.next = null;



        }
        public static void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                Node curr_node = head;
                while (curr_node.next != null)
                {
                    Console.WriteLine("->" + curr_node.data + "->");
                    curr_node = curr_node.next;

                }
                Console.WriteLine(curr_node.data + "->");
            }
        }

        public static void InsertInMiddle(int position, int data)
        {
            Node new_node = new Node(data);
            Node curr_node = head;
            Node prev_node;
            int reference = 1;
           
            while (curr_node.next != null)
            {
                prev_node = curr_node;
                curr_node = curr_node.next;
                reference++;
                if (reference == position)
                {
                    prev_node.next = new_node;
                    new_node.next = curr_node;
                    break;

                }

            }
        }

        public static void RemoveAtBeginning()
        {
            Node curr_node = head;
            curr_node = curr_node.next;
            head = curr_node;

        }

        public static void RemoveAtEnd()
        {
            Node curr_node = head;
            Node prev_node = new Node();
            while (curr_node.next != null)
            {

                prev_node = curr_node;
                curr_node = curr_node.next;

            }



            prev_node.next = null;


        }

        public static void RemoveInMiddle(int position)
        {
            
            Node curr_node = head;
            Node prev_node = new Node();
            int reference = 1;
            while (curr_node.next != null)
            {
                prev_node = curr_node;
                curr_node = curr_node.next;
                reference++;
                if (reference == position)
                {
                    prev_node.next = curr_node.next;
                    break;
                }

            }

        }
        public static void Sort()
        {
            if (head == null)
            {
                Console.WriteLine("The linked list is empty.");
            }
            else
            {
                List<int> refer_list = new List<int>();
                Node curr_node = head;
                //while (curr_node.next != null)
                //{
                //    refer_list.Add(curr_node.data);
                //    curr_node = curr_node.next;
                //}
                //refer_list.Add(curr_node.data);
                //for (int i = 0; i < refer_list.Count; i++)
                //{
                //    Console.WriteLine(refer_list[i]);
                //}

                if (curr_node.next == null)
                {
                    Console.WriteLine(curr_node.data);
                }
                else
                {
                    for (Node i = head; i.next != null; i = i.next)
                    {
                        for (Node j = head; j.next != null; j = j.next)
                        {
                            if (j.data > j.next.data)
                            {
                                int temp = j.data;
                                j.data = j.next.data;
                                j.next.data = temp;

                            }
                        }

                    }
                    Display();
                }
            }

        }

    }
}
