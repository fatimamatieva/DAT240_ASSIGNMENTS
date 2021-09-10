﻿using System;

namespace UiS.Dat240.Lab1.Queues
{
    public interface IGenericQueue<T>
    {
        int Length { get; }
        void Enqueue(T value);
        T Dequeue();
    }

    public class GenericQueue<T> : IGenericQueue<T>
    {
        public T[] q;
        private int end=0;
        private int start=0;
        private int Size = 0;

        public int Length => Size;

        public GenericQueue()
        {
            q = new T[1];
        }


        // Enqueue
        public void Enqueue(T value)
        {
            //throw new NotImplementedException();
            if(q.Length == Size)
            {
                Grow();
            }
                q[end] = value;
                end++;
                Size++;
        }
        public T Dequeue()
        {
            //throw new System.NotImplementedException();
            T newarray = q[start];
            // q[start] = null;
            if (Size <= 0)
            {
                throw new Exception("The size cant be 0 or bellow");
            }
            else if (Size > 0)
            {
                Size--;
                for(int i=1; i < q.Length; i++)
                {
                    q[i-1] = q[i];
                }
                end--;
                // q[end] = null;
                if(start == end)
                {
                    start = 0;
                }
                /*else
                {
                    start++;
                }*/
            }
            return newarray;
        }

        public void Grow()
        {
            T[] newarray = new T[q.Length * 2];
            for (int i=0; i < q.Length; i++)
            {
                newarray[i] = q[i];
            }
            q = newarray;
        }

    }
}