using System;
using System.Globalization;

namespace PowerUtils.Globalization
{
    [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
    public static class NumbersExtensions
    {
        /// <summary>
        /// Convert text number to text number culture
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <param name="languageCode">Language code</param>
        /// <returns>Text formatted in culture</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string ConvertToCulture(this string value, string languageCode)
        {
            var cultureInfo = CultureInfo.CreateSpecificCulture(languageCode);
            return value.ConvertToCulture(cultureInfo);
        }

        /// <summary>
        /// Convert text number to text number culture
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <param name="cultureInfo">Culture info</param>
        /// <returns>Text formatted in culture</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string ConvertToCulture(this string value, CultureInfo cultureInfo)
        {
            var number = double.Parse(value, NumberStyles.Any, cultureInfo);

            return number.ToString("N", cultureInfo.NumberFormat);
        }

        /// <summary>
        /// Convert text number to text number culture
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <returns>Text formatted in culture</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string ConvertToCulture(this string value)
        {
            var cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            var number = float.Parse(value, NumberStyles.Any, cultureInfo);

            return number.ToString("N", cultureInfo.NumberFormat);
        }

        /// <summary>
        /// Convert double number to text number culture
        /// </summary>
        /// <param name="value">Double number</param>
        /// <param name="languageCode">Language code</param>
        /// <param name="decimalDigits">Decimal digits</param>
        /// <returns>Text formatted in culture</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string ConvertToCulture(this double value, string languageCode, int decimalDigits = 2)
        {
            var cultureInfo = CultureInfo.CreateSpecificCulture(languageCode);

            return value.ConvertToCulture(cultureInfo, decimalDigits);
        }

        /// <summary>
        /// Convert double number to text number culture
        /// </summary>
        /// <param name="value">Double number</param>
        /// <param name="cultureInfo">Culture info</param>
        /// <param name="decimalDigits">Decimal digits</param>m>
        /// <returns>Text formatted in culture</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string ConvertToCulture(this double value, CultureInfo cultureInfo, int decimalDigits = 2)
            => Math.Round(value, decimalDigits).ToString("N" + decimalDigits, cultureInfo.NumberFormat);

        /// <summary>
        /// Convert double number to text number culture
        /// </summary>
        /// <param name="value">Double number</param>
        /// <param name="decimalDigits">Decimal digits</param>m>
        /// <returns>Text formatted in culture</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string ConvertToCulture(this double value, int decimalDigits = 2)
        {
            var cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            return Math.Round(value, decimalDigits).ToString("N" + decimalDigits, cultureInfo.NumberFormat);
        }

        /// <summary>
        /// Convert decimal number to text number culture
        /// </summary>
        /// <param name="value">Decimal number</param>
        /// <param name="languageCode">Language code</param>
        /// <param name="decimalDigits">Decimal digits</param>
        /// <returns>Text formatted in culture</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string ConvertToCulture(this decimal value, string languageCode, int decimalDigits = 2)
        {
            var cultureInfo = CultureInfo.CreateSpecificCulture(languageCode);

            return value.ConvertToCulture(cultureInfo, decimalDigits);
        }

        /// <summary>
        /// Convert decimal number to text number culture
        /// </summary>
        /// <param name="value">Decimal number</param>
        /// <param name="cultureInfo">Culture info</param>
        /// <param name="decimalDigits">Decimal digits</param>
        /// <returns>Text formatted in culture</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string ConvertToCulture(this decimal value, CultureInfo cultureInfo, int decimalDigits = 2)
            => Math.Round(value, decimalDigits).ToString("N" + decimalDigits, cultureInfo.NumberFormat);

        /// <summary>
        /// Convert decimal number to text number culture
        /// </summary>
        /// <param name="value">Decimal number</param>
        /// <param name="decimalDigits">Decimal digits</param>
        /// <returns>Text formatted in culture</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string ConvertToCulture(this decimal value, int decimalDigits = 2)
        {
            var cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            return Math.Round(value, decimalDigits).ToString("N" + decimalDigits, cultureInfo.NumberFormat);
        }

        /// <summary>
        /// Convert float number to text number culture
        /// </summary>
        /// <param name="value">Float number</param>
        /// <param name="languageCode">Language code</param>
        /// <param name="decimalDigits">Decimal digits</param>
        /// <returns>Text formatted in culture</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string ConvertToCulture(this float value, string languageCode, int decimalDigits = 2)
        {
            var cultureInfo = CultureInfo.CreateSpecificCulture(languageCode);

            return value.ConvertToCulture(cultureInfo, decimalDigits);
        }

        /// <summary>
        /// Convert float number to text number culture
        /// </summary>
        /// <param name="value">Float number</param>
        /// <param name="cultureInfo">Culture info</param>
        /// <param name="decimalDigits">Decimal digits</param>
        /// <returns>Text formatted in culture</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string ConvertToCulture(this float value, CultureInfo cultureInfo, int decimalDigits = 2)
            => Math.Round(value, decimalDigits).ToString("N" + decimalDigits, cultureInfo.NumberFormat);

        /// <summary>
        /// Convert float number to text number culture
        /// </summary>
        /// <param name="value">Float number</param>
        /// <param name="decimalDigits">Decimal digits</param>
        /// <returns>Text formatted in culture</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string ConvertToCulture(this float value, int decimalDigits = 2)
        {
            var cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            return Math.Round(value, decimalDigits).ToString("N" + decimalDigits, cultureInfo.NumberFormat);
        }

        /// <summary>
        /// Convert int number to text number culture
        /// </summary>
        /// <param name="value">Float number</param>
        /// <param name="languageCode">Language code</param>
        /// <returns>Text formatted in culture</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string ConvertToCulture(this int value, string languageCode)
        {
            var cultureInfo = CultureInfo.CreateSpecificCulture(languageCode);

            return value.ConvertToCulture(cultureInfo);
        }
        /// <summary>
        /// Convert int number to text number culture
        /// </summary>
        /// <param name="value">Float number</param>
        /// <param name="cultureInfo">Culture info</param>
        /// <returns>Text formatted in culture</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string ConvertToCulture(this int value, CultureInfo cultureInfo)
            => value.ToString("N0", cultureInfo.NumberFormat);

        /// <summary>
        /// Convert int number to text number culture
        /// </summary>
        /// <param name="value">Float number</param>
        /// <returns>Text formatted in culture</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string ConvertToCulture(this int value)
        {
            var cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            return value.ToString("N0", cultureInfo.NumberFormat);
        }

        /// <summary>
        /// Convert uint number to text number culture
        /// </summary>
        /// <param name="value">Float number</param>
        /// <param name="languageCode">Language code</param>
        /// <returns>Text formatted in culture</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string ConvertToCulture(this uint value, string languageCode)
        {
            var cultureInfo = CultureInfo.CreateSpecificCulture(languageCode);

            return value.ConvertToCulture(cultureInfo);
        }

        /// <summary>
        /// Convert uint number to text number culture
        /// </summary>
        /// <param name="value">Float number</param>
        /// <param name="cultureInfo">Culture info</param>
        /// <returns>Text formatted in culture</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string ConvertToCulture(this uint value, CultureInfo cultureInfo)
            => value.ToString("N0", cultureInfo.NumberFormat);

        /// <summary>
        /// Convert uint number to text number culture
        /// </summary>
        /// <param name="value">Float number</param>
        /// <returns>Text formatted in culture</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static string ConvertToCulture(this uint value)
        {
            var cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            return value.ToString("N0", cultureInfo.NumberFormat);
        }





        /// <summary>
        /// Convert text number to short number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <param name="languageCode">Language code</param>
        /// <returns>Short number</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static short ConvertToShortCulture(this string value, string languageCode)
        {
            var cultureInfo = CultureInfo.CreateSpecificCulture(languageCode);
            return value.ConvertToShortCulture(cultureInfo);
        }

        /// <summary>
        /// Convert text number to short number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <param name="cultureInfo">Culture info</param>
        /// <returns>Short number</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static short ConvertToShortCulture(this string value, CultureInfo cultureInfo)
        {
            var number = short.Parse(value, NumberStyles.Any, cultureInfo);
            return number;
        }

        /// <summary>
        /// Convert text number to short number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <returns>Short number</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static short ConvertToShortCulture(this string value)
        {
            var cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            return value.ConvertToShortCulture(cultureInfo);
        }




        /// <summary>
        /// Convert text number to ushort number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <param name="languageCode">Language code</param>
        /// <returns>UShort number</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static ushort ConvertToUShortCulture(this string value, string languageCode)
        {
            var cultureInfo = CultureInfo.CreateSpecificCulture(languageCode);
            return value.ConvertToUShortCulture(cultureInfo);
        }

        /// <summary>
        /// Convert text number to ushort number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <param name="cultureInfo">Culture info</param>
        /// <returns>UShort number</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static ushort ConvertToUShortCulture(this string value, CultureInfo cultureInfo)
        {
            var number = ushort.Parse(value, NumberStyles.Any, cultureInfo);
            return number;
        }

        /// <summary>
        /// Convert text number to ushort number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <returns>UShort number</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static ushort ConvertToUShortCulture(this string value)
        {
            var cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            return value.ConvertToUShortCulture(cultureInfo);
        }





        /// <summary>
        /// Convert text number to int number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <param name="languageCode">Language code</param>
        /// <returns>Int number</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static int ConvertToIntCulture(this string value, string languageCode)
        {
            var cultureInfo = CultureInfo.CreateSpecificCulture(languageCode);
            return value.ConvertToIntCulture(cultureInfo);
        }

        /// <summary>
        /// Convert text number to int number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <param name="cultureInfo">Culture info</param>
        /// <returns>Int number</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static int ConvertToIntCulture(this string value, CultureInfo cultureInfo)
        {
            var number = int.Parse(value, NumberStyles.Any, cultureInfo);

            return number;
        }

        /// <summary>
        /// Convert text number to int number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <returns>Int number</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static int ConvertToIntCulture(this string value)
        {
            var cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            return value.ConvertToIntCulture(cultureInfo);
        }






        /// <summary>
        /// Convert text number to uint number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <param name="languageCode">Language code</param>
        /// <returns>UInt number</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static uint ConvertToUIntCulture(this string value, string languageCode)
        {
            var cultureInfo = CultureInfo.CreateSpecificCulture(languageCode);
            return value.ConvertToUIntCulture(cultureInfo);
        }

        /// <summary>
        /// Convert text number to uint number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <param name="cultureInfo">Culture info</param>
        /// <returns>UInt number</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static uint ConvertToUIntCulture(this string value, CultureInfo cultureInfo)
        {
            var number = uint.Parse(value, NumberStyles.Any, cultureInfo);
            return number;
        }

        /// <summary>
        /// Convert text number to uint number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <returns>UInt number</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static uint ConvertToUIntCulture(this string value)
        {
            var cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            return value.ConvertToUIntCulture(cultureInfo);
        }





        /// <summary>
        /// Convert text number to long number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <param name="languageCode">Language code</param>
        /// <returns>Long number</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static long ConvertToLongCulture(this string value, string languageCode)
        {
            var cultureInfo = CultureInfo.CreateSpecificCulture(languageCode);
            return value.ConvertToLongCulture(cultureInfo);
        }

        /// <summary>
        /// Convert text number to long number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <param name="cultureInfo">Culture info</param>
        /// <returns>Long number</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static long ConvertToLongCulture(this string value, CultureInfo cultureInfo)
        {
            var number = long.Parse(value, NumberStyles.Any, cultureInfo);
            return number;
        }

        /// <summary>
        /// Convert text number to long number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <returns>Long number</returns>
        public static long ConvertToLongCulture(this string value)
        {
            var cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            return value.ConvertToLongCulture(cultureInfo);
        }

        /// <summary>
        /// Convert text number to ulong number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <param name="languageCode">Language code</param>
        /// <returns>ULong number</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static ulong ConvertToULongCulture(this string value, string languageCode)
        {
            var cultureInfo = CultureInfo.CreateSpecificCulture(languageCode);
            return value.ConvertToULongCulture(cultureInfo);
        }




        /// <summary>
        /// Convert text number to ulong number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <param name="cultureInfo">Culture info</param>
        /// <returns>ULong number</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static ulong ConvertToULongCulture(this string value, CultureInfo cultureInfo)
        {
            var number = ulong.Parse(value, NumberStyles.Any, cultureInfo);
            return number;
        }

        /// <summary>
        /// Convert text number to ulong number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <returns>ULong number</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static ulong ConvertToULongCulture(this string value)
        {
            var cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            return value.ConvertToULongCulture(cultureInfo);
        }





        /// <summary>
        /// Convert text number to float number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <param name="languageCode">Language code</param>
        /// <returns>Float number</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static float ConvertToFloatCulture(this string value, string languageCode)
        {
            var cultureInfo = CultureInfo.CreateSpecificCulture(languageCode);
            return value.ConvertToFloatCulture(cultureInfo);
        }

        /// <summary>
        /// Convert text number to float number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <param name="cultureInfo">Culture info</param>
        /// <returns>Float number</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static float ConvertToFloatCulture(this string value, CultureInfo cultureInfo)
        {
            var number = float.Parse(value, NumberStyles.Any, cultureInfo);
            return number;
        }

        /// <summary>
        /// Convert text number to float number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <returns>Float number</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static float ConvertToFloatCulture(this string value)
        {
            var cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            return value.ConvertToFloatCulture(cultureInfo);
        }






        /// <summary>
        /// Convert text number to double number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <param name="languageCode">Language code</param>
        /// <returns>Double number</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static double ConvertToDoubleCulture(this string value, string languageCode)
        {
            var cultureInfo = CultureInfo.CreateSpecificCulture(languageCode);
            return value.ConvertToDoubleCulture(cultureInfo);
        }

        /// <summary>
        /// Convert text number to double number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <param name="cultureInfo">Culture info</param>
        /// <returns>Double number</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static double ConvertToDoubleCulture(this string value, CultureInfo cultureInfo)
        {
            var number = double.Parse(value, NumberStyles.Any, cultureInfo);

            return number;
        }

        /// <summary>
        /// Convert text number to double number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <returns>Double number</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static double ConvertToDoubleCulture(this string value)
        {
            var cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            return value.ConvertToDoubleCulture(cultureInfo);
        }





        /// <summary>
        /// Convert text number to decimal number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <param name="languageCode">Language code</param>
        /// <returns>Decimal number</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static decimal ConvertToDecimalCulture(this string value, string languageCode)
        {
            var cultureInfo = CultureInfo.CreateSpecificCulture(languageCode);
            return value.ConvertToDecimalCulture(cultureInfo);
        }

        /// <summary>
        /// Convert text number to decimal number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <param name="cultureInfo">Culture info</param>
        /// <returns>Decimal number</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static decimal ConvertToDecimalCulture(this string value, CultureInfo cultureInfo)
        {
            var number = decimal.Parse(value, NumberStyles.Any, cultureInfo);

            return number;
        }

        /// <summary>
        /// Convert text number to decimal number
        /// </summary>
        /// <param name="value">Text number input</param>
        /// <returns>Decimal number</returns>
        [Obsolete("This package has been discontinued because it never evolved, and the code present in this package does not justify its continuation. It is preferable to implement this code directly in the project if necessary.")]
        public static decimal ConvertToDecimalCulture(this string value)
        {
            var cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            return value.ConvertToDecimalCulture(cultureInfo);
        }
    }
}
