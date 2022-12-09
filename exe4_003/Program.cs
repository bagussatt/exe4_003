using System;
using System.ComponentModel.DataAnnotations;

namespace exe4_003
{
    class stack
    {
        private String[] bagus = new string[23];
        private int top;
        private int max;

        public stack()
        {
            top = -1;
            max = bagus.Length;
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
                bagus[top] = Console.ReadLine();
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
                Console.WriteLine("Poped element: " + bagus[top]);
                top--;
                return top;
            }
        }
        public void Display()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Kosong");
                return ;
            }
            else
            {
                for (int i = 0; i<= top; i++)
                {
                    Console.WriteLine("Element[" + (i + 1) + "] : " + bagus[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            stack l = new stack();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n --------Exe4 Stack Array Menu----------");
                Console.WriteLine("1. Push Element");
                Console.WriteLine("2. Pop Element");
                Console.WriteLine("3. Display element");
                Console.WriteLine("4. Exit Program");
                Console.WriteLine("\n Enter Your Choice :  ");
                string input = Console.ReadLine();
                char ch = Convert.ToChar(input == "" ? "0" : input);
                switch (ch)
                {
                    case '1':
                        l.push();
                        break;
                    case '2':
                        l.pop();
                        break;
                    case '3':
                        l.Display();
                        break;
                    case '4':
                        return ;
                    default:
                        Console.WriteLine("\n invalid choice");
                        break;
                }
            }
        }
    }
}
