//Práve zazvonilo, poslední chalani vybehli zo šatne a utekajú do telocvične.Začína hodina telesnej výchovy a všetci vedia, aký prísny je ich telocvikár, známy naširoko-naďaleko pod menom ujo Marián.Ak sa rýchlo nezoradia na nástup, určite ich zase nechá behať okolo telocvične, klikovať, ba možno sa niektorým, čo to nestihnú, ujde aj jedna-dve švihadlom.
//Chlapci už vedia, ako má podľa uja Mariána taký nástup vyzerať. Musia stáť v dvoch rovnako dlhých radoch.V každom rade musia byť zoradení podľa veľkosti (najväčší stojí z pohľadu uja Mariána naľavo). No a v každej za sebou stojacej dvojici musí byť predný chlapec najviac taký vysoký ako ten za ním, aby ujo Marián na všetkých videl.

//Vstup
//V prvom riadku vstupu je celé číslo N (1≤N≤5 000). Chlapcov v telocvični je 2N.Nasleduje 2N riadkov, každý z nich obsahuje jedno celé číslo(medzi 1 a 2 000 000 000) – výšku jedného z chlapcov v nanometroch.Tieto čísla nemusia byť navzájom rôzne, t.j.niektorí chlapci môžu byť rovnako vysokí.


//Výstup
//Tvoj program by mal vypísať 2N riadkov. Prvých N bude obsahovať výšky chlapcov v zadnom rade, druhých N výšky chlapcov v prednom rade.Oba rady vypisujte zľava doprava, t.j.začínajúc najvyšším.
//Ak je viac možných riešení, vypíšte ľubovoľné z nich.

using System;

namespace liahen
{
    class oTelesnejVychove
    {
        static void Main(string[] args)
        {
            //nacitaj pocet ziakov
            string Line = Console.ReadLine();
            int n = int.Parse(Line);
            int[] ziaci = new int[2 * n];

            //nacitat nesporiadane pole ziakov
            for (int i = 0; i < 2 * n; i++)
            {
                string vyska = Console.ReadLine();
                ziaci[i] = int.Parse(vyska);
            }

            //zotriedit pole od najvecieho po najmensi metodou HeadSort
            //ulozPole(ref ziaci);
            HeapSort(ref ziaci);

            //vypisat prvy rad ziakov
            for (int i = (2 * n) - 1; i >= 0; i = i - 2)
            {
                Console.WriteLine(ziaci[i].ToString());
            }

            //vypisat druhy rad ziakov
            for (int i = (2 * n) - 2; i >= 0; i = i - 2)
            {
                Console.WriteLine(ziaci[i].ToString());
            }
        }

        static void HeapSort(ref int[] array)
        {
            int _Count = array.Length;
            int _K = (_Count / 2) + 1;
            int _R = _Count;
            while (_K > 1)
            {
                _K--;
                insertHeapSort(ref array, _K, _R);
            }
            while (_R > 1)
            {
                int _Pom = array[0];
                array[0] = array[_R - 1];
                array[_R - 1] = _Pom;
                _R--;
                insertHeapSort(ref array, _K, _R);
            }
        }

        private static void insertHeapSort(ref int[] array, int k, int r)
        {
            int _I = k;
            int _J = 2 * _I;
            int _Pom = array[_I - 1];
            while (_J <= r)
            {
                if (_J < r)
                {
                    if (array[_J - 1] < array[_J]) { _J++; }
                }
                if (_Pom > array[_J - 1])
                {
                    break;
                }
                array[_I - 1] = array[_J - 1];
                _I = _J;
                _J = 2 * _I;
            }
            array[_I - 1] = _Pom;
        }
    }
}
