using System;

namespace Stack_Queue
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Creating Stack");
            Console.WriteLine("Enter your option:");
            int option = Convert.ToInt32(Console.ReadLine());
            StackAndQueue stack = new StackAndQueue();
            switch (option)
            {
                case 1:
                        stack.PushElements(70);
                        stack.PushElements(30);
                        stack.PushElements(56);
                        stack.DisplayElements();
                        break;

                case 2:

                    break;

                default:

                    break;
            }
        }
    }
}