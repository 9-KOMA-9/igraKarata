using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igraKarte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int karta, zbrojkar = 0;
            pocetak:
            Console.WriteLine(" unesite kartu: ");
            Console.WriteLine(" karta mora biti u rasponu od 1 do 13: ");
            karta = Convert.ToInt32(Console.ReadLine());
            if (karta >= 1 && karta <= 13)
            {
                zbrojkar = zbrojkar + karta;
            }
            else
            {
                Console.WriteLine(" karta nije u rasponu!! ");
                goto pocetak;
            }
            if(zbrojkar < 31)
            {
                goto pocetak;
            }
            if(zbrojkar > 31)
            {
                Console.WriteLine(" zbroj je prešao 31! ");
            }
            if(zbrojkar == 31)
            {
                Console.WriteLine(" čestitamo pobjedili ste! ");
            }
            Console.ReadKey();
            
        }
    }
}
