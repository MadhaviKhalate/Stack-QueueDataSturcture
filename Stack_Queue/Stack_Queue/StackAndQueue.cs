using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{
    internal class StackAndQueue
    {
        private Node top;
        private Node head = null;
        public StackAndQueue()
        {
            this.top = null;
        }
        public void PushElements(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                this.top = node;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} is pushed into Stack", value);
        }
        public void DisplayElements()
        {
            Node temp = this.top;
            if (this.top == null)
            {
                Console.WriteLine("Stacks is Empty");
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }

        public void PeakElement()
        {
            Console.WriteLine();
            if (this.top == null)
            {
                Console.WriteLine("The Stack is Empty");
                return;
            }
            Console.WriteLine("{0} is top of the stack", this.top.data);
        }
        public void PopElement()
        {
            if (this.top == null)
            {
                Console.WriteLine("The Stack is Empty");
                return;
            }
            Console.WriteLine("{0} is popped element from stack", this.top.data);
            this.top = this.top.next;
        }
        public void IsEmpty()
        {
            while (this.top != null)
            {
                PeakElement();
                PopElement();
            }
        }
    }
}
