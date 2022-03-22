using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_I
{
    public static class Pyramid
    {
        public static void PyramidConstruction(int n, bool isSmooth)
        {
            string symbole = "+";
            bool rotation = false;
            string pyramide = "";
            int somme = 1;
            if (isSmooth)
            {
                for (int i = 0; i < n; i++)
                {

                    int m = n * 2;
                    m = m - somme;
                    m = m / 2;
                    for (int j = 0; j < m; j++)
                    {
                        pyramide = pyramide + " ";
                    }
                    for (int j = 0; j < somme; j++)
                    {
                        pyramide = pyramide + symbole;
                    }
                    Console.WriteLine(pyramide);
                    somme += 2;
                    if (rotation)
                    {
                        symbole = "+";
                        rotation = false;
                    }
                    else
                    {
                        symbole = "-";
                        rotation = true;
                    }
                    pyramide = "";
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    int m = n * 2;
                    m = m - somme;
                    m = m / 2;
                    for (int j = 0; j < m; j++)
                    {
                        pyramide = pyramide + " ";
                    }
                    for (int j = 0; j < somme; j++)
                    {
                        pyramide = pyramide + symbole;
                    }
                    Console.WriteLine(pyramide);
                    somme += 2;
                    pyramide = "";
                }
            }
        }
    }
}
