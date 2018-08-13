using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures
{
    class Stack : common_operations
    {
        private static  int max_size = 2;
        private int[] stack_list = new int[max_size];
        int pointer = -1;
        public void SORT()
        {
            for (int iteration = 0; iteration <=pointer; iteration++)
            {
                for (int sort = 0; sort <= pointer-1-iteration; sort++)
                {
                    if (stack_list[sort] > stack_list[sort + 1])
                    {
                        int temp = stack_list[sort];
                        stack_list[sort] = stack_list[sort + 1];
                        stack_list[sort + 1] = temp;

                    }
                }
            }

            Console.WriteLine("The sorted elements in the stack are:");
            for (int i = 0; i <=pointer; i++)
            {
                Console.WriteLine(stack_list[i]);
            }
        }

        public void ADD(int ele)
        {

            if(pointer == max_size-1)
            {
                Console.WriteLine("The stack is full");
            }
            else
            {
                Console.WriteLine("Enter the element you want to add: ");
                int element = int.Parse(Console.ReadLine());
                pointer++;
                stack_list[pointer] = element;
                
            }
        }

        public void REMOVE()
        {
            if (pointer == (-1))
            {
                Console.WriteLine("The stack is empty");
            }
            else
            {
                int ele = stack_list[pointer];
                pointer--;
                Console.WriteLine("The element "+ele+" is removed from the stack.");
            }



        }
        public void DISPLAY()
        {
            for (int index = 0; index <= pointer; index++)
            {
                Console.WriteLine(stack_list[index]);
            }

        }

        public void top()
        {
            if (pointer==(-1))
            {
                Console.WriteLine("The stack is empty");
            }
            else
            {
                int top_value = stack_list[pointer];
                Console.WriteLine("The top value in stack is: " + top_value);
            }
        }
    }
}
