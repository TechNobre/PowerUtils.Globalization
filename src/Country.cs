namespace PowerUtils.Globalization
{
    public class Country
    {
        public int ISONumeric { get; private set; }
        public string ISO2 { get; private set; }
        public string ISO3 { get; private set; }

        public string EnglishName { get; private set; }
        public string NativeName { get; private set; }
        public string NationalityName { get; private set; }

        public string Capital { get; private set; }
        public string Continent { get; private set; }

        public string CurrencyCode { get; private set; }
        public string Domain { get; private set; }
        public string IDDCode { get; private set; }

        internal static class Factory
        {
            public static Country Create(CountryContent country)
                => new Country()
                {
                    ISONumeric = country.ISONumeric,
                    ISO2 = country.ISO2,
                    ISO3 = country.ISO3,
                    EnglishName = country.EnglishName,
                    NativeName = country.NativeName,
                    NationalityName = country.NationalityName,
                    Capital = country.Capital,
                    Continent = country.Continent,
                    CurrencyCode = country.CurrencyCode,
                    Domain = country.Domain,
                    IDDCode = country.IDDCode
                };
        }
    }

    public class CountryContent
    {
        public int ISONumeric { get; set; }
        public string ISO2 { get; set; }
        public string ISO3 { get; set; }

        public string EnglishName { get; set; }
        public string NativeName { get; set; }
        public string NationalityName { get; set; }

        public string Capital { get; set; }
        public string Continent { get; set; }

        public string CurrencyCode { get; set; }
        public string Domain { get; set; }
        public string IDDCode { get; set; }
    }
}
