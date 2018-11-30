using System;
using System.Collections.Generic;
using System.IO;

namespace Gyakorlás
{
    class Program
    {

        static int[] readFile()
        {
            StreamReader file = new StreamReader("szamok.txt");
            int[] numbers = new int[1035];
            int i = 0;
            while (!file.EndOfStream)
            {
                numbers[i] = Convert.ToInt32(file.ReadLine());
                i++;
            }
            return numbers;
           
        }

        static int sum(int [] nums)
        {
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            return sum;
        }

        static double avg(int[] nums)
        {
            return (double) sum(nums) / nums.Length;
        }

        static bool vanParos(int [] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        static int hanyParatlan(int[] nums)
        {
            int count = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 1)
                {
                    count++;
                }
            }
            return count;
        }

        static int paratlanSum(int[] nums)
        {
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 1)
                {
                    sum += nums[i];
                }
            }

            return sum;
        }

        static double paratlanAtlag(int[] nums)
        {
            return (double) paratlanSum(nums) / nums.Length;
        }

        static bool mindEgsez(int [] nums) {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 1 != 0)
                {
                    return false;
                }
            }
            return true;
        }

        static int ezerParosSum(int[] nums)
        {
            int sum = 0;
            foreach (var num in nums)
            {
                if (num > 1000 && num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }

        static int countUnique(int[] nums)
        {
            int count = 0;
            List<int> vótmá = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (vótmá.Count != 0)
                {
                    bool vm = false;
                    for (int j = 0; j < vótmá.Count; j++)
                    {
                        if (nums[i] == vótmá[j])
                        {
                            vm = true;
                            break;
                        }
                    }
                    if (!vm)
                    {
                        count++;
                        vótmá.Add(nums[i]);
                    }
                }
                else
                {
                    count++;
                    vótmá.Add(nums[i]);
                }
            }
            return count;
        }

        static void printResults(int[] nums)
        {
            Console.WriteLine("A számok összege: {0}", sum(nums));
            Console.WriteLine("Az összes szám átlaga: {0}", avg(nums));
            Console.WriteLine(vanParos(nums) ? "Van páros szám" : "Nincs páros szám");
            Console.WriteLine("{0} db páratlan szám van", hanyParatlan(nums));
            Console.WriteLine("Páratlan számok összege: {0}", paratlanSum(nums));
            Console.WriteLine("Páratlan számok átlaga: {0}", paratlanAtlag(nums));
            Console.WriteLine("1000-nél nagyobb páros számok összege: {0}", ezerParosSum(nums));
            Console.WriteLine(mindEgsez(nums) ? "Minden szám egész" : "Nem minden szám egész");
            Console.WriteLine("{0} db különböző szám van", countUnique(nums));
        }

        static void Main(string[] args)
        {
            printResults(readFile());
        }
    }
}
