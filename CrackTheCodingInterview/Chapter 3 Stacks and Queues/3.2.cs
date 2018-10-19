using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_3_Stacks_and_Queues
{

    //    Stack Min: How would you design a stack which, in addition to push and pop, has a function min
    //which returns the minimum element? Push, pop and min should all operate in 0(1) time.
    public class MyStackForMin
    {
        private StackNode _top;

        public void Push(int data)
        {
            int min;

            if (_top == null || _top.Min >= data)
            {
                min = data;
            }
            else
            {
                min = _top.Min;
            }


            var newNode = new StackNode(data, min);
            newNode.Next = _top;
            _top = newNode;   
        }

        public StackNode Pop()
        {
            if(_top == null)
            {
                throw new Exception();
            }

            var data = _top;
            _top = _top.Next;
            return data;
        }

        public int Min()
        {
            if (_top == null)
            {
                throw new Exception();
            }

            return _top.Min;
        }

    }

    public class StackNode {
        public int Data { get; set; }
        public int Min { get; set; }
        public StackNode Next {get;set;}

        public StackNode(int data, int min)
        {
            Data = data;
            Min = min;
        }
    }

}
