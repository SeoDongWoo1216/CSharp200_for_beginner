using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charp200_beginner_WPF
{
    class Date68
    {
        private int year, month, day;

        public Date68()
        {
            year = 1;
            month = 1;
            day = 1;
        }

        public Date68(int y, int m, int d)
        {
            year = y;
            month = m;
            day = d;
        }

        public void PrintDate68()
        {
            Console.WriteLine("{0}/{1}/{2}", year, month, day);
        }
    }
    class _68_Class
    {

    }
}
