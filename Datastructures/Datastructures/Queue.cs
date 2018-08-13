using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures
{
    class Queue
    {
        private static int max_size = 2;
        private int[] queue_list = new int[max_size];
        int front = -1;
        int rear = -1;

        public void SORT()
        {
            for (int iteration = 0; iteration < queue_list.Length; iteration++)
            {
                for (int sort = 0; sort < queue_list.Length - 1 - iteration; sort++)
                {
                    if (queue_list[sort] > queue_list[sort + 1])
                    {
                        int temp = queue_list[sort];
                        queue_list[sort] = queue_list[sort + 1];
                        queue_list[sort + 1] = temp;

                    }
                }
            }

            Console.WriteLine("The sorted elements in the stack are:");
            for (int i = 0; i < queue_list.Length; i++)
            {
                Console.WriteLine(queue_list[i]);
            }
        }
        
        public void ADD(int element)
        {
            if (rear == max_size - 1)
            {
                Console.WriteLine("The queue is full");
            }

            else
            {
                Console.WriteLine("Enter the element you want to Add: ");
                int no = int.Parse(Console.ReadLine());
                rear++;
                queue_list[rear] = no;
            }


        }
        public void REMOVE()
        {
            if (front==rear)
            {
                Console.WriteLine("The queue is empty");
            }
            else
            {
               
                front++;
                int deleted_ele = queue_list[front];
                Console.WriteLine("The first element"+deleted_ele+" is removed");
            }

        }
        public void DISPLAY()
        {
            for (int index = front+1; index <= rear; index++)
            {
                Console.WriteLine(queue_list[index]);
            }
        }

        public void peek()

        {
            if (front==rear)
            {
                Console.WriteLine("The queue is empty");
            }
            else
            {
                int first_ele = queue_list[front+1];
                Console.WriteLine("The first element in the queue is: " + first_ele);
            }
        }

    }
}
