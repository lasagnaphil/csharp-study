using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellphoneProblem
{
    struct Vector2i
    {
        public int x;
        public int y;

        public Vector2i(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            Vector2i other = (Vector2i)obj;
            return (this.x == other.x) && (this.y == other.y);
        }

        public override int GetHashCode()
        {
            int result = 17;
            result += 31*result + x;
            result += 31*result + y;
            return result;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", x, y);
        }

        public static Vector2i operator +(Vector2i a, Vector2i b)
        {
            return new Vector2i(a.x + b.x, a.y + b.y);
        }

        public static Vector2i operator -(Vector2i a, Vector2i b)
        {
            return new Vector2i(a.x - b.x, a.y - b.y);
        }

        public static Vector2i operator *(Vector2i a, int k)
        {
            return new Vector2i(k*a.x, k*a.y);
        }

        public static Vector2i operator *(int k, Vector2i a)
        {
            return new Vector2i(k*a.x, k*a.y);
        }

        public static bool operator ==(Vector2i a, Vector2i b)
        {
            return a.x == b.x && a.y == b.y;
        }

        public static bool operator !=(Vector2i a, Vector2i b)
        {
            return !(a == b);
        }
    }

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
            Vector2i a = new Vector2i(1, 2);
            Vector2i b = new Vector2i(3, 4);

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * 2);
            Console.WriteLine(3 * b);

            Console.WriteLine(new Vector2i(1, 2) == new Vector2i(1, 2));
            Console.WriteLine(new Vector2i(1, 2) != new Vector2i(3, 4));

            int? mysteryNum = null;

            int actualNum;
            if (mysteryNum.HasValue)
                actualNum = mysteryNum.Value;
            else
                Console.WriteLine("Mystery num is undefined!");

            actualNum = mysteryNum ?? 0;
            Console.WriteLine(actualNum);
            actualNum = mysteryNum.GetValueOrDefault();
            Console.WriteLine(actualNum);

            Console.ReadKey();
        }

        static void Test()
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
