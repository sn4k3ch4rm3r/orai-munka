using System;
using System.IO;

namespace Gyakorlás2
{
    class Program
    {

        static int count;
        static int[] numbers;

        static int sum;
        static double avg;

        static int parosOssz;
        static int paratlanOssz;

        static int parosDb;
        static int paratlanDb;

        static void readFile()
        {
            StreamReader file = new StreamReader("szamok.txt");

            numbers = new int[1200];
            count = 0;
            
            while(!file.EndOfStream) {
                numbers[count] = Convert.ToInt32(file.ReadLine());
                count++;
            }

            file.Close();

            Console.WriteLine("{0} db szám sikeresen beolvasva.", count);
        }

        static void osszeg()
        {
            sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine("Az összes szám összege: {0}", sum);
        }

        static void atlag()
        {
            avg = (double)sum / count;
            Console.WriteLine("Az összes szám átlaga: {0}", avg);
        }

        static void paratlanOsszeg()
        {
            paratlanOssz = 0;
            for (int i = 0; i < count; i++)
            {
                if(numbers[i] % 2 == 1)
                {
                    paratlanOssz += numbers[i];
                }
            }

            Console.WriteLine("A páratlan számok összege: {0}", paratlanOssz);
        }

        static void parosOsszeg()
        {
            parosOssz = 0;
            for (int i = 0; i < count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    parosOssz += numbers[i];
                }
            }

            Console.WriteLine("A páros számok összege: {0}", parosOssz);
        }

        static void paratlandb()
        {
            paratlanDb = 0;
            for (int i = 0; i < count; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    paratlanDb++;
                }
            }

            Console.WriteLine("{0} db páratlan szám van", paratlanDb);
        }

        static void parosdb()
        {
            parosDb = 0;
            for (int i = 0; i < count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    parosDb++;
                }
            }

            Console.WriteLine("{0} db páros szám van", parosDb);
        }

        static void vaneszaztizenharom()
        {
            for (int i = 0; i < count; i++)
            {
                if(numbers[i] == 113)
                {
                    Console.WriteLine("Van 113-mas szám");
                    return;
                }
            }

            Console.WriteLine("Nincs 113-mas szám");
        }

        static void otvagyharom()
        {
            int harom = 0;
            int ot = 0;

            for (int i = 0; i < count; i++)
            {
                if(numbers[i] % 3 == 0)
                {
                    harom += numbers[i];
                }
                if (numbers[i] % 5 == 0)
                {
                    ot += numbers[i];
                }
            }

            Console.WriteLine(harom > ot ? "A hárommal osztható számok összege nagyobb" : "Az öttel osztható számok összzege  nagyobb");
        }

        static void parosvagyparatlan()
        {
            double parosAtlag = (double) parosOssz / parosDb;
            double paratlanAtlag = (double)paratlanOssz / paratlanDb;

            double parosKulonbseg = Math.Abs(avg - parosAtlag);
            double paratlanKulonbseg = Math.Abs(avg - paratlanAtlag);

            Console.WriteLine(paratlanKulonbseg < parosKulonbseg ? "A páratlan számok átlaga van közelebb az összes szám átlagához" : "A páros számok átlaga van közelebb az összes szám átlagához");
        }

        static void hanyszorSzerepel()
        {
            int[] digits = new int[10];

            for (int i = 0; i < count; i++)
            {
                foreach (var d in Convert.ToString(numbers[i]))
                {
                    switch (d)
                    {
                        case '0':
                            digits[0]++;
                            break;
                        case '1':
                            digits[1]++;
                            break;
                        case '2':
                            digits[2]++;
                            break;
                        case '3':
                            digits[3]++;
                            break;
                        case '4':
                            digits[4]++;
                            break;
                        case '5':
                            digits[5]++;
                            break;
                        case '6':
                            digits[6]++;
                            break;
                        case '7':
                            digits[7]++;
                            break;
                        case '8':
                            digits[8]++;
                            break;
                        case '9':
                            digits[9]++;
                            break;
                        default:
                            break;
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} : {1} db", i, digits[i]);
            }
        }

        static void Main(string[] args)
        {
            readFile();
            osszeg();
            atlag();
            paratlanOsszeg();
            parosOsszeg();
            paratlandb();
            parosdb();
            vaneszaztizenharom();
            otvagyharom();
            parosvagyparatlan();
            hanyszorSzerepel();
        }
    }
}
