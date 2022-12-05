using System;


namespace Exercise_4
{
    class node
    {
        public int info;
        public node next;
        private int[] rennu = new int[68];
        int top;
        public node(int i, node n)
        {
            info = i;
            next = n;
        }
    }

    class stack
    {
        node top;
        public stack()
        {
            top = null;
        }

        bool empty()
        {
            return top == null;
        }

        public void pop()
        {
            Console.WriteLine("\n the poped elements is: " + top.info);
            top = top.next; // make top point to the next node is squence
        }
    }
}