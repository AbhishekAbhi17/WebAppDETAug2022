using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class swapdemo
    {
        private static object x;
        private static object y;

        public static void swap(ref int x, ref int y)
            {
            
                int tempswap = x;
                x = y;
                y = tempswap;
            }
        //public static void Main()
        //{
        //  int     
            


        //}
        
    }
}
