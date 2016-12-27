using System;

namespace liahen
{
    class oPrvocislach
    {
        static void Main(string[] args)
        {
            //nacitaj pocet intervalov
            string Line = Console.ReadLine();
            int n = int.Parse(Line);

            while (0 < n--)
            {
                //nacitaj interval
                Line = Console.ReadLine();
                string[] interval = Line.Split(' '); //rozdelenie nacitaneho retazca na cisla

                //nacitane retazce konvertuj na cisla
                int Min = int.Parse(interval[0]);
                int Max = int.Parse(interval[1]);

                //definuj logicke pole
                bool[] Pole = new bool[Max + 1];
                int i, j;
                //nastav interval ze su vsetky cisla v intervale prvocisla
                for (i = 2; i < (Max + 1); i++)
                {
                    Pole[i] = true;
                }
                //presitkuj interval 
                i = 2;
                while (i * i < Max)
                {
                    if (Pole[i])
                    {       /* pokud je i stale na seznamu (nezkoumej nasobky 4, kdyz jsme uz vyhodili nasobky 2 */
                        j = 2;              /* j bude novy nasobek */
                        while (i * j <= Max)
                        {
                            Pole[j * i] = false; /* cislo slozene */
                            j++;
                        }
                    }
                    i++;
                }
                // spocitaj prvocisla
                j = 0;
                if (Min < 2) Min = 2;
                for (i = Min; i < (Max + 1); i++) { if (Pole[i]) { j++; } }
                // vypis pocet prvocisel v intervale
                Console.WriteLine(j.ToString());
            }
        }
    }
}
