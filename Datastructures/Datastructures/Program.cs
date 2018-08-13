using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
                int option = 0;
                int choice = 0;
                int ele = 10;
                Stack s = new Stack();
                Queue q = new Queue();
                while (choice == 0)
                {
                    Console.WriteLine("Chose which data structure you want: 1-Stack 2-Queue 3-Linked List");
                    option = int.Parse(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter which operation you want to perform on stack: 1-Add,2-Remove 3-Display 4-Get the top element 5-Sort");
                            int opt = int.Parse(Console.ReadLine());
                            switch (opt)
                            {
                                case 1:
                                    s.ADD(ele);
                                    break;
                                case 2:
                                    s.REMOVE();
                                    break;
                                case 3:
                                    s.DISPLAY();
                                    break;
                                case 4:
                                    s.top();
                                    break;

                                case 5:
                                    s.SORT();
                                    break;
                            }

                            break;

                        case 2:
                            Console.WriteLine("Enter which operation you want to perform on queue: 1-Add 2-Remove 3-Display 4-Get the first element in the queue 5-Sort ");
                            int opt1 = int.Parse(Console.ReadLine());
                            switch (opt1)
                            {
                                case 1:
                                    q.ADD(ele);
                                    break;
                                case 2:
                                    q.REMOVE();
                                    break;
                                case 3:
                                    q.DISPLAY();
                                    break;
                                case 4:
                                    q.peek();
                                    break;

                                case 5:
                                    q.SORT();
                                    break;
                            }
                            break;

                    case 3:

                      Console.WriteLine("Enter which operation you want to perform: 1-InsertAtBeginning 2-InsertInMiddle 3-InsertAtEnd 4-RemoveAtBeginning 5-RemoveAtEnd 6-RemoveInMiddle 7-Sort 8-Display");
                      int opt2 = int.Parse(Console.ReadLine());
                        switch (opt2)
                        {
                            case 1:
                                Console.WriteLine("Enter the element which you want to add:");
                                int data = int.Parse(Console.ReadLine());
                                LinkedList.insertAtBeginning(data);
                                break;
                            case 2:
                                Console.WriteLine("Enter the element which you want to add:");
                                int data1 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter the position:");
                                int pos = int.Parse(Console.ReadLine());
                                LinkedList.InsertInMiddle(pos, data1);
                                break;
                            case 3:
                                Console.WriteLine("Enter the element which you want to add:");
                                int data2 = int.Parse(Console.ReadLine());
                                LinkedList.InsertAtEnd(data2);
                                break;
                            case 4:
                                LinkedList.RemoveAtBeginning();
                                    break;
                            case 5:
                                LinkedList.RemoveAtEnd();
                                break;
                            case 6:
                                Console.WriteLine("Enter the position:");
                                int position = int.Parse(Console.ReadLine());

                                LinkedList.RemoveInMiddle( position);
                                break;
                            case 7:
                                LinkedList.Sort();
                                break;
                            case 8:
                                LinkedList.Display();
                                break;


                     

                        }
                        break;

                }



                    Console.WriteLine("Do you want to continue? 0-yes 1-No");
                    choice = int.Parse(Console.ReadLine());
                }
            Console.ReadKey();


            }

        }
    }

    

