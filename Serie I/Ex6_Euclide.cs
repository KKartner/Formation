using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class Euclide
    {
        public static int Pgcd(int a, int b)
        {
            bool isTrue = false;
            if (b != 0)
            {
                while (isTrue == false)
                {
                    int reste = a % b;
                    if (reste != 0)
                    {
                        a = b;
                        b = reste;
                    }
                    else
                    {
                        isTrue = true;
                    }
                }
                return b;
            }
            else
            {
                return a;
            }
            
        }

        public static int PgcdRecursive(int a, int b)
        {
            int tmp = Pgcd(a, b);
            return tmp;
        }
    }
}
