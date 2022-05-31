using System;

namespace Stack_Queue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Creating Stack \n2.Peak and Pop Element \n3.Insert Elements in Queue" +
                "\n4.Delete Elements from queue");
            Console.WriteLine("Enter your option:");
            int option = Convert.ToInt32(Console.ReadLine());
            StackAndQueue stackQueue = new StackAndQueue();
            switch (option)
            {
                case 1:
                    stackQueue.PushElements(70);
                    stackQueue.PushElements(30);
                    stackQueue.PushElements(56);
                    stackQueue.DisplayElements();
                    break;

                case 2:
                    stackQueue.PushElements(70);
                    stackQueue.PushElements(30);
                    stackQueue.PushElements(56);
                    stackQueue.DisplayElements();
                    stackQueue.PeakElement();
                    stackQueue.PopElement();
                    stackQueue.IsEmpty();
                    stackQueue.DisplayElements();
                    break;

                case 3:
                    stackQueue.CreateQueue(56);
                    stackQueue.CreateQueue(30);
                    stackQueue.CreateQueue(70);
                    stackQueue.DisplayQueueElements();
                    break;

                case 4:
                    stackQueue.CreateQueue(56);
                    stackQueue.CreateQueue(30);
                    stackQueue.CreateQueue(70);
                    stackQueue.DisplayQueueElements();
                    stackQueue.DeleteQueueElements();
                    stackQueue.DisplayQueueElements();
                    break;

                default:

                    break;
            }
        }
    }
}