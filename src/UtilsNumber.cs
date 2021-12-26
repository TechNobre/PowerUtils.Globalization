using System.Globalization;

namespace PowerUtils.Globalization
{
    public static class UtilsNumber
    {
        /// <summary>
        /// Return character for decimal separator
        /// </summary>
        /// <param name="languageCode">Language code</param>
        /// <returns>Decimal separator</returns>
        public static string GetDecimalSeparator(string languageCode)
        {
            var cultureInfo = CultureInfo.CreateSpecificCulture(languageCode);
            return GetDecimalSeparator(cultureInfo);
        }

        /// <summary>
        /// Return character for decimal separator
        /// </summary>
        /// <param name="cultureInfo">Culture info</param>
        /// <returns>Decimal separator</returns>
        public static string GetDecimalSeparator(CultureInfo cultureInfo)
            => cultureInfo.NumberFormat.CurrencyDecimalSeparator;

        /// <summary>
        /// Return character for decimal separator
        /// </summary>
        /// <returns>Decimal separator</returns>
        public static string GetDecimalSeparator()
        {
            var cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            return cultureInfo.NumberFormat.CurrencyDecimalSeparator;
        }

        /// <summary>
        /// Return character for thousand separator
        /// </summary>
        /// <param name="languageCode">Language code</param>
        /// <returns>Thousand separator</returns>
        public static string GetThousandSeparator(string languageCode)
        {
            var cultureInfo = CultureInfo.CreateSpecificCulture(languageCode);
            return GetThousandSeparator(cultureInfo);
        }

        /// <summary>
        /// Return character for thousand separator
        /// </summary>
        /// <param name="cultureInfo">Culture info</param>
        /// <returns>Thousand separator</returns>
        public static string GetThousandSeparator(CultureInfo cultureInfo)
            => cultureInfo.NumberFormat.CurrencyGroupSeparator;

        /// <summary>
        /// Return character for thousand separator
        /// </summary>
        /// <returns>Thousand separator</returns>
        public static string GetThousandSeparator()
        {
            var cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            return cultureInfo.NumberFormat.CurrencyGroupSeparator;
        }
    }
}
