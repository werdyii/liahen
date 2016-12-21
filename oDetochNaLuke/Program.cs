//Adamko, Betka a Cilka sa hrajú na lúke.Malý Adamko si vymyslel novú zábavu: Otočí sa smerom k Betke a háda, či je práve Cilka na jeho ľavej alebo pravej strane.Asi sa nedivíš, že jeho staršiu sestru Betku táto hra rýchlo omrzela.Zišiel by sa jej program, ktorý by Adamkovi odpovedal namiesto nej.

//Vstup
//V prvom riadku vstupu je celé číslo T (1 ≤ T ≤ 50 000) – počet testovacích vstupov.Nasleduje T riadkov, každý z nich obsahuje 6 celých čísel(z rozsahu 0..100) oddelených medzerami.Prvé dve čísla sú súradnice Adamka, druhé dve sú súradnice Betky a tretie dve súradnice Cilky. Žiadne dve deti nestoja na tom istom mieste.

//Výstup
//Pre každý vstup vypíšte jeden riadok výstupu. Ak Cilka stojí na tej istej priamke ako Adamko s Betkou, vypíšte reťazec "rovno", ak stojí na ľavej strane Adamka (ktorý je otočený tak, že pozerá na Betku), vypíšte "vlavo", inak vypíšte "vpravo".

using System;

namespace liahen
{
    class oDetochNaLuke
    {
        static void Main(string[] args)
        {
            float epsilon = 0.0000001f; //presnost vypoctu
            string Line = Console.ReadLine();
            int n = int.Parse(Line);
            float z;
            while (0 < n--)
            {
                Line = Console.ReadLine();
                string[] body = Line.Split(' '); //rozdelenie nacitaneho retayca na cisla
                int[] bod = new int[6];
                for (int i = 0; i < 6; i++)
                {
                    bod[i] = int.Parse(body[i]);   //prevod stringov cisel na integer
                }
                z = ((bod[0] - bod[2]) * (bod[5] - bod[3])) - ((bod[1] - bod[3]) * (bod[4] - bod[2]));
                if (z > epsilon)
                {
                    Console.WriteLine("vpravo");
                }
                else
                {
                    if (z < -epsilon)
                    {
                        Console.WriteLine("vlavo");
                    }
                    else
                    {
                        Console.WriteLine("rovno");
                    }
                }
            }
        }
    }
}
