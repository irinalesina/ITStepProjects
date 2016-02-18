using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_3
{
    //class GenericStack<T>
    //{
    //    private T[] stack;
    //    private int top = -1;
    //    private int capacity = 10;

    //    public GenericStack()
    //    {
    //        stack = new T[capacity] { };
    //    }

        
    //    void Push(T value)
    //    {
    //        top++;
    //    }

    //    public T Pop()
    //    {
    //        if (top == -1)
    //            return null;

    //        return stack[top--];
    //    }
    //}

    class MyStack<T>
    {
        readonly int capacity;
        T[] stack;
        int top = -1;

        public MyStack(int MaxElements)
        {
            capacity = MaxElements;
            stack = new T[capacity];
        }

        public void Push(T element)
        {
            //Check Overflow
            if (top == capacity - 1)
            {
                throw new OutOfMemoryException("Capacity is overfilled!");
            }
            else
            {
                stack[++top] = element;
            }
        }

        public T Pop()
        {
            if (top == -1)
            {
                throw new IndexOutOfRangeException("Stack is empty!");
            }

            return stack[top--];
        }

        public int GetSize()
        {
            return top + 1;
        }
    }
}
