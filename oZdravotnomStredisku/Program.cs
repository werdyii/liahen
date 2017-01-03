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
            //List<pacient> cakaren = new List<pacient>();
            //BinStrom<pacient> cakaren = new BinStrom<pacient>();
            Halda<pacient> cakaren = new Halda<pacient>();

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
            //        aTest[i] = "pacient " + (i * 1000 + 1) + " " + rnd.Next(10000, 1000000000);
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
                            Console.WriteLine(cakaren.vyber().cislo);
                            //Console.WriteLine(cakaren.Vyber().cislo);
                            //cakaren.Remove(cakaren.First());
                        }
                        //Console.WriteLine();
                        break;
                    case "pacient":
                        stitok++;
                        cakaren.vloz(new pacient( stitok, Int32.Parse(aLine[1]), Int32.Parse(aLine[2])));
                        //cakaren.Sort();
                        break;
                }
            }
            //Console.WriteLine(" --- Koniec --- Stlač enter ---");
            //Console.ReadLine();
        }

        public class pacient : IComparable<pacient>
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

            public int CompareTo(pacient oPacient)
            {
                if (oPacient.priorita == this.priorita)
                    if (oPacient.poradie > this.poradie)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    };
                if (oPacient.priorita > this.priorita) return 1;
                else return -1;
            }
        }


        // Druhy pokus
        class BinStrom<T> where T : IComparable<T>
        {
            private T _data;
            private BinStrom<T> _pravy, _lavy;
            private int _pocet;

            public BinStrom()
            {
                this._data = default(T);
                this._pravy = null;
                this._lavy = null;
                this._pocet = 0;
            }

            public BinStrom(T hodnota)
            {
                this._data = hodnota;
                this._pravy = null;
                this._lavy = null;
                this._pocet = 1;
            }

            public T DataUzlu
            {
                get { return this._data; }
                set { this._data = value; }
            }

            public BinStrom<T> LavyPodstrom
            {
                get { return this._lavy; }
                set { this._lavy = value; }
            }

            public BinStrom<T> PravyPodstrom
            {
                get { return this._pravy; }
                set { this._pravy = value; }
            }

            public int Count
            {
                get { return this._pocet; }
            }

            public void Vlozit(T novaHodnota)
            {
                this._pocet++;

                if (this.DataUzlu == null)
                {
                    this.DataUzlu = novaHodnota;
                }
                else
                {
                    T hodnotaAktualnehoUzlu = this.DataUzlu;

                    if (hodnotaAktualnehoUzlu.CompareTo(novaHodnota) > 0)
                    {
                        if (this.LavyPodstrom == null)
                        {
                            this.LavyPodstrom = new BinStrom<T>(novaHodnota);
                        }
                        else
                        {
                            this.LavyPodstrom.Vlozit(novaHodnota);
                        }
                    }
                    else
                    {
                        if (this.PravyPodstrom == null)
                        {
                            this.PravyPodstrom = new BinStrom<T>(novaHodnota);
                        }
                        else
                        {
                            this.PravyPodstrom.Vlozit(novaHodnota);
                        }
                    }

                }

            }

            public void PrechodStromom()
            {
                if (this.LavyPodstrom != null)
                {
                    this.LavyPodstrom.PrechodStromom();
                }
                Console.Write(this.DataUzlu.ToString());
                if(this.PravyPodstrom != null)
                {
                    this.PravyPodstrom.PrechodStromom();
                }
            }

            public T Vyber()
            {
                this._pocet++;
                if (this.LavyPodstrom != null)
                {
                    return(this.LavyPodstrom.Vyber());
                    
                }
                else
                {
                    T v = this.DataUzlu;
                    this.DataUzlu = default(T);
                    return v;
                }                
            }


        } 

        class Halda<T> where T : IComparable<T>
        {
            private int N; // počet prvkov v halde
            int max;
            T[] pole;      // reprezantacia haldy v poli

            // Inicializacia haldy
            public Halda()
            {
                this.N = 0;     
                max = 250000;
                this.pole = new T[max];
            }

            // Vrati počet prvkov v halde
            public int Count
            {
                get { return this.N; }
            }

            public void vymen(int i, int j)
            {
                T tmp = pole[i];
                pole[i] = pole[j];
                pole[j] = tmp;
            }

            public void vloz(T hodnota)
            {

                this.N++;
                int potomok = this.N;
                int rodic = potomok / 2;
                pole[potomok] = hodnota;

                // Bubli Hore;
                while ((potomok > 1) && ( pole[rodic].CompareTo(pole[potomok]) > 0) )
                {
                    vymen(rodic, potomok);
                    potomok = rodic;
                    rodic = rodic / 2;
                }
            }

            public T vyber()
            {
                T v = pole[1];
                pole[1] = pole[this.N];
                pole[this.N] = default(T);
                this.N--;

                //Bubli Dolu 
                int koren = 1;
                int rodic;
                int pravy = (2 * koren) + 1;
                int lavy = (2 * koren);
                while ( (lavy <= this.N) )
                {
                    rodic = koren;
                    if (pole[rodic].CompareTo(pole[lavy]) > 0) { rodic = lavy; }
                    if ((pravy <= this.N) && (pole[rodic].CompareTo(pole[pravy]) > 0)) { rodic = pravy; }
                    if(rodic == koren){ break; }
                    vymen(koren, rodic);

                    koren = rodic;
                    pravy = (2 * koren) + 1;
                    lavy = (2 * koren);
                }
                return v;
            }
        }

    }
}
