using System;

namespace UiS.Dat240.Lab1.Queues
{
    public interface IGenericPriorityQueue<T>
    {
        int Length { get; }
        void Enqueue(int priority, T value);
        (int Priority, T Value) Dequeue();
    }

    public class GenericPriorityQueue<T> : IGenericPriorityQueue<T>
    {
        public (int priority, T value)[] q;
        private int end=0;
        private int start=0;
        private int Size = 0;

        public int Length => Size;

        public GenericPriorityQueue()
        {
            q = new (int Priority, T Value)[1];
        }


        // Enqueue
        public void Enqueue(int priority, T value)
        {
            //throw new NotImplementedException();
            if(q.Length == Size)
            {
                Grow();
            }
                q[end] = (priority, value);
                end++;
                Size++;
        }
        public (int Priority, T Value) Dequeue()
        {
            //throw new System.NotImplementedException();
            (int Priority, T Value) newarray = q[start];
            //q[start] = null;
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
                //q[end] = null;
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
            (int Priority, T Value)[] newarray = new (int Priority, T Value)[q.Length * 2];
            for (int i=0; i < q.Length; i++)
            {
                newarray[i] = q[i];
            }
            q = newarray;
        }

    }
}