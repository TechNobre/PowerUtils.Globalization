using System;

namespace PowerUtils.Globalization
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Convert datetime to timestamp
        /// </summary>
        /// <param name="dateTime">Datetime to convert</param>
        /// <returns>Timestamp</returns>
        public static ulong ToTimestamp(this DateTime dateTime)
            => Convert.ToUInt64(dateTime.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds);
    }
}
