using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = "12:59:59PM";
            TimeConvert(date);
        }
        public static void TimeConvert(string date)
        {
            DateTime time;
            int d = 0;
            int d1 = 0;
            string CDate = "";
            foreach(var i in date)
            {
                if(i.ToString() !="P" && i.ToString() != "A")
                {
                    CDate += i;
                }
                else
                {
                    break;
                }
            }
            if (date.Contains("AM"))
            {
                d = Convert.ToInt32(CDate[0].ToString()) + Convert.ToInt32(CDate[1].ToString());
                if (Convert.ToInt32(CDate[0].ToString()) == 1 && Convert.ToInt32(CDate[1].ToString()) == 2)
                {
                    CDate = (d1).ToString() + (d1).ToString() + CDate[2] + CDate[3] + CDate[4] + CDate[5]
                        + CDate[6] + CDate[7];
                }
                Console.WriteLine(CDate);
            }
            if (date.Contains("PM"))
            {
                    d = Convert.ToInt32(CDate[0].ToString()) + Convert.ToInt32(CDate[1].ToString());
                if (Convert.ToInt32(CDate[0].ToString()) != 1 || Convert.ToInt32(CDate[1].ToString()) != 2)
                {
                    d1 = d + 12;
                    CDate = (d1 / 10).ToString() + (d1 % 10).ToString() + CDate[2] + CDate[3] + CDate[4] + CDate[5]
                        + CDate[6] + CDate[7];
                }
                if(Convert.ToInt32(CDate[0].ToString()) == 1 && Convert.ToInt32(CDate[1].ToString()) != 2)
                {
                    d1 = d + 21;
                    CDate = (d1 / 10).ToString() + (d1 % 10).ToString() + CDate[2] + CDate[3] + CDate[4] + CDate[5]
                        + CDate[6] + CDate[7];
                }
                Console.WriteLine(CDate);
            }
            Console.ReadLine();

        }
    }
}
