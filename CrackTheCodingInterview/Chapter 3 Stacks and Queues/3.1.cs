using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_3_Stacks_and_Queues
{
    //    Three in One: Describe how you could use a single array to implement three stacks.
    class _3_1
    {
        

        
    }

    // Implement multiple stacks using an array
    public class MyStackForThree
    {
        private const int numberOfStacks = 3;
        private int[] stack;
        private int[] stackSize;
        private readonly int stackCapacity;

        public MyStackForThree(int stackNum)
        {
            stack = new int[stackNum * numberOfStacks];
            stackSize = new int[numberOfStacks];
            stackCapacity = stackNum;
        }

        public void Push(int data, int stackIndex)
        {
            if(stackSize[stackIndex] >= stackCapacity)
            {
                throw new Exception();
            }
            stack[IndexOfTop(stackIndex)] = data;
            stackSize[stackIndex]++;
        }
        
        public int Pop(int stackIndex)
        {
            if(stackSize[stackIndex] <= 0)
            {
                throw new Exception();
            }

            var index = IndexOfTop(stackIndex);
            var result = stack[index];
            stack[index] = 0;
            stackSize[index]--;
            return result; 
        }

        public int Peek(int stackIndex)
        {
            if(stackSize[stackIndex] <= 0)
            {
                throw new Exception();
            }

            return stack[IndexOfTop(stackIndex)];
        }

        public int IndexOfTop(int stackIndex)
        {
            var offset = stackIndex * stackCapacity;
            var size = stackSize[stackIndex];
            return offset + size;
        }
    }
}
