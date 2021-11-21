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

        internal Country(int isoNumeric, string iso2, string iso3, string englishName, string nativeName, string nationalityName, string capital, string continent, string currencyCode, string domain, string iddCode)
        {
            this.ISONumeric = isoNumeric;
            this.ISO2 = iso2;
            this.ISO3 = iso3;
            this.EnglishName = englishName;
            this.NativeName = nativeName;
            this.NationalityName = nationalityName;
            this.Capital = capital;
            this.Continent = continent;
            this.CurrencyCode = currencyCode;
            this.Domain = domain;
            this.IDDCode = iddCode;
        }
    }
}