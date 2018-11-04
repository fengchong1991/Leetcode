using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackTheCodingInterview.Chapter_3_Stacks_and_Queues
{
    public class MyStack<T>
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
            if(_top == null)
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

    // Usage: breadth-first search or implementing a cache
    public class MyQueue<T>
    {
        private QueueNode _first;
        private QueueNode _last;

        public void Add(T data)
        {
            var node = new QueueNode(data);
            if(_last != null)
            {
                node._next = _last;
            }
            _last = node;

            if(_first == null)
            {
                _first = _last;
            }
        }

        public T Remove()
        {
            if(_first == null)
            {
                throw new Exception();
            }

            var data = _first._data;
            _first = _first._next;

            if(_first == null)
            {
                _last = null;
            }

            return data;
        }

        public T Peek()
        {
            if(_first == null)
            {
                throw new Exception();
            }

            return _first._data;
        }

        public bool IsEmpty()
        {
            return _first == null;
        }
        
        private class QueueNode
        {
            internal T _data;
            internal QueueNode _next;

            public QueueNode(T data)
            {
                _data = data;
            }
        }
    }
}
