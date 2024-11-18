using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._4
{
    internal class Utility
    {
        public void  SwapFake(int a, int b)
        {
            int tg = a;
            a = b;
            b = tg;
        }
        public void SwapReally(ref int a, ref int b)
        {
            int tg = a;
            a = b;
            b = tg;
        }
        public void AreaCircle(double radius, out double area)
        {
            area = 2 * Math.PI * radius;   
        }
    }
}
