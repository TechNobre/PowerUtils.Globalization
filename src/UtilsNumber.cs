using System;
using System.Globalization;

namespace PowerUtils.Globalization
{
    [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
    public static class UtilsNumber
    {
        /// <summary>
        /// Return character for decimal separator
        /// </summary>
        /// <param name="languageCode">Language code</param>
        /// <returns>Decimal separator</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
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
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string GetDecimalSeparator(CultureInfo cultureInfo)
            => cultureInfo.NumberFormat.CurrencyDecimalSeparator;

        /// <summary>
        /// Return character for decimal separator
        /// </summary>
        /// <returns>Decimal separator</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
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
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
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
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string GetThousandSeparator(CultureInfo cultureInfo)
            => cultureInfo.NumberFormat.CurrencyGroupSeparator;

        /// <summary>
        /// Return character for thousand separator
        /// </summary>
        /// <returns>Thousand separator</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string GetThousandSeparator()
        {
            var cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            return cultureInfo.NumberFormat.CurrencyGroupSeparator;
        }
    }
}
