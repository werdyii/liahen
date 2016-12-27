using System;
using System.Collections.Generic;

namespace liahen
{
    class oStvoruholnikoch
    {

        public static List<int> poleBodov, combination;
        public static int row = 1;
        public static int iPocet = 0;

        // Načítanie vstupných údajov
        public static int[] iBodX,iBodY;

        static void Main(string[] args)
        {
            // Načítanie vstupu 
            string Line = Console.ReadLine();
            int iPocetBodov = int.Parse(Line);
            if (iPocetBodov > 3)
            {
                int iPocetVrcholov = 4;
                poleBodov = new List<int>();
                combination = new List<int>();


                iBodX = new int[iPocetBodov];
                iBodY = new int[iPocetBodov];
                int i = iPocetBodov;

                while (0 < i--)
                {
                    //nacitaj interval
                    Line = Console.ReadLine();
                    string[] sBod = Line.Split(' '); //rozdelenie nacitaneho retazca na cisla

                    //nacitane retazce konvertuj na cisla
                    iBodX[i] = int.Parse(sBod[0]);
                    iBodY[i] = int.Parse(sBod[1]);
                }

                // Vygenerovanie kombinacii bodov 
                for (i = 0; i < iPocetBodov; i++) poleBodov.Add(i);

                go(0, iPocetVrcholov);

                Console.WriteLine(iPocet);

            }
            else {
                Console.WriteLine(iPocet);
            }
            Console.ReadLine();
        }

        public static void go(int offset, int k)
        {
            if (k == 0)
            {
                // Spracovanie jednej kombinacie bodov
                output();
            }
            else
            {
                for (int i = offset; i <= poleBodov.Count - k; ++i)
                {
                    combination.Add(poleBodov[i]);
                    go(i + 1, k - 1);
                    combination.RemoveAt(combination.Count - 1);
                }
            }
        }

        public static void output()
        {

            //Console.Write(row++ + ": ");

            //Console.Write("[{0}, {1}], [{2}, {3}], [{4}, {5}], [{6}, {7}] "
            //    , iBodX[combination[0]], iBodY[combination[0]]
            //    , iBodX[combination[1]], iBodY[combination[1]]
            //    , iBodX[combination[2]], iBodY[combination[2]]
            //    , iBodX[combination[3]], iBodY[combination[3]]);

            if (uhlopriecky(
                  iBodX[combination[0]], iBodY[combination[0]]
                , iBodX[combination[1]], iBodY[combination[1]]
                , iBodX[combination[2]], iBodY[combination[2]]
                , iBodX[combination[3]], iBodY[combination[3]]))
            {
                //Console.Write("TRUE");
                iPocet++;
            }
            //else Console.Write("FALSE");
            //Console.WriteLine();
        }

        public static bool uhlopriecky(int Ax, int Ay, int Bx, int By, int Cx, int Cy, int Dx, int Dy)
        {

            float u1, u2, v1, v2;

            // AB CD  
            u1 = ((Ax - Bx) * (Cy - By)) - ((Ay - By) * (Cx - Bx));
            u2 = ((Ax - Bx) * (Dy - By)) - ((Ay - By) * (Dx - Bx));

            // CD AB
            v1 = ((Cx - Dx) * (Ay - Dy)) - ((Cy - Dy) * (Ax - Dx));
            v2 = ((Cx - Dx) * (By - Dy)) - ((Cy - Dy) * (Bx - Dx));

            if ( testu(u1, u2) && testu(v1,v2)) return true;

            // AD CB
            u1 = ((Ax - Dx) * (Cy - Dy)) - ((Ay - Dy) * (Cx - Dx));
            u2 = ((Ax - Dx) * (By - Dy)) - ((Ay - Dy) * (Bx - Dx));

            // CB AD
            v1 = ((Cx - Bx) * (Ay - By)) - ((Cy - By) * (Ax - Bx));
            v2 = ((Cx - Bx) * (Dy - By)) - ((Cy - By) * (Dx - Bx));

            if (testu(u1, u2) && testu(v1, v2)) return true;

            // AC BD
            u1 = ((Ax - Cx) * (By - Cy)) - ((Ay - Cy) * (Bx - Cx));
            u2 = ((Ax - Cx) * (Dy - Cy)) - ((Ay - Cy) * (Dx - Cx));

            // BD AC
            v1 = ((Bx - Dx) * (Ay - Dy)) - ((By - Dy) * (Ax - Dx));
            v2 = ((Bx - Dx) * (Cy - Dy)) - ((By - Dy) * (Cx - Dx));

            if (testu(u1, u2) && testu(v1, v2)) return true;

            return false;
        }

        private static bool testu(float z1, float z2) {
            float epsilon = 0.0000001f; //presnost vypoctu

            if (z1 > epsilon && z2 < -epsilon )
            {
                return true;
            }
            else { 
            if (z1 < -epsilon && z2 > epsilon)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }

}
