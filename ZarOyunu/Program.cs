using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZarOyunu
{
    class zar
    {
        int konum = 1;
        Random random = new Random();
        public void Anamenu()
        {
            int secim;
            Console.WriteLine("Zar Oyununa Hosgeldiniz");
            while(true)
            {
                if (Oyna() == 1)
                    continue;
                else
                {
                    Console.WriteLine("Oyun bitti");
                    break;
                }

            }
        }
        int Oyna()
        {
            
            
            Console.WriteLine("Zar Atılıyor");
            int zar=random.Next(1,7);
            if (zar%2==1)
            {
                konum--;
                Bilgiler(zar, konum);
                if (konum == 0)
                    return 0;
                else
                    return 1;
            }
            else
            {
                konum++;
                Bilgiler(zar, konum);
                if (konum == 5)
                    return 0;
                else return 1;
            }

        }
        void Bilgiler(int zarsayisi,int Konum)
        {
            Console.WriteLine("Konum: " + Konum);
            Console.WriteLine("Gelen sayı: " + zarsayisi);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            zar zar = new zar();
            zar.Anamenu();
        }
    }
}
