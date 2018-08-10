using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            NodeStack<char> stack = new NodeStack<char>();
            NodeStack<int> bracket = new NodeStack<int>();
            char[] open = new char[] { '{', '[', '(' };
            char[] close = new char[] { '}', ']', ')' };
            for(int i=0; i<str.Length; i++)
            {
                if(open.Contains(str[i]) || close.Contains(str[i]))
                {
                    if (stack.IsEmpty && close.Contains(str[i]))
                    {
                        Console.WriteLine(i + 1);
                        break;
                    }
                    else if( stack.IsEmpty == false && Array.IndexOf(open, stack.Peek()) == Array.IndexOf(close, str[i])) 
                    {
                        stack.Pop();
                        bracket.Pop();
                    }
                    else
                    {
                        bracket.Push(i + 1);
                        stack.Push(str[i]);
                    }
                }
            }
            if(stack.IsEmpty)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine(bracket.Peek());
            }
            Console.ReadKey();
        }
    }
}
# Stack
