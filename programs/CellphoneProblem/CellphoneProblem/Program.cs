using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellphoneProblem
{
    class Program
    {
        static int Multiply(int a, int b)
        {
            return a*b;
        }

        static int Calculate(Func<int, int, int> func)
        {
            return func(1, 2);
        }

        static Func<int, int, int> GetFunction(char symbol)
        {
            switch (symbol)
            {
                case '+': return (a, b) => a + b;
                case '-': return (a, b) => a - b;
                case '*': return (a, b) => a * b;
                case '/': return (a, b) => a / b;
                default:
                    return (a, b) =>
                    {
                        throw new Exception("Cannot parse operator " + symbol.ToString());
                    };
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Calculate((a, b) => a + b));
            Console.WriteLine(Calculate(Multiply));

            var addFunction = GetFunction('+');
            var multiplyFunction = GetFunction('*');
            Console.WriteLine(addFunction(3, 5));
            Console.WriteLine(GetFunction('*')(3, 5));

            Console.ReadKey();
        }
    }
}
