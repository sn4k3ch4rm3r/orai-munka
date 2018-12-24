using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Karácsony
{
    class Program
    {

        static string[] tree = new string[40];
        static int N;

        static string lights = "on";

        static void readFile()
        {
            StreamReader file = new StreamReader("christmastree.txt");
            N = 0;
            while(!file.EndOfStream) {
                tree[N] = file.ReadLine();
                N++;
            }
        }

        static void printTree()
        {
            Console.Clear();
            for (int i = 0; i < N; i++)
            {
                //Console.WriteLine(tree[i]);
                foreach (var c in tree[i])
                {
                    switch(c)
                    {
                        case '.':
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(c);
                            break;
                        case '#':
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(c);
                            break;
                        case '@':
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Write(c);
                            break;
                        case '0':
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(c);
                            break;
                        case 'O':
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(c);
                            break;
                        case '|':
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write(c);
                            break;
                        case 'a':
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(c);
                            break;
                    }
                }
                Console.Write("\n");
            }
        }

        /*
        static void blink()
        {
            while (true)
            {
                if(lights == "on")
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    lights = "";
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    lights = "on";
                }
                printTree();
                Thread.Sleep(1000);
            }
        }
        */
        static void Main(string[] args)
        {
            readFile();
            printTree();
        }
    }
}
