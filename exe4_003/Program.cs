using System;

namespace exe4_003
{
    class stack
    {
        private String[] array = new string[23];
        private int top;
        private int max;

        public Stack()
        {
            top = -1;
            max = array.Length;
        }

        public void push()
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                top++;
                Console.WriteLine("Silahkan Masukan Element Yang diinginkan");
                array[top] = Console.ReadLine();
            }
        }
        public int pop()
        {
            if (top == - 1)
            {
                Console.WriteLine("Stack Overflow");
                return -1;
            }
            else
            {
                Console.WriteLine("Poped element")
            }
        }
    }
}
