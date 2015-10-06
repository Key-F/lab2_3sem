using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2909
{
    class Program
    {
        
        private static bool CorrectDay(int day, int month, int year)
        {
            if (((year % 4 == 0) && (year % 100 != 0))||(year % 400 == 0)) 
            {
                if ((month == 2) && (month < 13)) 
                {
                   if ((day > 0) && (day < 30)) return true;
                }

            }
            if ((month == 8) && (month == 9) && (month < 13))
            {
                if ((day > 0) && (day < 32)) return true;
            }
            if ((month % 2 == 1) && (month < 13) && (month != 2))
            {
                if ((day > 0) && (day < 31)) return true;
            }
            if ((month % 2 == 0) && (month < 13) && (month != 2))
             {
                if ((day > 0) && (day < 32)) return true;
             }
             throw new Exception("Impossible!");
        }
        private static int CountDays(int day, int month, int year)
       {
           string s = DateTime.Now.ToString("dd");
           int dd = Convert.ToInt32(s);
           s = DateTime.Now.ToString("MM");
           int mm = Convert.ToInt32(s);
           s = DateTime.Now.ToString("yyyy");
           int yy = Convert.ToInt32(s);
           DateTime d1 = new DateTime(yy, mm, dd);
           DateTime d2 = new DateTime(year, month, day);
           TimeSpan time = d2 - d1;
           return(Math.Abs(time.Days));
       }
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            string[] parametr = x.Split('.');
            int d = Convert.ToInt32(parametr[0]);
            int m = Convert.ToInt32(parametr[1]);
            int y = Convert.ToInt32(parametr[2]);
            CorrectDay(d, m, y);
            Console.WriteLine(CountDays (d, m, y));
            Console.ReadKey(true);
        }
    }
}
