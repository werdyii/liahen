// Pred kráľom stojí v rade niekoľko mládencov.Kráľ by rád spoznal, ktorý z nich je 
// hrdina Popolvár.To nie je až taká ťažká úloha, keďže o Popolvárovi sa vie, že je na svete najväčší.
// Napíš program, ktorý načíta výšky mládencov a rozhodne, ktorý z nich je Popolvár.

// Vstup
// Vstup obsahuje niekoľko riadkov(najmenej 1, najviac 100). V každom riadku je jedno 
// prirodzené číslo, menšie ako 3000 – výška jedného z mládencov v milimetroch.
// Tvoj program by mal tieto čísla načítavať zo štandardného vstupu 
// ("z klávesnice"), použi teda štandardné funkcie na načítanie – readln, scanf, cin, a pod.

// Výstup
// Tvoj program by mal vypísať jediný riadok a v ňom jediné celé číslo – Popolvárovu výšku v milimetroch.
// Tvoj program by mal toto číslo vypísať na štandardný výstup ("na obrazovku"). 
// Použi teda štandardné funkcie na výpis – writeln, printf, cout, a pod.Nevypisuj 
// nič iné, iba toto jedno číslo (a znak konca riadku).

using System;

namespace liahen
{
    class oPopolvarovi
    {
        static void Main(string[] args)
        {
            int max = 0;
            string Line = Console.ReadLine();
            do
            {
                int vyska = int.Parse(Line);
                if (vyska > max) max = vyska;
                Line = Console.ReadLine();
            }
            while (Line != null);
            Console.WriteLine("{0}", max);
        }
    }
}