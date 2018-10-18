using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_3_Stacks_and_Queues
{
    //    Stack of Plates: Imagine a(literal) stack of plates.If the stack gets too high, it might topple.
    //Therefore, in real life, we would likely start a new stack when the previous stack exceeds some
    //threshold.Implement a data structure SetOfStacks that mimics this. SetOfStacks should be
    //composed of several stacks and should create a new stack once the previous one exceeds capacity.
    //SetOfStacks.push() and SetOfStacks.pop() should behave identically to a single stack
    //(that is, pop () should return the same values as it would if there were just a single stack).

    //FOLLOW UP
    //Implement a function popAt(int index) which performs a pop operation on a specific substack.
    
    public class StackSetForPlates
    {
        public int _stackSize;
        public List<StackForPlates> _stacks;

        public StackSetForPlates(int stackSize)
        {
            _stackSize = stackSize;
            _stacks = new List<StackForPlates>();
        }

        public void Push(int data)
        {
            StackForPlates currentStack = GetCurrentOne();

            if (currentStack == null || currentStack.IsFull())
            {
                var newStack = new StackForPlates(_stackSize);
                newStack.Push(data);
                _stacks.Add(newStack);
            }
            else
            {
                currentStack.Push(data);
            }
        }

        public void Pop()
        {
            StackForPlates currentStack = GetCurrentOne();

            currentStack.Pop();

            if (currentStack.IsEmpty())
            {
                _stacks.RemoveAt(_stacks.Count - 1);
            }
        }

        public StackForPlates GetCurrentOne()
        {
            if(_stacks.Count == 0)
            {
                return null;
            }

            return _stacks.Last();
        }
    }

    // Follow up question
    // Shift the whole stacks if a stack in the middle is popped
    public class StackSetForPlatesShift
    {
        public int _stackSize;
        public List<StackForPlates> _stacks;
        
        public StackSetForPlatesShift(int stackSize)
        {
            _stackSize = stackSize;
            _stacks = new List<StackForPlates>();
        }

        public void Push(int data)
        {
            var stack = GetCurrent();
            if (stack == null || stack.IsFull())
            {
                stack = new StackForPlates(_stackSize);
                _stacks.Add(stack);
            }

            stack.Push(data);
        }
               
        public StackNodeForPlates Pop(int index)
        {
            return Shift(index, true);      
        }

        public StackNodeForPlates Shift(int index, bool removeTop)
        {
            if (index < 0 || index >= _stacks.Count)
            {
                return null;
            }

            var stack = _stacks[index];

            StackNodeForPlates result;

            // This is the stack, remove the top one
            if (removeTop)
            {
                result = stack.Pop();
            }
            // This is the next stack, remove the bottom one
            else
            {
                result = stack.RemoveBottom();
            }

            // If this stack is empty after removing a node, remove the whole stack
            if (stack.IsEmpty())
            {
                _stacks.RemoveAt(index);
            }
            else
            {
                // Shift the next stack
                var node = Shift(index + 1, false);

                // Recursively push the node
                if (node != null)
                {
                    stack.Push(node.Data);
                }
            }

            return result;
        }
        

        public StackForPlates GetCurrent()
        {
            if(_stacks.Count == 0)
            {
                return null;
            }

            return _stacks.Last();
        }
    }
             
    public class StackForPlates
    {
        private int _capacity;
        private int _size = 0;
        private StackNodeForPlates _top;
          
        public StackForPlates(int capacity)
        {
            _capacity = capacity;
        }

        public void Push(int data)
        {
            _size++;
            var newNode = new StackNodeForPlates(data);
            newNode.Next = _top;
            _top = newNode;
        }

        public StackNodeForPlates Pop()
        {
            _size--;
            var data = _top;
            _top = _top.Next;
            return data;
        }

        public StackNodeForPlates RemoveBottom()
        {
            var currentNode = _top;
            var head = _top;

            if (head == null)
            {
                throw new Exception();
            }

            while(head.Next != null)
            {
                currentNode = head;
                head = head.Next;
            }

            currentNode.Next = null;
            _size--;
            return head;
        }

        public bool IsFull()
        {
            return _size >= _capacity;
        }

        public bool IsEmpty()
        {
            return _size == 0;
        }
    }

    public class StackNodeForPlates
    {
        public int Data { get; set; }
        public StackNodeForPlates Next { get; set; }

        public StackNodeForPlates(int data)
        {
            Data = data;
        }
    }

}
