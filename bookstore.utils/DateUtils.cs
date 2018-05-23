using System;

namespace bookstore.utils
{
    public static class DateUtils
    {
        public static long unix(this DateTime datetime){
            return (long)(datetime.Ticks/TimeSpan.TicksPerSecond);
        }

        public static long unixMill(this DateTime datetime){
            return (long)(datetime.Ticks/TimeSpan.TicksPerMillisecond);
        }
    }
}
