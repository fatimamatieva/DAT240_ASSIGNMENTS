using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace UiS.Dat240.Lab1.Queues
{
    public interface IGenericQueue<T>
    {
        int Length { get; }
        void Enqueue(T value);
        T Dequeue();
    }

    public class GenericQueue<T> : IGenericQueue<T>, System.Collections.Generic.IEnumerable<T>
    {
        public int spaces = 8;
        public T[] que = new T[8];
        public int Length 
        {
            get
            {
                return que.Length - spaces;
            }
        }

        public void Enqueue(T value)
        {
            if (spaces== 0)
            {
                this.Grow();
            }
            que[this.Length] = value;
            spaces--;
        }

        public T Dequeue()
        {
            if (1>Length)
            {
                throw new System.Exception("The queue is empty.");
            }
            T first_element = que[0];
            que = que.Skip(1).ToArray();
            return first_element;
        }

        public void Grow()
        {
            T[] updated = new T[2*que.Length];
            System.Array.Copy(que, updated, que.Length);
            this.spaces = updated.Length/2;
            que= updated;
        }
        public IEnumerator<T> GetEnumerator()
        {for (int x=0; x<Length; x++){yield return que[x];}}

        IEnumerator IEnumerable.GetEnumerator()
        {for (int y=0; y<Length; y++){yield return que[y];}}
    }
}