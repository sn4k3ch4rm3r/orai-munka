using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karakterek
{
    class Program
    {
        static string NagybolKicsi(string word)
        {
            string kicsi = "";
            for (int i = 0; i < word.Length; i++)
            {
                kicsi += Convert.ToChar(word[i] + ' ');
            }
            return (string)kicsi;
        }

        static string KicsibolNagy(string word)
        {
            string nagy = "";
            for (int i = 0; i < word.Length; i++)
            {
                nagy += Convert.ToChar(word[i] - ' ');
            }
            return nagy;
        }

        static string abc()
        {
            string abc = "";
            for (int i = 'a'; i <= 'z'; i++)
            {
                abc += Convert.ToChar(i);
            }
            return abc;
        }

        static string ABC()
        {
            string abc = "";
            for (int i = 'A'; i <= 'Z'; i++)
            {
                abc += Convert.ToChar(i);
            }
            return abc;
        }

        static string aAbBcC()
        {
            string abc = "";
            for (int i = 'a'; i <= 'z'; i++)
            {
                abc += Convert.ToChar(i);
                abc += Convert.ToChar(i - ' ');
            }
            return abc;
        }

        static bool van_eIdegenChar(string word)
        {
            string abc = aAbBcC();
            int i = 0;

            while (i < word.Length && abc.Contains(word[i]))
            {
                i++;
            }
            return i != word.Length;
        }

        static int stringNumbers(string num1, string num2)
        {
            /*
            string n1 = "";
            for (int i = 0; i < num1.Length; i++)
            {
                n1 += num1[i] - '0';
            }
            string n2 = "";
            for (int i = 0; i < num2.Length; i++)
            {
                n2 += num2[i] - '0';
            }
            return Convert.ToInt32(n1) + Convert.ToInt32(n2);
            */
            return strToInt(num1) + strToInt(num2);
        }

        static int strToInt(string number) {
            int x = 0;
            x += number[0] - '0';
            for (int i = 1; i < number.Length; i++)
            {
                x *= 10;
                x += number[i] - '0'; 
            }
            return x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(NagybolKicsi("CSUPANAGY"));
            Console.WriteLine(KicsibolNagy("csupakicsi"));
            Console.WriteLine(abc());
            Console.WriteLine(ABC());
            Console.WriteLine(aAbBcC());
            Console.WriteLine(van_eIdegenChar(Console.ReadLine()) ? "Van benne idegen karakter" : "Csak az angol ábécé betűit tratalmazza");
            Console.WriteLine("A két tszám összege: {0}", stringNumbers(Console.ReadLine(), Console.ReadLine()));
        }
    }
}
