﻿using System;

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
        //  to create an anonymous function.
        public int Length => lengde;
        public string[] values;
        private int foran = 0;
        private int sist = 0;
        private int lengde = 0;
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

            if (lengde == 0)
            {
                throw new Exception("Queue is tom");

            }else if(lengde > 0){
                lengde--;
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
                lengde--;
                         
            return output;

        }

        public void Enqueue(string value)
        {
            if (values.Length == lengde)
            {
                Grow();
            }
            
            {
                values[sist] = value;
                lengde++;
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