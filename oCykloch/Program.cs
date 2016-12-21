//Na vstupe je postupnosť celých čísel.Vašou úlohou je túto postupnosť načítať a vypísať na výstup.

//Vstup a výstup
//V prvom riadku vstupu je buď celé kladné číslo N, alebo nula.
//Ak je tam kladné číslo, nasleduje N riadkov, v každom z nich je jedno celé číslo. Tieto čísla načítajte a v tom istom poradí ich vypíšte (každé na samostatný riadok).
//Ak je v prvom riadku nula, čítajte a vypisujte čísla(opäť každé na samostatný riadok), až kým znova nenačítate nulu.Túto nulu už nevypisujte.
//Môžete predpokladať, že vypísať budete musieť aspoň jedno a nanajvýš 12345 čísel.Všetky čísla na vstupe sú medzi 0 a 1 000 000 vrátane. (Pozor! Do 16-bitovej premennej, akou je napríklad integer v Pascale, sa niektoré čísla nezmestia!)
//Za údajmi, ktoré máte spracovať, môže na vstupe ešte nasledovať úplne hocičo.Tento zvyšok vstupu môžete ignorovať, netreba ho ani len prečítať.


using System;

namespace liahen
{
    class oCykloch
    {
        static void Main(string[] args)
        {
            string Line = Console.ReadLine();
            int prveCislo = int.Parse(Line);
            if (prveCislo == 0)
            {
                do
                {
                    Line = Console.ReadLine();
                    int cislo = int.Parse(Line);
                    if (cislo == 0) break;
                    Console.WriteLine(cislo.ToString());
                } while (true);
            }
            else
            {
                for (int i = 0; i < prveCislo; i++)
                {
                    Line = Console.ReadLine();
                    int cislo = int.Parse(Line);
                    Console.WriteLine(cislo.ToString());
                }
            }

        }
    }
}
