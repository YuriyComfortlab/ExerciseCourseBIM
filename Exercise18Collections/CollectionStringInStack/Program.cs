/*Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы. 
 * Проверить, корректно ли в ней расставлены скобки. Например, в строке ([]{})[] скобки расставлены корректно, 
 * а в строке ([]] — нет. Указание: задача решается однократным проходом по символам заданной строки слева направо; 
 * для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая, каждая закрывающая скобка 
 * в строке должна соответствовать скобке из вершины стека (при этом скобка с вершины стека снимается); 
 * в конце прохода стек должен быть пуст.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionStringInStack
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "({}{[]{}()}{}";
            Stack<char> stk = new Stack<char>();
            bool trouble = false;
            Console.WriteLine(str);
            foreach (var item in str)
            {
                switch (item)
                {
                    case '(':
                        stk.Push(')');
                        break;

                    case '[':
                        stk.Push(']');
                        break;

                    case '{':
                        stk.Push('}');
                        break;

                    case ')':
                        trouble = PopStack(stk, item);
                        break;

                    case ']':
                        trouble = PopStack(stk, item);
                        break;
                    case '}':
                        trouble = PopStack(stk, item);
                        break;
                }
            }
            if (trouble || stk.Count > 0)
            {
                Console.WriteLine("Скобки не корректны");
            }
            else
            {
                Console.WriteLine("Скобки корректны");
            }
            Console.ReadKey();

        }
        static bool PopStack(Stack<char> stk, char item)
        {
            if (stk.Count > 0 && item == stk.Peek())
            {
                stk.Pop();
                return false;
            }
            else
            {
                return true;

            }
        }
    }
}
