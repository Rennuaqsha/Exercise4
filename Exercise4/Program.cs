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

       
    }
}