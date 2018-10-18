using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_3_Stacks_and_Queues
{
	//3.4 Queue via Stacks: Implement a MyQueue class which implements a queue using two stacks.
	
	// User two stacks, the second will be a reverse stack of the first one
	public class MyQueue2<T>
    {
        private MyStackForQueue<T> _stackNew;
        private MyStackForQueue<T> _stackOld;

		public MyQueue2()
        {
            _stackNew = new MyStackForQueue<T>();
            _stackOld = new MyStackForQueue<T>();
        }

		public void Add(T data)
        {
            _stackNew.Push(data);

        }

		// Move everything from new stack to old stack
		private void ShiftStacks()
        {
            if (_stackOld.IsEmpty())
            {
                while (!_stackNew.IsEmpty())
                {
                    _stackOld.Push(_stackNew.Pop());
                }
            }
        }

		public T Remove()
        {
            ShiftStacks();
            return _stackOld.Pop();
        }

		public T Peek()
        {
            ShiftStacks();
            return _stackOld.Peek();
        }
    }

    public class MyStackForQueue<T>
    {
        private StackNode _top;

        public T Pop()
        {
            if (_top == null)
            {
                throw new Exception();
            }

            T data = _top._data;
            _top = _top._next;

            return data;
        }
        public void Push(T data)
        {
            StackNode t = new StackNode(data);
            t._next = _top;
            _top = t;
        }

        public T Peek()
        {
            if (_top == null)
            {
                throw new Exception();
            }

            return _top._data;
        }

        public bool IsEmpty()
        {
            return _top == null;
        }

        private class StackNode
        {
            internal T _data;
            internal StackNode _next;

            public StackNode(T data)
            {
                this._data = data;
            }
        }
    }
}
