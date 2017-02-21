using System;
using System.Collections.Generic;

namespace liahen
{
    class oJulkinejKalkulacke
    {
        static void Main(string[] args)
        {
            string sLine = Console.ReadLine();
            while (sLine != "")
            {
                TreeArithmatic myArithmatic = new TreeArithmatic();
                myArithmatic.BuildParseTree(sLine);
                myArithmatic.compute(myArithmatic.currentTree);
                Console.WriteLine(myArithmatic.myResult());
                sLine = Console.ReadLine();
            }

            //expect 12*3+4*5 = 56
            //Tree myTree = new Tree("+");
            //myTree.left = new Tree("*"); myTree.right = new Tree("*");
            //myTree.left.left = new Tree("12"); myTree.left.right = new Tree("3");
            //myTree.right.left = new Tree("4"); myTree.right.right = new Tree("5");
        }

        class TreeArithmatic
        {

            static Stack<Int32> value;
            public Tree currentTree;

            public TreeArithmatic()
            {
               value  = new Stack<int>();
            }

            private static Boolean ifOperator(String s)
            {
                return s.Equals("+") || s.Equals("-") || s.Equals("*") || s.Equals("/");
            }

            public void BuildParseTree(string AritmmeticExpress)
            {
                Stack<Tree> tStack = new Stack<Tree>();
                currentTree = new Tree("");
                tStack.Push(currentTree);
                
                for (int x = 0; x < AritmmeticExpress.Length; x++)
                {
                    char ch = AritmmeticExpress[x];

                    switch (ch)
                    {
                        case '(':
                            currentTree.left = new Tree("");
                            tStack.Push(currentTree);
                            currentTree = currentTree.left;
                            break;
                        case '+':
                        case '-':
                        case '*':
                        case '/':
                            currentTree.value = ch.ToString();
                            currentTree.right = new Tree("");
                            tStack.Push(currentTree);
                            currentTree = currentTree.right;
                            break;
                        case ')':
                            currentTree = tStack.Pop();
                            break;
                        default:
                            currentTree.value = ch.ToString();
                            Tree parent = tStack.Pop();
                            currentTree = parent;
                            break;
                    }
                }
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

            public void compute(Tree myTree)
            {
                if(myTree != null)
                {
                    compute(myTree.left);
                    compute(myTree.right);
                    if (!ifOperator(myTree.value))
                    {
                        value.Push(Int32.Parse(myTree.value));
                    }
                    else
                    {
                        int a = value.Pop();
                        int b = value.Pop();
                        char op = Char.Parse(myTree.value);
                        int tmpResult = compute(op, b, a);
                        value.Push(tmpResult);
                    }
                }
            }

            public string myResult()
            {
                //return "Result is " + value.Pop();
                return  value.Pop().ToString();
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
