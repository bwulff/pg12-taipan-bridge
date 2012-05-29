using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TainPan_StockDataLoader
{
    class Util
    {
        private static DateTime epoche = new DateTime(1970, 1, 1);  

        public static long dateTimeToUnixTS(DateTime dateTime)
        {
            TimeSpan ts = new TimeSpan(dateTime.Ticks - epoche.Ticks);
            return (Convert.ToInt32(ts.TotalSeconds));
        }

        public static DateTime tagesAnfang(DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0);
        }

        public static String getAmiDatum(DateTime timestamp)
        {
            return timestamp.Year + "-"
                + zweistellig(timestamp.Month) + "-"
                + zweistellig(timestamp.Day) + " "
                + zweistellig(timestamp.Hour) + ":"
                + zweistellig(timestamp.Minute) + ":"
                + zweistellig(timestamp.Second);
        }

        public static String zweistellig(int i)
        {
            if (i < 10)
            {
                return "0" + i.ToString();
            }
            else
            {
                return i.ToString();
            }
        }
    }
}
