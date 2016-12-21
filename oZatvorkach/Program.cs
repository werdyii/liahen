//Kubko počítal rovnicu.Zložitú rovnicu.Veľmi zložitú rovnicu. Až takú zložitú, že sa niekde pri jej počítaní asi pomýlil. Hľadí teraz nešťastne na trojriadkový výraz plný rôznych zátvoriek a rozmýšľa, či mu tam nejaká nechýba.
//Tvojou úlohou bude napísať program, ktorý Kubkovi zistí, či je jeho výraz dobre uzátvorkovaný alebo nie. Zaujímať nás budú len zátvorky z jeho výpočtu, zvyšok je totiž príliš komplikovaný a zbytočne by nás plietol.
//V dobre uzátvorkovanom výraze môžu zátvorky vyzerať napríklad takto: (), [[]
//[]] a({ }), zle uzátvorkované sú napríklad ))), [))((] a({)}. Teda aby bol výraz dobre uzátvorkovaný, musí mať každá ľavá zátvorka za sebou zodpovedajúcu pravú zátvorku(a naopak). Navyše, v každej takejto dvojici musia byť zátvorky rovnakého typu.

//Vstup
//V prvom riadku vstupu je jedno celé číslo N(1 ≤ N ≤ 100), udávajúce počet riadkov Kubkovho výpočtu.
//Nasleduje N riadkov.Každý z nich obsahuje zátvorky z jedného riadku Kubkovho výpočtu.Presnejšie, každý riadok obsahuje jeden reťazec tvorený aspoň 1 a najviac 100 znakmi ()[]{}.

//Výstup
//Tvoj program by mal vypísať N riadkov – pre každý výraz zo vstupu vypíš ANO alebo NIE, podľa toho, či je dobre uzátvorkovaný.

using System;
using System.Collections;


namespace liahen
{
    class oZatvorkach
    {
        static void Main(string[] args)
        {
            int pocetZatvoriek, i;
            string Line = Console.ReadLine();
            int n = int.Parse(Line);
            while (0 < n--)
            {
                Line = Console.ReadLine();
                pocetZatvoriek = Line.Length;
                if ((pocetZatvoriek % 2) != 0)
                { // je parny pocet zatvoriek?
                    Console.WriteLine("NIE");
                    continue;
                }

                char[] poleZatvoriek = Line.ToCharArray();
                Stack kopa = new Stack();
                bool Odpoved = true;
                for (int x = 0; x < Line.Length; x++)
                {
                    char zatvorka = Line[x];
                    if (zatvorka == '(' || zatvorka == '[' || zatvorka == '{')
                    {
                        kopa.Push(zatvorka);
                    }
                    else
                    {
                        char par = new char();
                        if (zatvorka == ')') par = '(';
                        if (zatvorka == ']') par = '[';
                        if (zatvorka == '}') par = '{';
                        if (kopa.Count > 0 && kopa.Peek().Equals(par))
                        {
                            kopa.Pop();
                        }
                        else
                        {
                            Odpoved = false;
                            break;
                        }
                    }
                }
                if (kopa.Count == 0 && Odpoved)
                {
                    Console.WriteLine("ANO");
                }
                else
                {
                    Console.WriteLine("NIE");
                }
            }
        }
    }
}
