using System;

namespace UiS.Dat240.Lab1.Queues
{
    public interface IStringQueue
    {
        int Length { get; }
        void Enqueue(string value);
        string Dequeue();
    }
    public class StringQueue : IStringQueue

    {
        public int Length => stor;
        public string[] values;
        private int foran = 0;
        private int sist = 0;
        private int stor = 0;
        public StringQueue()
        {
            values = new string[10];
            var newValues = new string[values.Length * 2];
            values = newValues;
        }

        public string Dequeue()
        {
            string newArray = values[foran];
            values[foran] = null;

            if (stor == 0)
            {
                throw new Exception("Queue is tom");

            }else if(stor > 0){
                stor--;
                for(int i= 1; i < values.Length; i++){
                    values[i-1] = values[i];
                }
                sist--;
                values[sist] = null;
                if(foran == sist){
                    foran = 0;
                }
                return newArray;
            }
            string output = values[0];
                stor--;
                         
            return output;

        }

        public void Enqueue(string value)
        {
            if (values.Length == stor)
            {
                Grow();
            }
            
            {
                values[sist] = value;
                stor++;
                sist++;
            }

        }


        public void Grow(){
            var newValues = new string[values.Length * 2];
            values.CopyTo(newValues, 0);
            values = newValues;


        }


    }
}