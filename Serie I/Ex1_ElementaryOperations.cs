using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class ElementaryOperations
    {
        public static void BasicOperation(int a, int b, char operation)
        {
            int result = 0;
            bool isTrue = false;
            switch (operation)
            {
                case '+':
                    result = a + b;
                    isTrue = true;
                    break;
                case '-':
                    result = a - b;
                    isTrue = true;
                    break;
                case '*':
                    result = a * b;
                    isTrue = true;
                    break;
                case '/':
                    if (b == 0)
                    {
                        isTrue = false;
                    }
                    else
                    {
                        result = a / b;
                        isTrue = true;
                    }
                    break;
                default:
                    isTrue = false;
                    break;
            }

            if (isTrue)
            {
                Console.WriteLine($"{a} {operation} {b} = {result}");
            }
            else
            {
                Console.WriteLine($"{a} {operation} {b} = Operation impossible");
            }
        }

        public static void IntegerDivision(int a, int b)
        {
            int calcul = a / b;
            int reste = calcul % 2;
            if (reste == 1)
            {
                Console.WriteLine($"{calcul} = {a} * {b} + {reste}");
            }
            else
            {
                Console.WriteLine($"{calcul} = {a} * {b}");
            }
        }

        public static void Pow(int a, int b)
        {
            if (b < 0)
            {
                Console.WriteLine("Operation invalide");
            }
            else
            {
                double result = Math.Pow(a, b);
                Console.WriteLine(a + " ^ " + b + " = " + result);
            }
        }
    }
}
