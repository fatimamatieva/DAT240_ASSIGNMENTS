using System;
using UiS.Dat240.Lab1.Queues;

namespace UiS.Dat240.Lab1
{
    /// <summary>
    /// This is a holder class which holds
    /// the submissions for the different tasks
    /// </summary>
    public static class TestSubmissions
    {
        // This is a test endpoint, make this function
        // return an instance of your implementation
        public static IStringQueue CreateStringQueue()
        {
            
            return new StringQueue();
        }

        public static IObjectQueue CreateObjectQueue()
        {
            return new ObjectQueue
            //throw new NotImplementedException();
        }

        public static IGenericQueue CreateGenericQueue()
        {
            return new CreateGenericQueue();
        }

        public static IGenericPriorityQueue CreatePriorityQueue()
        {
            return new CreatePriorityQueue()
        }
    }
}
