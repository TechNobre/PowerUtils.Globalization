using System;

namespace PowerUtils.Globalization
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Convert datetime to timestamp (Unix timestamp is seconds past epoch)
        /// </summary>
        /// <param name="dateTime">Datetime to convert</param>
        /// <returns>Timestamp</returns>
        public static ulong ToTimestamp(this DateTime dateTime)
            => Convert.ToUInt64(dateTime.Subtract(new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds);



        /// <summary>
        /// Convert timestamp (Unix timestamp is seconds past epoch) to datetime
        /// </summary>
        /// <param name="timestamp">Timestamp to convert</param>
        /// <returns>DateTime</returns>
        public static DateTime FromTimestampToDateTime(this int timestamp)
            => FromTimestampToDateTime(Convert.ToDouble(timestamp));

        /// <summary>
        /// Convert timestamp (Unix timestamp is seconds past epoch) to datetime
        /// </summary>
        /// <param name="timestamp">Timestamp to convert</param>
        /// <returns>DateTime</returns>
        public static DateTime FromTimestampToDateTime(this uint timestamp)
            => FromTimestampToDateTime(Convert.ToDouble(timestamp));

        /// <summary>
        /// Convert timestamp (Unix timestamp is seconds past epoch) to datetime
        /// </summary>
        /// <param name="timestamp">Timestamp to convert</param>
        /// <returns>DateTime</returns>
        public static DateTime FromTimestampToDateTime(this long timestamp)
            => FromTimestampToDateTime(Convert.ToDouble(timestamp));

        /// <summary>
        /// Convert timestamp (Unix timestamp is seconds past epoch) to datetime
        /// </summary>
        /// <param name="timestamp">Timestamp to convert</param>
        /// <returns>DateTime</returns>
        public static DateTime FromTimestampToDateTime(this ulong timestamp)
            => FromTimestampToDateTime(Convert.ToDouble(timestamp));

        /// <summary>
        /// Convert timestamp (Unix timestamp is seconds past epoch) to datetime
        /// </summary>
        /// <param name="timestamp">Timestamp to convert</param>
        /// <returns>DateTime</returns>
        public static DateTime FromTimestampToDateTime(this double timestamp)
        {
            var dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dateTime = dateTime.AddSeconds(timestamp).ToLocalTime();

            return dateTime;
        }
    }
}
