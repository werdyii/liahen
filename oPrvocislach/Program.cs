//Rasťo sa prednedávnom v jednej knižke dočítal, že prvočísel je nekonečne veľa...ale už o dve strany neskôr sa dozvedel aj to, že existujú ľubovoľne dlhé úseky po sebe idúcich prirodzených čísel, medzi ktorými nie je ani jedno prvočíslo.A ked na dôvažok zistil, že Bertrandov postulát hovorí, že pre každé N je medzi N a 2N aspoň jedno prvočíslo, mal v tom už dokonalý zmätok.Pomohol by mu program, ktorý by vedel pre zadané intervaly hovoriť, koľko prvočísel vlastne obsahujú.

//Vstup
//Na prvom riadku vstupu je jedno celé číslo T(1≤ T ≤ 20) – počet intervalov, ktoré budú nasledovať.
//Nasleduje T riadkov, v i-tom z nich sú 2 celé čísla a_i, b_i (1 ≤ a_i ≤ b_i ≤ 1 000 000).

//Výstup
//Výstup by mal obsahovať T riadkov, na i-tom z nich jedno celé číslo – počet prvočísel, ktoré ležia medzi a_i a b_i(vrátane).

//Poznámky
//Prvočíslo je prirodzené číslo, ktoré má práve dvoch deliteľov(jednotku a seba samého). Najmenšie prvočísla sú teda 2, 3, 5, 7, 11, ...
//Snaž sa, aby tvoj program bol čo najrýchlejší.Nerátaj zbytočne viackrát to isté.Zbytočne pomalé programy nemusia stihnúť skončiť v časovom limite.

//IN
//3
//3 5
//122 125
//340000 350000

//OUT:
//2
//0
//795

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
