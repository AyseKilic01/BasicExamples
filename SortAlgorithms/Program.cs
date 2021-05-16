using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 1 ,1, 3, 1, 2, 1, 3, 3, 3, 3 };
            SortList(dizi);
            Console.ReadLine();
        }
        public static void SortList(int[] dizi)
        {
            int yeni;
            for(int i=0; i< dizi.Length; i++)
            {
                for (int j = 0; j < dizi.Length; j++)
                {
                    if (dizi[i] < dizi[j])
                    {
                        yeni = dizi[j];
                        dizi[j] = dizi[i];
                        dizi[i] = yeni;
                    }
                }
            }
            int sayi = 0;
            int tekrarSayisi = 0;
            int geciciTekrar = 1;
            int sayac = 0;

            for (int i = 0; i < dizi.Length - 1; i++)
            {
                if (dizi[i] == dizi[i + 1])
                {
                    geciciTekrar++;
                    if(geciciTekrar % 2 == 0 && geciciTekrar != 0)
                    {
                        sayac++;
                        geciciTekrar = 0;
                    }

                }
                if (i == (dizi.Length - 2) || dizi[i] != dizi[i + 1])
                {
                    if (sayac > tekrarSayisi)
                    {
                        tekrarSayisi++;
                        sayi = dizi[i];
                    }

                    geciciTekrar = 1;
                }
            }
            foreach (var i in dizi)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine(tekrarSayisi);
        }
    }
}
