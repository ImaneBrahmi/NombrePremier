using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace exercice
{
    public class Premier
    {
        static void Main(string[] args)
        {
            int nbr;
            Console.Write(" entrer un nombre entier ");
            nbr = int.Parse(Console.ReadLine());
            EstPremier(nbr);

        }

        public static void EstPremier(int n)
        {
            int drap = 1;
            int sqrt_int = (int)Math.Sqrt(n);

            for (int i = 2; i <= sqrt_int; i++)
            {

                if (n % i == 0)
                {
                    drap = 0;
                    break;
                }
            }
            if (drap == 0)
                Console.WriteLine("le nombre n'est premier");
            else
                Console.WriteLine("le nombre est  premier");


        }
    }


}