using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GammuMonitoring.Helper
{
    class MyDateTIme
    {
        public static int DateTimeToEpoch(DateTime datetime)
        {
            TimeSpan t = datetime - new DateTime(1970, 1, 1);
            int second = (int)t.TotalSeconds;
            return second;
        }

        public static DateTime EpochToDateTime(int epoch)
        {
            DateTime time = new DateTime(1970, 1, 1, 0, 0, 0).AddSeconds(epoch);
            return time;
        }
    }
}
