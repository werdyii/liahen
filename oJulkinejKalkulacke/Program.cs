using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liahen
{
    class oJulkinejKalkulacke
    {
        static void Main(string[] args)
        {
            int i;
            string sLine = Console.ReadLine();
            int n = sLine.Length;

            Tree myTree = new Tree("+");
            myTree.left = new Tree("*"); myTree.right = new Tree("*");
            myTree.left.left = new Tree("12"); myTree.left.right = new Tree("3");
            myTree.right.left = new Tree("4"); myTree.right.right = new Tree("5");
            compute(myTree);
            System.out.println("Result is " + values.pop());//expect 12*3+4*5 = 56
            System.out.println("Result (improved method) is " + computerWithoutstack(myTree));

        }


        class TreeArithmatic
        {

            static Stack<Int32> value = new Stack<int>();

            private static Boolean ifOperator(String s)
            {
                return s.Equals("+") || s.Equals("-") || s.Equals("*") || s.Equals("/");
            }

            private static int  compute(char op, int a, int b)
            {
                switch (op)
                {
                    case '+': return a + b;
                    case '-': return a - b;
                    case '*': return a * b;
                    case '/': return a / b;
                }
                return -1;
            }

            public static void compute(Tree myTree)
            {
                if(myTree != null)
                {
                    compute(myTree.left);
                    compute(myTree.right);
                    if (!ifOperator(myTree.value))
                    {
                        value.Push(Int32.Parse(myTree.value));
                    }
                }
            }
        }

        // definovanie jednoducheho stromu
        class Tree
        {
            public Tree left;
            public Tree right;
            public String value;

            public Tree(String s)
            {
                value = s;
            }
        }
    }
}
