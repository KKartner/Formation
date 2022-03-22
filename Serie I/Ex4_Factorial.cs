using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class Factorial
    {
        public static int Factorial_(int n)
        {
            int tmp = 1;
            for (int m = 1; m <= n; m++)
            {
                tmp = tmp * m;
            }
            return tmp;
        }

        public static int FactorialRecursive(int n)
        {
            int tmp = Factorial_(n);
            return tmp;
        }
    }
}
