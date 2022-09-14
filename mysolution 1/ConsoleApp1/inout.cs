using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class inout
    {
        public static void APLusB(ref int a, int b)
        { a += b; }
        public static void main()
        {
            int a = 10;
            int b = 20;
            APLusB(ref a, b);
            Console.WriteLine($"a={a},{b}");
        }
    }
}
