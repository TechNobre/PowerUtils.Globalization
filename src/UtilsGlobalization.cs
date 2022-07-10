using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace PowerUtils.Globalization
{
    public static class UtilsGlobalization
    {
        private static readonly object _padLocknew = new object();

        public static IReadOnlyDictionary<string, Country> Countries
        {
            get
            {
                lock(_padLocknew)
                {
                    if(_countries == null)
                    {
                        _countries = new Dictionary<string, Country>();

                        var content = Encoding.UTF8.GetString(Resources.Countries);
                        using(var reader = new StringReader(content))
                        {
                            var serializer = new XmlSerializer(typeof(CountryContent[]));
                            foreach(var dto in (CountryContent[])serializer.Deserialize(reader))
                            {
                                var country = Country.Factory.Create(dto);

                                _countries.Add(country.ISO2, country);
                            }
                        }
                    }

                    return _countries;
                }
            }
        }

        public static IEnumerable<Country> CountryList => _countries.Select(s => s.Value);
        private static Dictionary<string, Country> _countries;


        public static IReadOnlyDictionary<string, CultureInfo> CultureInfos => _cultureInfos;
        public static IEnumerable<CultureInfo> CultureInfoList => _cultureInfos.Select(s => s.Value);

        private static readonly Dictionary<string, CultureInfo> _cultureInfos = CultureInfo
           .GetCultures(CultureTypes.AllCultures & ~CultureTypes.NeutralCultures)
           .Where(w => !string.IsNullOrEmpty(w.Name))
           .Distinct()
           .ToDictionary(
               k => k.Name,
               v => CultureInfo.CreateSpecificCulture(v.Name)
           );



        #region HELPERS
        /// <summary>
        /// Get ISO numeric by ISO2
        /// </summary>
        /// <param name="iso2">Two-letter code</param>
        /// <returns>ISONumeric | -1 when the code does not exist</returns>
        public static int GetISONumeric(string iso2)
        {
            if(IfExistISO2(iso2))
            {
                return Countries[iso2.ToUpper()].ISONumeric;
            }

            return -1;
        }

        /// <summary>
        /// Get ISO3 by ISO2
        /// </summary>
        /// <param name="iso2">Two-letter code</param>
        /// <returns>ISO3</returns>
        public static string GetISO3(string iso2)
        {
            if(IfExistISO2(iso2))
            {
                return Countries[iso2.ToUpper()].ISO3;
            }

            return null;
        }

        /// <summary>
        /// Get english name by iso2
        /// </summary>
        /// <param name="iso2">Two-letter code</param>
        /// <returns>EnglishName</returns>
        public static string GetEnglishName(string iso2)
        {
            if(IfExistISO2(iso2))
            {
                return Countries[iso2.ToUpper()].EnglishName;
            }

            return null;
        }

        /// <summary>
        /// Get native name by iso2
        /// </summary>
        /// <param name="iso2">Two-letter code</param>
        /// <returns>NativeName</returns>
        public static string GetNativeName(string iso2)
        {
            if(IfExistISO2(iso2))
            {
                return Countries[iso2.ToUpper()].NativeName;
            }

            return null;
        }

        /// <summary>
        /// Method to get nationality name by iso2
        /// </summary>
        /// <param name="iso2">Two-letter code</param>
        /// <returns>NationalityName</returns>
        public static string GetNationalityName(string iso2)
        {
            if(IfExistISO2(iso2))
            {
                return Countries[iso2.ToUpper()].NationalityName;
            }

            return null;
        }

        /// <summary>
        /// Method to get IDDCode by iso2
        /// </summary>
        /// <param name="iso2">Two-letter code</param>
        /// <returns>IDDCode</returns>
        public static string GetIDDCode(string iso2)
        {
            if(IfExistISO2(iso2))
            {
                return Countries[iso2.ToUpper()].IDDCode;
            }

            return null;
        }

        /// <summary>
        /// Get the culture code
        /// </summary>
        /// <param name="cultureCode">Culture code</param>
        /// <returns>Return the culture info</returns>
        public static CultureInfo GetCultureInfo(string cultureCode)
            => CultureInfos.SingleOrDefault(s => s.Key.Equals(cultureCode, StringComparison.InvariantCultureIgnoreCase)).Value;

        /// <summary>
        /// Check if the country code ISO3 exist
        /// </summary>
        /// <param name="iso3">Three-letter code</param>
        /// <returns>Bool if exist or not</returns>
        public static bool IfExistISO3(string iso3)
        {
            if(string.IsNullOrWhiteSpace(iso3))
            {
                return false;
            }

            if(CountryList.Any(c => c.ISO3.Equals(iso3, StringComparison.InvariantCultureIgnoreCase)))
            {

                return true;
            }

            return false;
        }

        /// <summary>
        /// Check if the country code iso2 exist
        /// </summary>
        /// <param name="iso2">Two-letter code</param>
        /// <returns>Bool if exist or not</returns>
        public static bool IfExistISO2(string iso2)
        {
            if(string.IsNullOrWhiteSpace(iso2))
            {
                return false;
            }

            if(Countries.ContainsKey(iso2.ToUpper()))
            {
                return true;
            }

            return false;
        }
        #endregion
    }
}
