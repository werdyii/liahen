using System;
using System.Collections.Generic;
using System.Linq;

namespace liahen
{
    class oZdravotnomStredisku
    {
        static void Main(string[] args)
        {
            string sLine;
            int row = 0;
            int stitok = 0;
            List<pacient> cakaren = new List<pacient>();

            //int max = 250000;
            //Random rnd = new Random();
            //string[] aTest = new string[max];
            //for (int i = 0; i < (max - 1); i++)
            //{

            //    if ((i % 2) == 0)
            //    {
            //        aTest[i] = "dalsi";
            //    }
            //    else
            //    {
            //        aTest[i] = "pacient " + (i*1000 + 1) + " " + rnd.Next(10000, 1000000000);
            //    }

            //}
            //aTest[max - 1] = "koniec";

            //string[] aTest = {  "dalsi",
            //                    "pacient 1 10",
            //                    "pacient 2 2",
            //                    "pacient 13 5",
            //                    "dalsi",
            //                    "pacient 17 0",
            //                    "pacient 999 100",
            //                    "dalsi",
            //                    "pacient 3 5",
            //                    "dalsi",
            //                    "dalsi",
            //                    "dalsi",
            //                    "dalsi",
            //                    "dalsi",
            //                    "koniec"
            //};

            while ((sLine = Console.ReadLine().Trim().ToLower()) != "koniec")
            //while ((sLine = aTest[row].Trim().ToLower()) != "koniec")
            {
                row++;
                //Console.WriteLine(sLine);
                var aLine = sLine.Split(' ', ',');
                switch (aLine[0].ToLower())
                {
                    case "dalsi":
                        if (cakaren.Count == 0)
                        {
                            Console.WriteLine("-1");
                        }
                        else
                        {
                            Console.WriteLine(cakaren.First().cislo);
                            cakaren.Remove(cakaren.First());
                        }
                        //Console.WriteLine();
                        break;
                    case "pacient":
                        stitok++;
                        cakaren.Add(new pacient( stitok, Int32.Parse(aLine[1]), Int32.Parse(aLine[2])));
                        cakaren.Sort();
                        break;
                }
            }
            //Console.WriteLine(" --- Koniec --- Stlač enter ---");
            //Console.ReadLine();
        }

        public class pacient : IComparable
        {
            public int poradie;
            public int cislo;
            public int priorita;

            public pacient(int aPoradie, int aCislo, int aPriorita)
            {
                this.poradie = aPoradie;
                this.cislo = aCislo;
                this.priorita = aPriorita;
            }

            public int CompareTo(object obj)
            {
                //(pacient)obj;
                if (((pacient)obj).priorita == this.priorita)
                    if (((pacient)obj).poradie > this.poradie)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    };
                if (((pacient)obj).priorita > this.priorita) return 1;
                else return -1;
            }
        }
    }
}
