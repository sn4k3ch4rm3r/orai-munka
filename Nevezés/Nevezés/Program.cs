using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace Nevezés
{
    class Program
    {
        static string filename = "nevek.txt";
        static string[] names = new string[File.ReadAllLines(filename).Length];
        static int N;
        
        static void beolvas()
        {
            StreamReader file = new StreamReader(filename);

            N = 0;
            while (!file.EndOfStream)
            {
                names[N] = file.ReadLine();
                N++;
            }
        }

        static void ABetusNevekSzama ()
        {
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                if (names[i][0] == 'A' || names[i][0] == 'a')
                {
                    count++;
                }
            }
            WriteLine("'A' betűvel kezdődő nevek száma: {0}", count);
        }

        static void LeghosszabbNev()
        {
            string leghosszabb = "";
            int index = 0;
            for (int i = 0; i < N; i++)
            {
                if (names[i].Length > leghosszabb.Length)
                {
                    leghosszabb = names[i];
                    index = i + 1;
                }
            }
            WriteLine("A leghosszabb név a(z) {0} a {1}. a listában.", leghosszabb, index);
        }

        static void haromBetusNevek()
        {
            WriteLine("Hárombetűs nevek: ");
            for (int i = 0; i < N; i++)
            {
                if (names[i].Length == 3) 
                {
                    WriteLine(names[i]);
                }
            }
        }

        static void legtobbABetusNev()
        {
            int legtobb = 0;
            string Name = "";
            foreach (var name in names)
            {
                int count = 0;
                foreach (var letter in name)
                {
                    if(letter == 'A' || letter == 'a')
                    {
                        count++;
                    }
                }
                if(count > legtobb)
                {
                    legtobb = count;
                    Name = name;
                }
            }
            WriteLine("A legtöbb 'A' betűt tartalmazó név, {0} {1} db 'A' betűt tartalmaz", Name, legtobb);
        }

        static void ASCIIertek()
        {
            int max = 0;
            int min = 0;
            string max_str = "";
            string min_str = "";
            string max_ascii = "";
            string min_ascii = "";
            foreach (var name in names)
            {
                int val = 0;
                string ascii = " ";
                foreach (var c in name)
                {
                    val += (int)c;
                    ascii += Convert.ToString((int)c) + " ";
                }
                if(val > max)
                {
                    max = val;
                    max_str = name;
                    max_ascii = ascii;
                }
                if (val < min || min == 0)
                {
                    min = val;
                    min_str = name;
                    min_ascii = ascii;
                }
            }
            WriteLine("A legkisebb értékű név: {0} ({1})", min_str, min_ascii);
            WriteLine("A legnagyobb értékű név: {0} ({1})", max_str, max_ascii);
        }

        static void search()
        {
            Write("Írd be a keresett nevet: ");
            string query = ReadLine();

            int index = -1;
            int i = 0;

            while(i<N && names[i].ToLower().CompareTo(query.ToLower()) != 0)
            {
                i++;
            }

            if (i < N)
            {
                WriteLine("A keresett név ({0}) a {1}. a nevek között", query, i+1);
            }
            else
            {
                WriteLine("A keresett név nem található");
            }
        }

        static void count()
        {
            int counter = 0;
            Write("Keresett szórészlet: ");
            string part = ReadLine().ToLower();

            for (int i = 0; i < N; i++)
            {
                if(names[i].ToLower().Contains(part))
                {
                    counter++;
                }
            }

            WriteLine("A keresett szórészlet ({0}) {1} névben szerepel", part, counter);
        }

        static void ABC()
        {
            string current = "";
            string first = "";
            string last = "";

            for (int i = 0; i < 5; i++)
            {
                Write("Add meg a(z) {0}. nevet: ", i+1);
                current = ReadLine();

                if(current.CompareTo(first) < 0 || first == "")
                {
                    first = current;
                }
                if (current.CompareTo(last) > 0 || last == "")
                {
                    last = current;
                }
            }
            WriteLine("ABC sorrendben az első: {0}\nABC sorrendben az utolsó: {1}", first, last);
        }

        static void Main(string[] args)
        {
            beolvas();
            ABetusNevekSzama();
            LeghosszabbNev();
            haromBetusNevek();
            legtobbABetusNev();
            ASCIIertek();
            search();
            count();
            ABC();
        }
    }
}