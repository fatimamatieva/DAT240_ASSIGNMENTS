using System;

namespace UiS.Dat240.Lab1.Queues
{
    public interface IObjectQueue
    {
        int Length { get; }
        void Enqueue(object value);
        object Dequeue();
    }

    public class ObjectQueue : IObjectQueue
    {
        public object[] q;
        private int end=0;
        private int start=0;
        private int Size = 0;

        public int Length => Size;

        public ObjectQueue()
        {
            q = new object[1];
        }


        // Enqueue
        public void Enqueue(object value)
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
        public object Dequeue()
        {
            //throw new System.NotImplementedException();
            object newarray = q[start];
            q[start] = null;
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
                q[end] = null;
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
            object[] newarray = new object[q.Length * 2];
            for (int i=0; i < q.Length; i++)
            {
                newarray[i] = q[i];
            }
            q = newarray;
        }

    }
}