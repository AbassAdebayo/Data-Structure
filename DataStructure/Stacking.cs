using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Stacking<T>
    {
        List<T> elements = new List<T>();

        //public void Push(T element)
        //{
        //    elements.Add(element);
        //}

        //public T Pop()
        //{
        //    if (elements.Count == 0)
        //    {
        //        throw new InvalidOperationException("Stack is empty");
        //    }
        //    T element = elements[elements.Count - 1];
        //    elements.RemoveAt(elements.Count - 1);
        //    return element;
        //}

        //public T Peek()
        //{

        //    if (elements.Count == 0)
        //    {
        //        throw new InvalidOperationException("Stack is empty");
        //    }
        //    return elements[elements.Count - 1];
        //}

        public T Enqueue(T element)
        {
            elements.Add(element);
            return element;
        }

        public T Dequeue()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            T element = elements[0];
            elements.RemoveAt(0);
            return element;
        }

        public T Peek()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return elements[0];
        }
    }
}
