using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace liahen
{
    class oStvoruholnikoch
    {

        static void Main(string[] args)
        {
            int pocet = 4;
            int c = 0;
            int[,] pole = { {0,0}, {0,6}, {6,6}, {6,0} };

            for (var i = 1; i <= pocet; i++)
            {
                for (var j = 1; j <= pocet; j++)
                {
                    if (i != j)
                        for (var k = 1; k <= pocet; k++)
                        {
                            if ((i == k) || (j == k))
                                continue;
                            for (var l = 1; l <= pocet; l++)
                            {
                                if ((i == l) || (j == l) || (k == l))
                                    continue;

                                // tvorba kombinacii
                                Console.WriteLine("{0},{1},{2},{3}", i, j, k, l);
                                c++;

                                // test ci je to stvorec
                                // výpočítať vnutorne uhly
                                // ak ich súčet nieje  
                                var v1 = new Vector((pole[j - 1, 0] - pole[i - 1, 0]) , ( pole[j - 1, 0] - pole[i - 1, 0]));
                                var uhol1 = Math.Atan2()

                                // testc ci je konkavny alebo konvexny


                            }
                        }
                }
            }
            Console.WriteLine("Počet variacii {0}", c);
            Console.ReadLine();
        }
    }
}
