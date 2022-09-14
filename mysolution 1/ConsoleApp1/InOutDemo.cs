using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
        public class InOutDemo
        {
            public static void APlusB(ref int a, int b)
            { a += b; }
            public static void Divide(int a, int b, out int res, out int rem)
            {
                rem = a % b;
                res = a / b;
            }
            public static void Main()
            {
                int a = 10;
                int b = 10;
                APlusB(ref a, b);
                int res, rem;
                Divide(a, b, out res, out rem);
                Console.WriteLine($"a={a}, b={b}, result={res},remainder={rem}");

            }
        }
    }




