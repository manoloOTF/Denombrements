using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        static long factorisation(int a)
        {
            long r = 1;
            for (int k = 1; k <= a; k++)
                r *= k;
            return r;
        }
        static long arrangements(int a, int b)
        {
            long r = 1;
            for (int k = (a - b + 1); k <= a; k++)
                r *= k;
            return r;
        }
        static void Main(string[] args)
        {
            int c = 1;
            while (c != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = int.Parse(Console.ReadLine());

                switch (c)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        int n = int.Parse(Console.ReadLine()); // saisir le nombre
                                                               // calcul de r
                        Console.WriteLine(n + "! = " + factorisation(n));
                        break;
                    case 2:
                        Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        int t = int.Parse(Console.ReadLine()); // saisir le nombre
                        Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                        int x = int.Parse(Console.ReadLine()); // saisir le nombre
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("A(" + t + "/" + x + ") = " + arrangements(t,x));
                        break;
                    case 3:
                        Console.Write("nombre total d'éléments à gérer = "); // le nombre d'éléments à gérer
                        int z = int.Parse(Console.ReadLine()); // saisir le nombre
                        Console.Write("nombre d'éléments dans le sous ensemble = "); // le sous ensemble
                        int y = int.Parse(Console.ReadLine()); // saisir le nombre
                        // calcul de r3
                        //Console.WriteLine("résultat = " + (r1 / r2));
                        Console.WriteLine("C(" + z + "/" + y + ") = " + (arrangements(z,y) / factorisation(y)));
                        break;
                    default:
                        c = 1;
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
