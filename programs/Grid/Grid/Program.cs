using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            Grid<int> grid = new Grid<int>(5, 5, 1);
            grid.Set(3, 3, 2);
            grid.Set(3, 2, 4);
            grid.SetItemsInRect(0, 0, 2, 2, 5);
            int i = 1;
            List<int> nums = grid.ToList();
            foreach (int num in nums)
            {
                Console.Write(num);
                if (i % grid.Width == 0) Console.WriteLine();
                i++;
            }
            Console.ReadKey();
        }
    }
}
