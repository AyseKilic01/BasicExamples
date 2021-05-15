using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sockMerchant
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 9;
            List<int> arr = new List<int>();
            for(int i = 0; i<n; i++)
            {
                arr.Add(Convert.ToInt32(Console.ReadLine().ToString()));
            }
            Console.WriteLine(sockMerchant(n, arr));
            Console.ReadLine();
            
        }
        public static int sockMerchant(int n, List<int> ar)
        {

            int tekrarSayisi = 0;
            int geciciTekrar = 1;
            int count = 0;
            int sayi = 0;
            for (int i = 0; i < ar.Count - 1; i++)
            {
                if (ar[i] == ar[i + 1])
                    geciciTekrar++;
                    count++;

                if (i == (ar.Count - 2) || ar[i] != ar[i + 1])
                {
                    if (geciciTekrar > tekrarSayisi)
                    {
                        tekrarSayisi = geciciTekrar;
                        sayi = ar[i];

                    }

                    geciciTekrar = 1;
                }
            }
                return count;
        }
    }
}
