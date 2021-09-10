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
        public int Length => size;
        public string[] values;
        private int foran = 0;
        private int sist = 0;
        private int size = 0;
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

            if (size == 0)
            {
                throw new Exception("Queue is tom");

            }else if(size > 0){
                size--;
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
                size--;
                         
            return output;

        }

        public void Enqueue(string value)
        {
            if (values.Length == size)
            {
                Grow();
            }
            
            {
                values[sist] = value;
                size++;
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
