using System;
using System.Collections.Generic;

namespace liahen
{
    class oSireniKlebiet
    {
        static void Main(string[] args)
        {
            //int row = 0;
            //string[] aVstup = {
            //    "5",
            //    "Julka",
            //    "Misof",
            //    "Monika",
            //    "Palo",
            //    "YoYo",
            //    "5",
            //    "Julka YoYo",
            //    "YoYo Misof",
            //    "Misof Julka",
            //    "Palo Monika",
            //    "Misof Monika"
            //};

            string sLine = Console.ReadLine().Trim().ToLower();
            //string sLine = aVstup[row++].Trim().ToLower();
            var pocetVrcholov = Int32.Parse(sLine);
            // počet vrcholov <1, 100>


            // Načítanie bodov
            Dictionary<string,int> vrchol = new Dictionary<string, int>();
            for (int i = 0; i < pocetVrcholov; i++)
            {
                sLine = Console.ReadLine().Trim().ToLower();
                //sLine = aVstup[row++].Trim().ToLower();
                vrchol.Add(sLine, i);
            }

            sLine = Console.ReadLine().Trim().ToLower();
            //sLine = aVstup[row++].Trim().ToLower();
            var pocetHran = Int32.Parse(sLine);

            // Reprezentacia hran neorientovaneho grafu do matice
            Boolean[,] aHran = new Boolean[pocetVrcholov, pocetVrcholov];
            for (int i = 0; i < pocetHran; i++)
            {
                sLine = Console.ReadLine().Trim().ToLower();
                //sLine = aVstup[row++].Trim().ToLower();
                var aLine = sLine.Split(' ', ',');
                int zBodu = vrchol[aLine[0]];
                int doBodu = vrchol[aLine[1]];
                aHran[zBodu, doBodu] = true;
                // Graf nie je orientovany a klebeta sa šíri oboma smermi
                aHran[doBodu, zBodu] = true;
            }

            // Ak je iba jeden KPS tak sa klebeta rozširi k samemu sebe 
            //if (pocetVrcholov < 2) {
            //    Console.WriteLine("ANO");
            //    Console.ReadLine();
            //    return;
            //}

            // Ak je počet hran menší o dva ako počet uzlov klebeta sa nerozšíri 
            if (pocetVrcholov - 1 > pocetHran) {
                Console.WriteLine("NIE");
                //Console.ReadLine();
                return;
            }

            Boolean[] aCesta = new Boolean[pocetVrcholov];
            Queue<int> BFS = new Queue<int>();  
            BFS.Enqueue(0); // Do fronty vložim prví bod i = 0
            aCesta[0] = true; // prvý bod nastavime ako navštivený
            int pocetNavstivenychVrcholov = 1;

            // Začnem prechádzať stromom pokial budu vo fronte niake body
            while (BFS.Count > 0)
            {
                int v = BFS.Dequeue();
                //Z tohto bodu môžem isť do bodov
                for(int i = 0; i < pocetVrcholov; i++)
                {
                    if ( aHran[v,i] == true)
                    {
                        if (!aCesta[i])
                        {
                            BFS.Enqueue(i);
                            aCesta[i] = true;
                            pocetNavstivenychVrcholov++;
                        } 
                    } 
                }              
            }

            if (pocetNavstivenychVrcholov == pocetVrcholov)
            {
                Console.WriteLine("ANO");
                // Console.ReadLine();
            }
            else
            {
                Console.WriteLine("NIE");
                // Console.ReadLine();
            }
            return;
        }
    }
}
