using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace PowerUtils.Globalization
{
    public static class UtilsGlobalization
    {
        #region PUBLIC VARIABLES
        public static readonly Dictionary<string, Country> Countries;
        public static List<Country> CountryList => Countries.Select(s => s.Value).ToList();

        public static readonly Dictionary<string, CultureInfo> CultureInfos;
        public static List<CultureInfo> CultureInfoList => CultureInfos.Select(s => s.Value).ToList();
        #endregion


        #region CONSTRUCTOR
        static UtilsGlobalization()
        {
            Countries = new Dictionary<string, Country>
            {
                {
                    "XK",
                    new Country(
                        isoNumeric: 0,
                        iso2: "XK",
                        iso3: "XKX",
                        englishName: "Kosovo",
                        nativeName: null,
                        nationalityName: "Kosovar",
                        capital: "Pristina",
                        continent: "Europe",
                        currencyCode: null,
                        domain: null,
                        iddCode: "383"
                    )
                },
                {
                    "AF",
                    new Country(
                        isoNumeric: 4,
                        iso2: "AF",
                        iso3: "AFG",
                        englishName: "Afghanistan",
                        nativeName: "افغانستان",
                        nationalityName: "Afghan",
                        capital: "Kabul",
                        continent: "Asia",
                        currencyCode: "AFN",
                        domain: "af",
                        iddCode: "93"
                    )
                },
                {
                    "AL",
                    new Country(
                        isoNumeric: 8,
                        iso2: "AL",
                        iso3: "ALB",
                        englishName: "Albania",
                        nativeName: "Shqipëri",
                        nationalityName: "Albanian",
                        capital: "Tirana",
                        continent: "Europe",
                        currencyCode: "ALL",
                        domain: "al",
                        iddCode: "355"
                    )
                },
                {
                    "AQ",
                    new Country(
                        isoNumeric: 10,
                        iso2: "AQ",
                        iso3: "ATA",
                        englishName: "Antarctica",
                        nativeName: null,
                        nationalityName: null,
                        capital: null,
                        continent: "Antarctica",
                        currencyCode: "AUD",
                        domain: "aq",
                        iddCode: "672"
                    )
                },
                {
                    "DZ",
                    new Country(
                        isoNumeric: 12,
                        iso2: "DZ",
                        iso3: "DZA",
                        englishName: "Algeria",
                        nativeName: "الجزائر",
                        nationalityName: "Algerian",
                        capital: "Algiers",
                        continent: "Africa",
                        currencyCode: "DZD",
                        domain: "dz",
                        iddCode: "213"
                    )
                },
                {
                    "AS",
                    new Country(
                        isoNumeric: 16,
                        iso2: "AS",
                        iso3: "ASM",
                        englishName: "American Samoa",
                        nativeName: null,
                        nationalityName: "American Samoan",
                        capital: "Pago Pago",
                        continent: "Oceania",
                        currencyCode: "USD",
                        domain: "as",
                        iddCode: "1684"
                    )
                },
                {
                    "AD",
                    new Country(
                        isoNumeric: 20,
                        iso2: "AD",
                        iso3: "AND",
                        englishName: "Andorra",
                        nativeName: null,
                        nationalityName: "Andorran",
                        capital: "Andorra la Vella",
                        continent: "Europe",
                        currencyCode: "EUR",
                        domain: "ad",
                        iddCode: "376"
                    )
                },
                {
                    "AO",
                    new Country(
                        isoNumeric: 24,
                        iso2: "AO",
                        iso3: "AGO",
                        englishName: "Angola",
                        nativeName: null,
                        nationalityName: "Angolan",
                        capital: "Luanda",
                        continent: "Africa",
                        currencyCode: "AOA",
                        domain: "ao",
                        iddCode: "244"
                    )
                },
                {
                    "AG",
                    new Country(
                        isoNumeric: 28,
                        iso2: "AG",
                        iso3: "ATG",
                        englishName: "Antigua and Barbuda",
                        nativeName: null,
                        nationalityName: "Antiguan Barbudan",
                        capital: "St. John's",
                        continent: "North America",
                        currencyCode: "XCD",
                        domain: "ag",
                        iddCode: "1268"
                    )
                },
                {
                    "AZ",
                    new Country(
                        isoNumeric: 31,
                        iso2: "AZ",
                        iso3: "AZE",
                        englishName: "Azerbaijan",
                        nativeName: "Азәрбајҹан",
                        nationalityName: "Azerbaijani",
                        capital: "Baku",
                        continent: "Asia",
                        currencyCode: "AZN",
                        domain: "az",
                        iddCode: "994"
                    )
                },
                {
                    "AR",
                    new Country(
                        isoNumeric: 32,
                        iso2: "AR",
                        iso3: "ARG",
                        englishName: "Argentina",
                        nativeName: "Argentina",
                        nationalityName: "Argentinian",
                        capital: "Buenos Aires",
                        continent: "South America",
                        currencyCode: "ARS",
                        domain: "ar",
                        iddCode: "54"
                    )
                },
                {
                    "AU",
                    new Country(
                        isoNumeric: 36,
                        iso2: "AU",
                        iso3: "AUS",
                        englishName: "Australia",
                        nativeName: "Australia",
                        nationalityName: "Australian",
                        capital: "Canberra",
                        continent: "Oceania",
                        currencyCode: "AUD",
                        domain: "au",
                        iddCode: "61"
                    )
                },
                {
                    "AT",
                    new Country(
                        isoNumeric: 40,
                        iso2: "AT",
                        iso3: "AUT",
                        englishName: "Austria",
                        nativeName: "Österreich",
                        nationalityName: "Austrian",
                        capital: "Vienna",
                        continent: "Europe",
                        currencyCode: "EUR",
                        domain: "at",
                        iddCode: "43")
                },
                {
                                "BS",
                    new Country(
                        isoNumeric: 44,
                        iso2: "BS",
                        iso3: "BHS",
                        englishName: "Bahamas",
                        nativeName: null,
                        nationalityName: "Bahamian",
                        capital: "Nassau",
                        continent: "North America",
                        currencyCode: "BSD",
                        domain: "bs",
                        iddCode: "1242")
                },
                {
                                "BH",
                    new Country(
                        isoNumeric: 48,
                        iso2: "BH",
                        iso3: "BHR",
                        englishName: "Bahrain",
                        nativeName: "البحرين",
                        nationalityName: "Bahraini",
                        capital: "Manama",
                        continent: "Asia",
                        currencyCode: "BHD",
                        domain: "bh",
                        iddCode: "973")
                },
                {
                                "BD",
                    new Country(
                        isoNumeric: 50,
                        iso2: "BD",
                        iso3: "BGD",
                        englishName: "Bangladesh",
                        nativeName: "বাংলাদেশ",
                        nationalityName: "Bangladeshi",
                        capital: "Dhaka",
                        continent: "Asia",
                        currencyCode: "BDT",
                        domain: "bd",
                        iddCode: "880")
                },
                {
                                "AM",
                    new Country(
                        isoNumeric: 51,
                        iso2: "AM",
                        iso3: "ARM",
                        englishName: "Armenia",
                        nativeName: "Հայաստան",
                        nationalityName: "Armenian",
                        capital: "Yerevan",
                        continent: "Asia",
                        currencyCode: "AMD",
                        domain: "am",
                        iddCode: "374")
                },
                {
                                "BB",
                    new Country(
                        isoNumeric: 52,
                        iso2: "BB",
                        iso3: "BRB",
                        englishName: "Barbados",
                        nativeName: null,
                        nationalityName: "Barbadian",
                        capital: "Bridgetown",
                        continent: "North America",
                        currencyCode: "BBD",
                        domain: "bb",
                        iddCode: "1246")
                },
                {
                                "BE",
                    new Country(
                        isoNumeric: 56,
                        iso2: "BE",
                        iso3: "BEL",
                        englishName: "Belgium",
                        nativeName: "Belgique",
                        nationalityName: "Belgian",
                        capital: "Brussels",
                        continent: "Europe",
                        currencyCode: "EUR",
                        domain: "be",
                        iddCode: "32")
                },
                {
                                "BM",
                    new Country(
                        isoNumeric: 60,
                        iso2: "BM",
                        iso3: "BMU",
                        englishName: "Bermuda",
                        nativeName: null,
                        nationalityName: "Bermudian",
                        capital: "Hamilton",
                        continent: "North America",
                        currencyCode: "BMD",
                        domain: "bm",
                        iddCode: "1441")
                },
                {
                                "BT",
                    new Country(
                        isoNumeric: 64,
                        iso2: "BT",
                        iso3: "BTN",
                        englishName: "Bhutan",
                        nativeName: "འབྲུག",
                        nationalityName: "Bhutanese",
                        capital: "Thimphu",
                        continent: "Asia",
                        currencyCode: "BTN",
                        domain: "bt",
                        iddCode: "975")
                },
                {
                                "BO",
                    new Country(
                        isoNumeric: 68,
                        iso2: "BO",
                        iso3: "BOL",
                        englishName: "Bolivia",
                        nativeName: "Bolivia",
                        nationalityName: "Bolivian",
                        capital: "Sucre",
                        continent: "South America",
                        currencyCode: "BOB",
                        domain: "bo",
                        iddCode: "591")
                },
                {
                                "BA",
                    new Country(
                        isoNumeric: 70,
                        iso2: "BA",
                        iso3: "BIH",
                        englishName: "Bosnia and Herzegovina",
                        nativeName: "Босна и Херцеговина",
                        nationalityName: "Bosnian",
                        capital: "Sarajevo",
                        continent: "Europe",
                        currencyCode: "BAM",
                        domain: "ba",
                        iddCode: "387")
                },
                {
                                "BW",
                    new Country(
                        isoNumeric: 72,
                        iso2: "BW",
                        iso3: "BWA",
                        englishName: "Botswana",
                        nativeName: "Botswana",
                        nationalityName: "Botzwanian",
                        capital: "Gaborone",
                        continent: "Africa",
                        currencyCode: "BWP",
                        domain: "bw",
                        iddCode: "267")
                },
                {
                                "BV",
                    new Country(
                        isoNumeric: 74,
                        iso2: "BV",
                        iso3: "BVT",
                        englishName: "Bouvet Island",
                        nativeName: "Bouvet Island",
                        nationalityName: null,
                        capital: "Krone",
                        continent: "Antarctica",
                        currencyCode: "NOK",
                        domain: "bv",
                        iddCode: null)
                },
                {
                                "BR",
                    new Country(
                        isoNumeric: 76,
                        iso2: "BR",
                        iso3: "BRA",
                        englishName: "Brazil",
                        nativeName: "Brasil",
                        nationalityName: "Brazilian",
                        capital: "Brasilia",
                        continent: "South America",
                        currencyCode: "BRL",
                        domain: "br",
                        iddCode: "55")
                },
                {
                                "BZ",
                    new Country(
                        isoNumeric: 84,
                        iso2: "BZ",
                        iso3: "BLZ",
                        englishName: "Belize",
                        nativeName: "Belize",
                        nationalityName: "Belizean",
                        capital: "Belmopan",
                        continent: "North America",
                        currencyCode: "BZD",
                        domain: "bz",
                        iddCode: "501")
                },
                {
                                "IO",
                    new Country(
                        isoNumeric: 86,
                        iso2: "IO",
                        iso3: "IOT",
                        englishName: "British Indian Ocean Territory",
                        nativeName: null,
                        nationalityName: null,
                        capital: "Diego Garcia",
                        continent: "Asia",
                        currencyCode: "GBP",
                        domain: "io",
                        iddCode: "246")
                },
                {
                                "SB",
                    new Country(
                        isoNumeric: 90,
                        iso2: "SB",
                        iso3: "SLB",
                        englishName: "Solomon Islands",
                        nativeName: null,
                        nationalityName: "Solomon Islander",
                        capital: "Honiara",
                        continent: "Oceania",
                        currencyCode: "SBD",
                        domain: "sb",
                        iddCode: "677")
                },
                {
                                "VG",
                    new Country(
                        isoNumeric: 92,
                        iso2: "VG",
                        iso3: "VGB",
                        englishName: "British Virgin Islands",
                        nativeName: null,
                        nationalityName: "Virgin Islander",
                        capital: "Road Town",
                        continent: "North America",
                        currencyCode: "USD",
                        domain: "vg",
                        iddCode: "1284")
                },
                {
                                "BN",
                    new Country(
                        isoNumeric: 96,
                        iso2: "BN",
                        iso3: "BRN",
                        englishName: "Brunei",
                        nativeName: "Brunei",
                        nationalityName: "Bruneian",
                        capital: "Bandar Seri Begawan",
                        continent: "Asia",
                        currencyCode: "BND",
                        domain: "bn",
                        iddCode: "673")
                },
                {
                                "BG",
                    new Country(
                        isoNumeric: 100,
                        iso2: "BG",
                        iso3: "BGR",
                        englishName: "Bulgaria",
                        nativeName: "България",
                        nationalityName: "Bulgarian",
                        capital: "Sofia",
                        continent: "Europe",
                        currencyCode: "EUR",
                        domain: "bg",
                        iddCode: "359")
                },
                {
                                "MM",
                    new Country(
                        isoNumeric: 104,
                        iso2: "MM",
                        iso3: "MMR",
                        englishName: "Myanmar",
                        nativeName: "မြန်မာ",
                        nationalityName: "Burmese",
                        capital: "Nay Pyi Taw",
                        continent: "Asia",
                        currencyCode: "MMK",
                        domain: "mm",
                        iddCode: "95")
                },
                {
                                "BI",
                    new Country(
                        isoNumeric: 108,
                        iso2: "BI",
                        iso3: "BDI",
                        englishName: "Burundi",
                        nativeName: null,
                        nationalityName: "Burundian",
                        capital: "Bujumbura",
                        continent: "Africa",
                        currencyCode: "BIF",
                        domain: "bi",
                        iddCode: "257")
                },
                {
                                "BY",
                    new Country(
                        isoNumeric: 112,
                        iso2: "BY",
                        iso3: "BLR",
                        englishName: "Belarus",
                        nativeName: "Беларусь",
                        nationalityName: "Belorussian",
                        capital: "Minsk",
                        continent: "Europe",
                        currencyCode: "BYR",
                        domain: "by",
                        iddCode: "375")
                },
                {
                                "KH",
                    new Country(
                        isoNumeric: 116,
                        iso2: "KH",
                        iso3: "KHM",
                        englishName: "Cambodia",
                        nativeName: "កម្ពុជា",
                        nationalityName: "Cambodian",
                        capital: "Phnom Penh",
                        continent: "Asia",
                        currencyCode: "KHR",
                        domain: "kh",
                        iddCode: "855")
                },
                {
                                "CM",
                    new Country(
                        isoNumeric: 120,
                        iso2: "CM",
                        iso3: "CMR",
                        englishName: "Cameroon",
                        nativeName: "Cameroun",
                        nationalityName: "Cameroonian",
                        capital: "Yaounde",
                        continent: "Africa",
                        currencyCode: "XAF",
                        domain: "cm",
                        iddCode: "237")
                },
                {
                                "CA",
                    new Country(
                        isoNumeric: 124,
                        iso2: "CA",
                        iso3: "CAN",
                        englishName: "Canada",
                        nativeName: "Canada",
                        nationalityName: "Canadian",
                        capital: "Ottawa",
                        continent: "North America",
                        currencyCode: "CAD",
                        domain: "ca",
                        iddCode: "1")
                },
                {
                                "CV",
                    new Country(
                        isoNumeric: 132,
                        iso2: "CV",
                        iso3: "CPV",
                        englishName: "Cape Verde",
                        nativeName: null,
                        nationalityName: "Cabo Verdean",
                        capital: "Praia",
                        continent: "Africa",
                        currencyCode: "CVE",
                        domain: "cv",
                        iddCode: "238")
                },
                {
                                "KY",
                    new Country(
                        isoNumeric: 136,
                        iso2: "KY",
                        iso3: "CYM",
                        englishName: "Cayman Islands",
                        nativeName: null,
                        nationalityName: "Caymanian",
                        capital: "George Town",
                        continent: "North America",
                        currencyCode: "USD",
                        domain: "ky",
                        iddCode: "1345")
                },
                {
                                "CF",
                    new Country(
                        isoNumeric: 140,
                        iso2: "CF",
                        iso3: "CAF",
                        englishName: "Central African Republic",
                        nativeName: null,
                        nationalityName: "Central African",
                        capital: "Bangui",
                        continent: "Africa",
                        currencyCode: "XAF",
                        domain: "cf",
                        iddCode: "236")
                },
                {
                                "LK",
                    new Country(
                        isoNumeric: 144,
                        iso2: "LK",
                        iso3: "LKA",
                        englishName: "Sri Lanka",
                        nativeName: "ශ්‍රී ලංකාව",
                        nationalityName: "Sri Lankan",
                        capital: "Colombo",
                        continent: "Asia",
                        currencyCode: "LKR",
                        domain: "lk",
                        iddCode: "94")
                },
                {
                                "TD",
                    new Country(
                        isoNumeric: 148,
                        iso2: "TD",
                        iso3: "TCD",
                        englishName: "Chad",
                        nativeName: null,
                        nationalityName: "hadian",
                        capital: "N'Djamena",
                        continent: "Africa",
                        currencyCode: "XAF",
                        domain: "td",
                        iddCode: "235")
                },
                {
                                "CL",
                    new Country(
                        isoNumeric: 152,
                        iso2: "CL",
                        iso3: "CHL",
                        englishName: "Chile",
                        nativeName: "Chile",
                        nationalityName: "Chilean",
                        capital: "Santiago",
                        continent: "South America",
                        currencyCode: "CLP",
                        domain: "cl",
                        iddCode: "56")
                },
                {
                                "CN",
                    new Country(
                        isoNumeric: 156,
                        iso2: "CN",
                        iso3: "CHN",
                        englishName: "China",
                        nativeName: "ཀྲུང་ཧྭ་མི་དམངས་སྤྱི་མཐུན་རྒྱལ་ཁབ།",
                        nationalityName: "Chinese",
                        capital: "Beijing",
                        continent: "Asia",
                        currencyCode: "CNY",
                        domain: "cn",
                        iddCode: "86")
                },
                {
                                "TW",
                    new Country(
                        isoNumeric: 158,
                        iso2: "TW",
                        iso3: "TWN",
                        englishName: "Taiwan",
                        nativeName: "台灣",
                        nationalityName: "Taiwanese",
                        capital: "Taipei",
                        continent: "Asia",
                        currencyCode: "TWD",
                        domain: "tw",
                        iddCode: "886")
                },
                {
                                "CX",
                    new Country(
                        isoNumeric: 162,
                        iso2: "CX",
                        iso3: "CXR",
                        englishName: "Christmas Island",
                        nativeName: null,
                        nationalityName: "Christmas Islander",
                        capital: "Flying Fish Cove",
                        continent: "Asia",
                        currencyCode: "AUD",
                        domain: "cx",
                        iddCode: "61")
                },
                {
                                "CC",
                    new Country(
                        isoNumeric: 166,
                        iso2: "CC",
                        iso3: "CCK",
                        englishName: "Cocos Islands",
                        nativeName: null,
                        nationalityName: "Cocossian",
                        capital: "West Island",
                        continent: "Asia",
                        currencyCode: "USD",
                        domain: "cc",
                        iddCode: "61")
                },
                {
                                "CO",
                    new Country(
                        isoNumeric: 170,
                        iso2: "CO",
                        iso3: "COL",
                        englishName: "Colombia",
                        nativeName: "Colombia",
                        nationalityName: "Colombian",
                        capital: "Bogota",
                        continent: "South America",
                        currencyCode: "COP",
                        domain: "co",
                        iddCode: "57")
                },
                {
                                "KM",
                    new Country(
                        isoNumeric: 174,
                        iso2: "KM",
                        iso3: "COM",
                        englishName: "Comoros",
                        nativeName: null,
                        nationalityName: "Comorian",
                        capital: "Moroni",
                        continent: "Africa",
                        currencyCode: "KMF",
                        domain: "km",
                        iddCode: "269")
                },
                {
                                "YT",
                    new Country(
                        isoNumeric: 175,
                        iso2: "YT",
                        iso3: "MYT",
                        englishName: "Mayotte",
                        nativeName: null,
                        nationalityName: "Mahorais",
                        capital: "Mamoudzou",
                        continent: "Africa",
                        currencyCode: "EUR",
                        domain: "yt",
                        iddCode: "262")
                },
                {
                                "CG",
                    new Country(
                        isoNumeric: 178,
                        iso2: "CG",
                        iso3: "COG",
                        englishName: "Republic of the Congo",
                        nativeName: null,
                        nationalityName: "Congolese",
                        capital: "Brazzaville",
                        continent: "Africa",
                        currencyCode: "XAF",
                        domain: "cg",
                        iddCode: "242")
                },
                {
                                "CD",
                    new Country(
                        isoNumeric: 180,
                        iso2: "CD",
                        iso3: "COD",
                        englishName: "Democratic Republic of the Congo",
                        nativeName: "Congo, République démocratique du",
                        nationalityName: "Congolese",
                        capital: "Kinshasa",
                        continent: "Africa",
                        currencyCode: "CDF",
                        domain: "cd",
                        iddCode: "243")
                },
                {
                                "CK",
                    new Country(
                        isoNumeric: 184,
                        iso2: "CK",
                        iso3: "COK",
                        englishName: "Cook Islands",
                        nativeName: null,
                        nationalityName: "Cook Islander",
                        capital: "Avarua",
                        continent: "Oceania",
                        currencyCode: "NZD",
                        domain: "ck",
                        iddCode: "682")
                },
                {
                                "CR",
                    new Country(
                        isoNumeric: 188,
                        iso2: "CR",
                        iso3: "CRI",
                        englishName: "Costa Rica",
                        nativeName: "Costa Rica",
                        nationalityName: "Costa Rican",
                        capital: "San Jose",
                        continent: "North America",
                        currencyCode: "CRC",
                        domain: "cr",
                        iddCode: "506")
                },
                {
                                "HR",
                    new Country(
                        isoNumeric: 191,
                        iso2: "HR",
                        iso3: "HRV",
                        englishName: "Croatia",
                        nativeName: "Hrvatska",
                        nationalityName: "Croatian",
                        capital: "Zagreb",
                        continent: "Europe",
                        currencyCode: "HRK",
                        domain: "hr",
                        iddCode: "385")
                },
                {
                                "CU",
                    new Country(
                        isoNumeric: 192,
                        iso2: "CU",
                        iso3: "CUB",
                        englishName: "Cuba",
                        nativeName: "Cuba",
                        nationalityName: "Cuban",
                        capital: "Havana",
                        continent: "North America",
                        currencyCode: "CUP",
                        domain: "cu",
                        iddCode: "53")
                },
                {
                                "CY",
                    new Country(
                        isoNumeric: 196,
                        iso2: "CY",
                        iso3: "CYP",
                        englishName: "Cyprus",
                        nativeName: null,
                        nationalityName: "Cypriot",
                        capital: "Nicosia",
                        continent: "Europe",
                        currencyCode: "EUR",
                        domain: "cy",
                        iddCode: "357")
                },
                {
                                "CZ",
                    new Country(
                        isoNumeric: 203,
                        iso2: "CZ",
                        iso3: "CZE",
                        englishName: "Czech Republic",
                        nativeName: "Česká republika",
                        nationalityName: "Czech",
                        capital: "Prague",
                        continent: "Europe",
                        currencyCode: "CZK",
                        domain: "cz",
                        iddCode: "420")
                },
                {
                                "BJ",
                    new Country(
                        isoNumeric: 204,
                        iso2: "BJ",
                        iso3: "BEN",
                        englishName: "Benin",
                        nativeName: null,
                        nationalityName: "Beninese",
                        capital: "Porto-Novo",
                        continent: "Africa",
                        currencyCode: "XOF",
                        domain: "bj",
                        iddCode: "229")
                },
                {
                                "DK",
                    new Country(
                        isoNumeric: 208,
                        iso2: "DK",
                        iso3: "DNK",
                        englishName: "Denmark",
                        nativeName: "Danmark",
                        nationalityName: "Danish",
                        capital: "Copenhagen",
                        continent: "Europe",
                        currencyCode: "DKK",
                        domain: "dk",
                        iddCode: "45")
                },
                {
                                "DM",
                    new Country(
                        isoNumeric: 212,
                        iso2: "DM",
                        iso3: "DMA",
                        englishName: "Dominica",
                        nativeName: null,
                        nationalityName: "Dominican",
                        capital: "Roseau",
                        continent: "North America",
                        currencyCode: "XCD",
                        domain: "dm",
                        iddCode: "1767")
                },
                {
                                "DO",
                    new Country(
                        isoNumeric: 214,
                        iso2: "DO",
                        iso3: "DOM",
                        englishName: "Dominican Republic",
                        nativeName: "República Dominicana",
                        nationalityName: "Dominican",
                        capital: "Santo Domingo",
                        continent: "North America",
                        currencyCode: "DOP",
                        domain: "do",
                        iddCode: "1809")
                },
                {
                                "EC",
                    new Country(
                        isoNumeric: 218,
                        iso2: "EC",
                        iso3: "ECU",
                        englishName: "Ecuador",
                        nativeName: "Ecuador",
                        nationalityName: "Ecuadorean",
                        capital: "Quito",
                        continent: "South America",
                        currencyCode: "USD",
                        domain: "ec",
                        iddCode: "593")
                },
                {
                                "SV",
                    new Country(
                        isoNumeric: 222,
                        iso2: "SV",
                        iso3: "SLV",
                        englishName: "El Salvador",
                        nativeName: "El Salvador",
                        nationalityName: "Salvadorean",
                        capital: "San Salvador",
                        continent: "North America",
                        currencyCode: "USD",
                        domain: "sv",
                        iddCode: "503")
                },
                {
                                "GQ",
                    new Country(
                        isoNumeric: 226,
                        iso2: "GQ",
                        iso3: "GNQ",
                        englishName: "Equatorial Guinea",
                        nativeName: null,
                        nationalityName: "Equatorial Guinean",
                        capital: "Malabo",
                        continent: "Africa",
                        currencyCode: "XAF",
                        domain: "gq",
                        iddCode: "240")
                },
                {
                                "ET",
                    new Country(
                        isoNumeric: 231,
                        iso2: "ET",
                        iso3: "ETH",
                        englishName: "Ethiopia",
                        nativeName: "ኢትዮጵያ",
                        nationalityName: "Ethiopian",
                        capital: "Addis Ababa",
                        continent: "Africa",
                        currencyCode: "STB",
                        domain: "et",
                        iddCode: "251")
                },
                {
                                "ER",
                    new Country(
                        isoNumeric: 232,
                        iso2: "ER",
                        iso3: "ERI",
                        englishName: "Eritrea",
                        nativeName: "ኤርትራ",
                        nationalityName: "Eritrean",
                        capital: "Asmara",
                        continent: "Africa",
                        currencyCode: "ERN",
                        domain: "er",
                        iddCode: "291")
                },
                {
                                "EE",
                    new Country(
                        isoNumeric: 233,
                        iso2: "EE",
                        iso3: "EST",
                        englishName: "Estonia",
                        nativeName: "Eesti",
                        nationalityName: "Estonian",
                        capital: "Tallinn",
                        continent: "Europe",
                        currencyCode: "EUR",
                        domain: "ee",
                        iddCode: "372")
                },
                {
                                "FO",
                    new Country(
                        isoNumeric: 234,
                        iso2: "FO",
                        iso3: "FRO",
                        englishName: "Faroe Islands",
                        nativeName: "Føroyar",
                        nationalityName: "Faroese",
                        capital: "Torshavn",
                        continent: "Europe",
                        currencyCode: "DKK",
                        domain: "fo",
                        iddCode: "298")
                },
                {
                                "FK",
                    new Country(
                        isoNumeric: 238,
                        iso2: "FK",
                        iso3: "FLK",
                        englishName: "Falkland Islands",
                        nativeName: null,
                        nationalityName: "Falkland Islander",
                        capital: "Stanley",
                        continent: "South America",
                        currencyCode: "FKP",
                        domain: "fk",
                        iddCode: "500")
                },
                {
                                "GS",
                    new Country(
                        isoNumeric: 239,
                        iso2: "GS",
                        iso3: "SGS",
                        englishName: "South Georgia and the South Sandwich Islands",
                        nativeName: "South Georgia and the South Sandwich Islands",
                        nationalityName: "South Georgian",
                        capital: "Grytviken",
                        continent: "Antarctica",
                        currencyCode: "GBP",
                        domain: "gs",
                        iddCode: "500")
                },
                {
                                "FJ",
                    new Country(
                        isoNumeric: 242,
                        iso2: "FJ",
                        iso3: "FJI",
                        englishName: "Fiji",
                        nativeName: null,
                        nationalityName: "Fijian",
                        capital: "Suva",
                        continent: "Oceania",
                        currencyCode: "FJD",
                        domain: "fj",
                        iddCode: "679")
                },
                {
                                "FI",
                    new Country(
                        isoNumeric: 246,
                        iso2: "FI",
                        iso3: "FIN",
                        englishName: "Finland",
                        nativeName: "Suomi",
                        nationalityName: "Finnish",
                        capital: "Helsinki",
                        continent: "Europe",
                        currencyCode: "EUR",
                        domain: "fi",
                        iddCode: "358")
                },
                {
                                "AX",
                    new Country(
                        isoNumeric: 248,
                        iso2: "AX",
                        iso3: "ALA",
                        englishName: "Aland Islands",
                        nativeName: "Åland Islands",
                        nationalityName: "Ålandish",
                        capital: "Mariehamn",
                        continent: "Europe",
                        currencyCode: "EUR",
                        domain: "ax",
                        iddCode: "35818")
                },
                {
                                "FR",
                    new Country(
                        isoNumeric: 250,
                        iso2: "FR",
                        iso3: "FRA",
                        englishName: "France",
                        nativeName: "Frañs",
                        nationalityName: "French",
                        capital: "Paris",
                        continent: "Europe",
                        currencyCode: "EUR",
                        domain: "fr",
                        iddCode: "33")
                },
                {
                                "GF",
                    new Country(
                        isoNumeric: 254,
                        iso2: "GF",
                        iso3: "GUF",
                        englishName: "French Guiana",
                        nativeName: "French Guiana",
                        nationalityName: "French Guianese",
                        capital: "Cayenne",
                        continent: "South America",
                        currencyCode: "EUR",
                        domain: "gf",
                        iddCode: "594")
                },
                {
                                "PF",
                    new Country(
                        isoNumeric: 258,
                        iso2: "PF",
                        iso3: "PYF",
                        englishName: "French Polynesia",
                        nativeName: null,
                        nationalityName: "French Polynesian",
                        capital: "Papeete",
                        continent: "Oceania",
                        currencyCode: null,
                        domain: "pf",
                        iddCode: "689")
                },
                {
                                "TF",
                    new Country(
                        isoNumeric: 260,
                        iso2: "TF",
                        iso3: "ATF",
                        englishName: "French Southern Territories",
                        nativeName: "French Southern Territories",
                        nationalityName: null,
                        capital: "Port-aux-Francais",
                        continent: "Antarctica",
                        currencyCode: "EUR",
                        domain: "tf",
                        iddCode: null)
                },
                {
                                "DJ",
                    new Country(
                        isoNumeric: 262,
                        iso2: "DJ",
                        iso3: "DJI",
                        englishName: "Djibouti",
                        nativeName: "Yabuuti",
                        nationalityName: "Djiboutian",
                        capital: "Djibouti",
                        continent: "Africa",
                        currencyCode: "DJF",
                        domain: "dj",
                        iddCode: "253")
                },
                {
                                "GA",
                    new Country(
                        isoNumeric: 266,
                        iso2: "GA",
                        iso3: "GAB",
                        englishName: "Gabon",
                        nativeName: null,
                        nationalityName: "Gabonese",
                        capital: "Libreville",
                        continent: "Africa",
                        currencyCode: "XAF",
                        domain: "ga",
                        iddCode: "241")
                },
                {
                                "GE",
                    new Country(
                        isoNumeric: 268,
                        iso2: "GE",
                        iso3: "GEO",
                        englishName: "Georgia",
                        nativeName: "საქართველო",
                        nationalityName: "Georgian",
                        capital: "Tbilisi",
                        continent: "Asia",
                        currencyCode: "GEL",
                        domain: "ge",
                        iddCode: "995")
                },
                {
                                "GM",
                    new Country(
                        isoNumeric: 270,
                        iso2: "GM",
                        iso3: "GMB",
                        englishName: "Gambia",
                        nativeName: null,
                        nationalityName: "Gambian",
                        capital: "Banjul",
                        continent: "Africa",
                        currencyCode: "GMD",
                        domain: "gm",
                        iddCode: "220")
                },
                {
                                "PS",
                    new Country(
                        isoNumeric: 275,
                        iso2: "PS",
                        iso3: "PSE",
                        englishName: "Palestine",
                        nativeName: null,
                        nationalityName: "Palestinian",
                        capital: "East Jerusalem",
                        continent: "Asia",
                        currencyCode: "ILS",
                        domain: "ps",
                        iddCode: "970")
                },
                {
                                "DE",
                    new Country(
                        isoNumeric: 276,
                        iso2: "DE",
                        iso3: "DEU",
                        englishName: "Germany",
                        nativeName: "Deutschland",
                        nationalityName: "German",
                        capital: "Berlin",
                        continent: "Europe",
                        currencyCode: "EUR",
                        domain: "de",
                        iddCode: "49")
                },
                {
                                "GH",
                    new Country(
                        isoNumeric: 288,
                        iso2: "GH",
                        iso3: "GHA",
                        englishName: "Ghana",
                        nativeName: null,
                        nationalityName: "Ghanian",
                        capital: "Accra",
                        continent: "Africa",
                        currencyCode: "GHS",
                        domain: "gh",
                        iddCode: "233")
                },
                {
                                "GI",
                    new Country(
                        isoNumeric: 292,
                        iso2: "GI",
                        iso3: "GIB",
                        englishName: "Gibraltar",
                        nativeName: null,
                        nationalityName: "Gibraltarian",
                        capital: "Gibraltar",
                        continent: "Europe",
                        currencyCode: "GIP",
                        domain: "gi",
                        iddCode: "350")
                },
                {
                                "KI",
                    new Country(
                        isoNumeric: 296,
                        iso2: "KI",
                        iso3: "KIR",
                        englishName: "Kiribati",
                        nativeName: null,
                        nationalityName: "I-Kiribati",
                        capital: "Tarawa",
                        continent: "Oceania",
                        currencyCode: "AUD",
                        domain: "ki",
                        iddCode: "686")
                },
                {
                                "GR",
                    new Country(
                        isoNumeric: 300,
                        iso2: "GR",
                        iso3: "GRC",
                        englishName: "Greece",
                        nativeName: "Ελλάδα",
                        nationalityName: "Greek",
                        capital: "Athens",
                        continent: "Europe",
                        currencyCode: "EUR",
                        domain: "gr",
                        iddCode: "30")
                },
                {
                                "GL",
                    new Country(
                        isoNumeric: 304,
                        iso2: "GL",
                        iso3: "GRL",
                        englishName: "Greenland",
                        nativeName: "Kalaallit Nunaat",
                        nationalityName: "Greenlander",
                        capital: "Nuuk",
                        continent: "North America",
                        currencyCode: "DKK",
                        domain: "gl",
                        iddCode: "299")
                },
                {
                                "GD",
                    new Country(
                        isoNumeric: 308,
                        iso2: "GD",
                        iso3: "GRD",
                        englishName: "Grenada",
                        nativeName: null,
                        nationalityName: "Grenadian",
                        capital: "St. George's",
                        continent: "North America",
                        currencyCode: "XCD",
                        domain: "gd",
                        iddCode: "1473")
                },
                {
                                "GP",
                    new Country(
                        isoNumeric: 312,
                        iso2: "GP",
                        iso3: "GLP",
                        englishName: "Guadeloupe",
                        nativeName: "Guadeloupe",
                        nationalityName: "Guadeloupean",
                        capital: "Basse-Terre",
                        continent: "North America",
                        currencyCode: "EUR",
                        domain: "gp",
                        iddCode: "590")
                },
                {
                                "GU",
                    new Country(
                        isoNumeric: 316,
                        iso2: "GU",
                        iso3: "GUM",
                        englishName: "Guam",
                        nativeName: null,
                        nationalityName: "Guamanian",
                        capital: "Hagatna",
                        continent: "Oceania",
                        currencyCode: "USD",
                        domain: "gu",
                        iddCode: "1671")
                },
                {
                                "GT",
                    new Country(
                        isoNumeric: 320,
                        iso2: "GT",
                        iso3: "GTM",
                        englishName: "Guatemala",
                        nativeName: "Guatemala",
                        nationalityName: "Guatemalan",
                        capital: "Guatemala City",
                        continent: "North America",
                        currencyCode: "GTQ",
                        domain: "gt",
                        iddCode: "502")
                },
                {
                                "GN",
                    new Country(
                        isoNumeric: 324,
                        iso2: "GN",
                        iso3: "GIN",
                        englishName: "Guinea",
                        nativeName: null,
                        nationalityName: "Guinean",
                        capital: "Conakry",
                        continent: "Africa",
                        currencyCode: "GNF",
                        domain: "gn",
                        iddCode: "224")
                },
                {
                                "GY",
                    new Country(
                        isoNumeric: 328,
                        iso2: "GY",
                        iso3: "GUY",
                        englishName: "Guyana",
                        nativeName: null,
                        nationalityName: "Guyanese",
                        capital: "Georgetown",
                        continent: "South America",
                        currencyCode: "GYD",
                        domain: "gy",
                        iddCode: "592")
                },
                {
                                "HT",
                    new Country(
                        isoNumeric: 332,
                        iso2: "HT",
                        iso3: "HTI",
                        englishName: "Haiti",
                        nativeName: "Haïti",
                        nationalityName: "Haitian",
                        capital: "Port-au-Prince",
                        continent: "North America",
                        currencyCode: "HTG",
                        domain: "ht",
                        iddCode: "509")
                },
                {
                                "HM",
                    new Country(
                        isoNumeric: 334,
                        iso2: "HM",
                        iso3: "HMD",
                        englishName: "Heard Island and McDonald Islands",
                        nativeName: "Heard Island and McDonald Islands",
                        nationalityName: null,
                        capital: null,
                        continent: "Antarctica",
                        currencyCode: "AUD",
                        domain: "hm",
                        iddCode: null)
                },
                {
                                "VA",
                    new Country(
                        isoNumeric: 336,
                        iso2: "VA",
                        iso3: "VAT",
                        englishName: "Vatican",
                        nativeName: null,
                        nationalityName: null,
                        capital: "Vatican City",
                        continent: "Europe",
                        currencyCode: "EUR",
                        domain: "va",
                        iddCode: "39")
                },
                {
                                "HN",
                    new Country(
                        isoNumeric: 340,
                        iso2: "HN",
                        iso3: "HND",
                        englishName: "Honduras",
                        nativeName: "Honduras",
                        nationalityName: "Honduran",
                        capital: "Tegucigalpa",
                        continent: "North America",
                        currencyCode: "HNL",
                        domain: "hn",
                        iddCode: "504")
                },
                {
                                "HK",
                    new Country(
                        isoNumeric: 344,
                        iso2: "HK",
                        iso3: "HKG",
                        englishName: "Hong Kong",
                        nativeName: "Hong Kong",
                        nationalityName: "Hong Konger",
                        capital: "Hong Kong",
                        continent: "Asia",
                        currencyCode: "HKD",
                        domain: "hk",
                        iddCode: "852")
                },
                {
                                "HU",
                    new Country(
                        isoNumeric: 348,
                        iso2: "HU",
                        iso3: "HUN",
                        englishName: "Hungary",
                        nativeName: "Magyarország",
                        nationalityName: "Hungarian",
                        capital: "Budapest",
                        continent: "Europe",
                        currencyCode: "HUF",
                        domain: "hu",
                        iddCode: "36")
                },
                {
                                "IS",
                    new Country(
                        isoNumeric: 352,
                        iso2: "IS",
                        iso3: "ISL",
                        englishName: "Iceland",
                        nativeName: "Ísland",
                        nationalityName: "Icelandic",
                        capital: "Reykjavik",
                        continent: "Europe",
                        currencyCode: "ISK",
                        domain: "is",
                        iddCode: "354")
                },
                {
                                "IN",
                    new Country(
                        isoNumeric: 356,
                        iso2: "IN",
                        iso3: "IND",
                        englishName: "India",
                        nativeName: "ভাৰত",
                        nationalityName: "Indian",
                        capital: "New Delhi",
                        continent: "Asia",
                        currencyCode: "INR",
                        domain: "in",
                        iddCode: "91")
                },
                {
                                "ID",
                    new Country(
                        isoNumeric: 360,
                        iso2: "ID",
                        iso3: "IDN",
                        englishName: "Indonesia",
                        nativeName: "Indonesia",
                        nationalityName: "Indonesian",
                        capital: "Jakarta",
                        continent: "Asia",
                        currencyCode: "IDR",
                        domain: "id",
                        iddCode: "62")
                },
                {
                                "IR",
                    new Country(
                        isoNumeric: 364,
                        iso2: "IR",
                        iso3: "IRN",
                        englishName: "Iran",
                        nativeName: "ایران",
                        nationalityName: "Iranian",
                        capital: "Tehran",
                        continent: "Asia",
                        currencyCode: "IRR",
                        domain: "ir",
                        iddCode: "98")
                },
                {
                                "IQ",
                    new Country(
                        isoNumeric: 368,
                        iso2: "IQ",
                        iso3: "IRQ",
                        englishName: "Iraq",
                        nativeName: "العراق",
                        nationalityName: "Iraqi",
                        capital: "Baghdad",
                        continent: "Asia",
                        currencyCode: "IQD",
                        domain: "iq",
                        iddCode: "964")
                },
                {
                                "IE",
                    new Country(
                        isoNumeric: 372,
                        iso2: "IE",
                        iso3: "IRL",
                        englishName: "Ireland",
                        nativeName: "Ireland",
                        nationalityName: "Irishman",
                        capital: "Dublin",
                        continent: "Europe",
                        currencyCode: "EUR",
                        domain: "ie",
                        iddCode: "353")
                },
                {
                                "IL",
                    new Country(
                        isoNumeric: 376,
                        iso2: "IL",
                        iso3: "ISR",
                        englishName: "Israel",
                        nativeName: "ישראל",
                        nationalityName: "Israeli",
                        capital: "Jerusalem",
                        continent: "Asia",
                        currencyCode: "ILS",
                        domain: "il",
                        iddCode: "972")
                },
                {
                                "IT",
                    new Country(
                        isoNumeric: 380,
                        iso2: "IT",
                        iso3: "ITA",
                        englishName: "Italy",
                        nativeName: "Italia",
                        nationalityName: "Italian",
                        capital: "Rome",
                        continent: "Europe",
                        currencyCode: "EUR",
                        domain: "it",
                        iddCode: "39")
                },
                {
                                "CI",
                    new Country(
                        isoNumeric: 384,
                        iso2: "CI",
                        iso3: "CIV",
                        englishName: "Ivory Coast",
                        nativeName: "Côte d’Ivoire",
                        nationalityName: "Ivorian",
                        capital: "Yamoussoukro",
                        continent: "Africa",
                        currencyCode: "XOF",
                        domain: "ci",
                        iddCode: "225")
                },
                {
                                "JM",
                    new Country(
                        isoNumeric: 388,
                        iso2: "JM",
                        iso3: "JAM",
                        englishName: "Jamaica",
                        nativeName: "Jamaica",
                        nationalityName: "Jamaican",
                        capital: "Kingston",
                        continent: "North America",
                        currencyCode: "JMD",
                        domain: "jm",
                        iddCode: "1876")
                },
                {
                                "JP",
                    new Country(
                        isoNumeric: 392,
                        iso2: "JP",
                        iso3: "JPN",
                        englishName: "Japan",
                        nativeName: "日本",
                        nationalityName: "Japanese",
                        capital: "Tokyo",
                        continent: "Asia",
                        currencyCode: "JPY",
                        domain: "jp",
                        iddCode: "81")
                },
                {
                                "KZ",
                    new Country(
                        isoNumeric: 398,
                        iso2: "KZ",
                        iso3: "KAZ",
                        englishName: "Kazakhstan",
                        nativeName: "Қазақстан",
                        nationalityName: "Khazakstani",
                        capital: "Astana",
                        continent: "Asia",
                        currencyCode: "KZT",
                        domain: "kz",
                        iddCode: "76")
                },
                {
                                "JO",
                    new Country(
                        isoNumeric: 400,
                        iso2: "JO",
                        iso3: "JOR",
                        englishName: "Jordan",
                        nativeName: "الأردن",
                        nationalityName: "Jordanian",
                        capital: "Amman",
                        continent: "Asia",
                        currencyCode: "JOD",
                        domain: "jo",
                        iddCode: "962")
                },
                {
                                "KE",
                    new Country(
                        isoNumeric: 404,
                        iso2: "KE",
                        iso3: "KEN",
                        englishName: "Kenya",
                        nativeName: "Kenya",
                        nationalityName: "Kenyan",
                        capital: "Nairobi",
                        continent: "Africa",
                        currencyCode: "KES",
                        domain: "ke",
                        iddCode: "254")
                },
                {
                                "KP",
                    new Country(
                        isoNumeric: 408,
                        iso2: "KP",
                        iso3: "PRK",
                        englishName: "North Korea",
                        nativeName: null,
                        nationalityName: "Korean",
                        capital: "Pyongyang",
                        continent: "Asia",
                        currencyCode: "KPW",
                        domain: "kp",
                        iddCode: "850")
                },
                {
                                "KR",
                    new Country(
                        isoNumeric: 410,
                        iso2: "KR",
                        iso3: "KOR",
                        englishName: "Korea",
                        nativeName: "대한민국",
                        nationalityName: "Korean",
                        capital: "Seoul",
                        continent: "Asia",
                        currencyCode: "KRW",
                        domain: "kr",
                        iddCode: "82")
                },
                {
                                "KW",
                    new Country(
                        isoNumeric: 414,
                        iso2: "KW",
                        iso3: "KWT",
                        englishName: "Kuwait",
                        nativeName: "الكويت",
                        nationalityName: "Kuwaiti",
                        capital: "Kuwait City",
                        continent: "Asia",
                        currencyCode: "KWD",
                        domain: "kw",
                        iddCode: "965")
                },
                {
                                "KG",
                    new Country(
                        isoNumeric: 417,
                        iso2: "KG",
                        iso3: "KGZ",
                        englishName: "Kyrgyzstan",
                        nativeName: "Кыргызстан",
                        nationalityName: "Kyrgyzstani",
                        capital: "Bishkek",
                        continent: "Asia",
                        currencyCode: "KGS",
                        domain: "kg",
                        iddCode: "996")
                },
                {
                                "LA",
                    new Country(
                        isoNumeric: 418,
                        iso2: "LA",
                        iso3: "LAO",
                        englishName: "Laos",
                        nativeName: "ລາວ",
                        nationalityName: "Laotian",
                        capital: "Vientiane",
                        continent: "Asia",
                        currencyCode: "LAK",
                        domain: "la",
                        iddCode: "856")
                },
                {
                                "LB",
                    new Country(
                        isoNumeric: 422,
                        iso2: "LB",
                        iso3: "LBN",
                        englishName: "Lebanon",
                        nativeName: "لبنان",
                        nationalityName: "Lebanese",
                        capital: "Beirut",
                        continent: "Asia",
                        currencyCode: "LBP",
                        domain: "lb",
                        iddCode: "961")
                },
                {
                                "LS",
                    new Country(
                        isoNumeric: 426,
                        iso2: "LS",
                        iso3: "LSO",
                        englishName: "Lesotho",
                        nativeName: null,
                        nationalityName: "Mosotho",
                        capital: "Maseru",
                        continent: "Africa",
                        currencyCode: "LSL",
                        domain: "ls",
                        iddCode: "266")
                },
                {
                                "LV",
                    new Country(
                        isoNumeric: 428,
                        iso2: "LV",
                        iso3: "LVA",
                        englishName: "Latvia",
                        nativeName: "Latvija",
                        nationalityName: "Latvian",
                        capital: "Riga",
                        continent: "Europe",
                        currencyCode: "LVL",
                        domain: "lv",
                        iddCode: "371")
                },
                {
                                "LR",
                    new Country(
                        isoNumeric: 430,
                        iso2: "LR",
                        iso3: "LBR",
                        englishName: "Liberia",
                        nativeName: null,
                        nationalityName: "Liberian",
                        capital: "Monrovia",
                        continent: "Africa",
                        currencyCode: "LRD",
                        domain: "lr",
                        iddCode: "231")
                },
                {
                                "LY",
                    new Country(
                        isoNumeric: 434,
                        iso2: "LY",
                        iso3: "LBY",
                        englishName: "Libya",
                        nativeName: "ليبيا",
                        nationalityName: "Libyan",
                        capital: "Tripolis",
                        continent: "Africa",
                        currencyCode: "LYD",
                        domain: "ly",
                        iddCode: "218")
                },
                {
                                "LI",
                    new Country(
                        isoNumeric: 438,
                        iso2: "LI",
                        iso3: "LIE",
                        englishName: "Liechtenstein",
                        nativeName: "Liechtenstein",
                        nationalityName: "Liechtensteiner",
                        capital: "Vaduz",
                        continent: "Europe",
                        currencyCode: "CHF",
                        domain: "li",
                        iddCode: "423")
                },
                {
                                "LT",
                    new Country(
                        isoNumeric: 440,
                        iso2: "LT",
                        iso3: "LTU",
                        englishName: "Lithuania",
                        nativeName: "Lietuva",
                        nationalityName: "Lithuanian",
                        capital: "Vilnius",
                        continent: "Europe",
                        currencyCode: "EUR",
                        domain: "lt",
                        iddCode: "370")
                },
                {
                                "LU",
                    new Country(
                        isoNumeric: 442,
                        iso2: "LU",
                        iso3: "LUX",
                        englishName: "Luxembourg",
                        nativeName: "Luxemburg",
                        nationalityName: "Luxembourger",
                        capital: "Luxembourg",
                        continent: "Europe",
                        currencyCode: "EUR",
                        domain: "lu",
                        iddCode: "352")
                },
                {
                                "MO",
                    new Country(
                        isoNumeric: 446,
                        iso2: "MO",
                        iso3: "MAC",
                        englishName: "Macau",
                        nativeName: "澳門特別行政區",
                        nationalityName: "Macanese",
                        capital: "Macao",
                        continent: "Asia",
                        currencyCode: "MOP",
                        domain: "mo",
                        iddCode: "853")
                },
                {
                                "MG",
                    new Country(
                        isoNumeric: 450,
                        iso2: "MG",
                        iso3: "MDG",
                        englishName: "Madagascar",
                        nativeName: null,
                        nationalityName: "Malagasy",
                        capital: "Antananarivo",
                        continent: "Africa",
                        currencyCode: "MGA",
                        domain: "mg",
                        iddCode: "261")
                },
                {
                                "MW",
                    new Country(
                        isoNumeric: 454,
                        iso2: "MW",
                        iso3: "MWI",
                        englishName: "Malawi",
                        nativeName: null,
                        nationalityName: "Malawian",
                        capital: "Lilongwe",
                        continent: "Africa",
                        currencyCode: "MWK",
                        domain: "mw",
                        iddCode: "265")
                },
                {
                                "MY",
                    new Country(
                        isoNumeric: 458,
                        iso2: "MY",
                        iso3: "MYS",
                        englishName: "Malaysia",
                        nativeName: "Malaysia",
                        nationalityName: "Malaysian",
                        capital: "Kuala Lumpur",
                        continent: "Asia",
                        currencyCode: "MYR",
                        domain: "my",
                        iddCode: "60")
                },
                {
                                "MV",
                    new Country(
                        isoNumeric: 462,
                        iso2: "MV",
                        iso3: "MDV",
                        englishName: "Maldives",
                        nativeName: "ދިވެހި ރާއްޖެ",
                        nationalityName: "Maldivian",
                        capital: "Male",
                        continent: "Asia",
                        currencyCode: "MVR",
                        domain: "mv",
                        iddCode: "960")
                },
                {
                                "ML",
                    new Country(
                        isoNumeric: 466,
                        iso2: "ML",
                        iso3: "MLI",
                        englishName: "Mali",
                        nativeName: "Mali",
                        nationalityName: "Malian",
                        capital: "Bamako",
                        continent: "Africa",
                        currencyCode: "XOF",
                        domain: "ml",
                        iddCode: "223")
                },
                {
                                "MT",
                    new Country(
                        isoNumeric: 470,
                        iso2: "MT",
                        iso3: "MLT",
                        englishName: "Malta",
                        nativeName: "Malta",
                        nationalityName: "Maltese",
                        capital: "Valletta",
                        continent: "Europe",
                        currencyCode: "EUR",
                        domain: "mt",
                        iddCode: "356")
                },
                {
                                "MQ",
                    new Country(
                        isoNumeric: 474,
                        iso2: "MQ",
                        iso3: "MTQ",
                        englishName: "Martinique",
                        nativeName: "Martinique",
                        nationalityName: "Martinican",
                        capital: "Fort-de-France",
                        continent: "North America",
                        currencyCode: "EUR",
                        domain: "mq",
                        iddCode: "596")
                },
                {
                                "MR",
                    new Country(
                        isoNumeric: 478,
                        iso2: "MR",
                        iso3: "MRT",
                        englishName: "Mauritania",
                        nativeName: null,
                        nationalityName: "Mauritanian",
                        capital: "Nouakchott",
                        continent: "Africa",
                        currencyCode: "MRO",
                        domain: "mr",
                        iddCode: "222")
                },
                {
                                "MU",
                    new Country(
                        isoNumeric: 480,
                        iso2: "MU",
                        iso3: "MUS",
                        englishName: "Mauritius",
                        nativeName: null,
                        nationalityName: "Mauritian",
                        capital: "Port Louis",
                        continent: "Africa",
                        currencyCode: "MUR",
                        domain: "mu",
                        iddCode: "222")
                },
                {
                                "MX",
                    new Country(
                        isoNumeric: 484,
                        iso2: "MX",
                        iso3: "MEX",
                        englishName: "Mexico",
                        nativeName: "México",
                        nationalityName: "Mexican",
                        capital: "Mexico City",
                        continent: "North America",
                        currencyCode: "MXN",
                        domain: "mx",
                        iddCode: "52")
                },
                {
                                "MC",
                    new Country(
                        isoNumeric: 492,
                        iso2: "MC",
                        iso3: "MCO",
                        englishName: "Monaco",
                        nativeName: "Monaco",
                        nationalityName: "Monacan",
                        capital: "Monaco",
                        continent: "Europe",
                        currencyCode: "EUR",
                        domain: "mc",
                        iddCode: "377")
                },
                {
                                "MN",
                    new Country(
                        isoNumeric: 496,
                        iso2: "MN",
                        iso3: "MNG",
                        englishName: "Mongolia",
                        nativeName: "Монгол",
                        nationalityName: "Mongolian",
                        capital: "Ulan Bator",
                        continent: "Asia",
                        currencyCode: "MNT",
                        domain: "mn",
                        iddCode: "976")
                },
                {
                                "MD",
                    new Country(
                        isoNumeric: 498,
                        iso2: "MD",
                        iso3: "MDA",
                        englishName: "Moldova",
                        nativeName: "Republica Moldova",
                        nationalityName: "Moldovan",
                        capital: "Chisinau",
                        continent: "Europe",
                        currencyCode: "MDL",
                        domain: "md",
                        iddCode: "373")
                },
                {
                                "ME",
                    new Country(
                        isoNumeric: 499,
                        iso2: "ME",
                        iso3: "MNE",
                        englishName: "Montenegro",
                        nativeName: "Црна Гора",
                        nationalityName: "Montenegrin",
                        capital: "Podgorica",
                        continent: "Europe",
                        currencyCode: "EUR",
                        domain: "me",
                        iddCode: "382")
                },
                {
                                "MS",
                    new Country(
                        isoNumeric: 500,
                        iso2: "MS",
                        iso3: "MSR",
                        englishName: "Montserrat",
                        nativeName: null,
                        nationalityName: "Montserratian",
                        capital: "Plymouth",
                        continent: "North America",
                        currencyCode: "XCD",
                        domain: "ms",
                        iddCode: "1664")
                },
                {
                                "MA",
                    new Country(
                        isoNumeric: 504,
                        iso2: "MA",
                        iso3: "MAR",
                        englishName: "Morocco",
                        nativeName: "المملكة المغربية",
                        nationalityName: "Moroccan",
                        capital: "Rabat",
                        continent: "Africa",
                        currencyCode: "MAD",
                        domain: "ma",
                        iddCode: "212")
                },
                {
                                "MZ",
                    new Country(
                        isoNumeric: 508,
                        iso2: "MZ",
                        iso3: "MOZ",
                        englishName: "Mozambique",
                        nativeName: null,
                        nationalityName: "Mozambican",
                        capital: "Maputo",
                        continent: "Africa",
                        currencyCode: "MZN",
                        domain: "mz",
                        iddCode: "258")
                },
                {
                                "OM",
                    new Country(
                        isoNumeric: 512,
                        iso2: "OM",
                        iso3: "OMN",
                        englishName: "Oman",
                        nativeName: "عمان",
                        nationalityName: "Omani",
                        capital: "Muscat",
                        continent: "Asia",
                        currencyCode: "OMR",
                        domain: "om",
                        iddCode: "968")
                },
                {
                                "NA",
                    new Country(
                        isoNumeric: 516,
                        iso2: "NA",
                        iso3: "NAM",
                        englishName: "Namibia",
                        nativeName: null,
                        nationalityName: "Namibian",
                        capital: "Windhoek",
                        continent: "Africa",
                        currencyCode: "NAD",
                        domain: "na",
                        iddCode: "264")
                },
                {
                                "NR",
                    new Country(
                        isoNumeric: 520,
                        iso2: "NR",
                        iso3: "NRU",
                        englishName: "Nauru",
                        nativeName: null,
                        nationalityName: "Nauruan",
                        capital: "Yaren",
                        continent: "Oceania",
                        currencyCode: "AUD",
                        domain: "nr",
                        iddCode: "674")
                },
                {
                                "NP",
                    new Country(
                        isoNumeric: 524,
                        iso2: "NP",
                        iso3: "NPL",
                        englishName: "Nepal",
                        nativeName: "नेपाल",
                        nationalityName: "Nepalese",
                        capital: "Kathmandu",
                        continent: "Asia",
                        currencyCode: "NPR",
                        domain: "np",
                        iddCode: "977")
                },
                {
                                "NL",
                    new Country(
                        isoNumeric: 528,
                        iso2: "NL",
                        iso3: "NLD",
                        englishName: "Netherlands",
                        nativeName: "Nederlân",
                        nationalityName: "Dutch",
                        capital: "Amsterdam",
                        continent: "Europe",
                        currencyCode: "EUR",
                        domain: "nl",
                        iddCode: "31")
                },
                {
                                "AN",
                    new Country(
                        isoNumeric: 530,
                        iso2: "AN",
                        iso3: "ANT",
                        englishName: "Netherlands Antilles",
                        nativeName: null,
                        nationalityName: "Dutch Antillean",
                        capital: "Willemstad",
                        continent: "North America",
                        currencyCode: "ANG",
                        domain: "an",
                        iddCode: "599")
                },
                {
                                "CW",
                    new Country(
                        isoNumeric: 531,
                        iso2: "CW",
                        iso3: "CUW",
                        englishName: "Curacao",
                        nativeName: null,
                        nationalityName: "Curaçaoan",
                        capital: "Willemstad",
                        continent: "North America",
                        currencyCode: null,
                        domain: "cw",
                        iddCode: "599")
                },
                {
                                "AW",
                    new Country(
                        isoNumeric: 533,
                        iso2: "AW",
                        iso3: "ABW",
                        englishName: "Aruba",
                        nativeName: null,
                        nationalityName: "Aruban",
                        capital: "Oranjestad",
                        continent: "North America",
                        currencyCode: "AWG",
                        domain: "aw",
                        iddCode: "297")
                },
                {
                                "SX",
                    new Country(
                        isoNumeric: 534,
                        iso2: "SX",
                        iso3: "SXM",
                        englishName: "Sint Maarten",
                        nativeName: null,
                        nationalityName: "St. Maartener",
                        capital: "Philipsburg",
                        continent: "North America",
                        currencyCode: null,
                        domain: "sx",
                        iddCode: "1-721")
                },
                {
                                "BQ",
                    new Country(
                        isoNumeric: 535,
                        iso2: "BQ",
                        iso3: "BES",
                        englishName: "Bonaire, Saint Eustatius and Saba",
                        nativeName: "Bonaire",
                        nationalityName: null,
                        capital: null,
                        continent: "North America",
                        currencyCode: null,
                        domain: "bq",
                        iddCode: null)
                },
                {
                                "NC",
                    new Country(
                        isoNumeric: 540,
                        iso2: "NC",
                        iso3: "NCL",
                        englishName: "New Caledonia",
                        nativeName: null,
                        nationalityName: "New Caledonian",
                        capital: "Noumea",
                        continent: "Oceania",
                        currencyCode: null,
                        domain: "nc",
                        iddCode: "687")
                },
                {
                                "VU",
                    new Country(
                        isoNumeric: 548,
                        iso2: "VU",
                        iso3: "VUT",
                        englishName: "Vanuatu",
                        nativeName: null,
                        nationalityName: "Ni-Vanuatu",
                        capital: "Port Vila",
                        continent: "Oceania",
                        currencyCode: "VUV",
                        domain: "vu",
                        iddCode: "678")
                },
                {
                                "NZ",
                    new Country(
                        isoNumeric: 554,
                        iso2: "NZ",
                        iso3: "NZL",
                        englishName: "New Zealand",
                        nativeName: "New Zealand",
                        nationalityName: "New Zealander",
                        capital: "Wellington",
                        continent: "Oceania",
                        currencyCode: "NZD",
                        domain: "nz",
                        iddCode: "64")
                },
                {
                                "NI",
                    new Country(
                        isoNumeric: 558,
                        iso2: "NI",
                        iso3: "NIC",
                        englishName: "Nicaragua",
                        nativeName: "Nicaragua",
                        nationalityName: "Nicaraguan",
                        capital: "Managua",
                        continent: "North America",
                        currencyCode: "NIO",
                        domain: "ni",
                        iddCode: "505")
                },
                {
                                "NE",
                    new Country(
                        isoNumeric: 562,
                        iso2: "NE",
                        iso3: "NER",
                        englishName: "Niger",
                        nativeName: null,
                        nationalityName: "Nigerien",
                        capital: "Niamey",
                        continent: "Africa",
                        currencyCode: "XOF",
                        domain: "ne",
                        iddCode: "227")
                },
                {
                                "NG",
                    new Country(
                        isoNumeric: 566,
                        iso2: "NG",
                        iso3: "NGA",
                        englishName: "Nigeria",
                        nativeName: "Nigeria",
                        nationalityName: "Nigerian",
                        capital: "Abuja",
                        continent: "Africa",
                        currencyCode: "NGN",
                        domain: "ng",
                        iddCode: "234")
                },
                {
                                "NU",
                    new Country(
                        isoNumeric: 570,
                        iso2: "NU",
                        iso3: "NIU",
                        englishName: "Niue",
                        nativeName: null,
                        nationalityName: "Niuean",
                        capital: "Alofi",
                        continent: "Oceania",
                        currencyCode: "NZD",
                        domain: "nu",
                        iddCode: "683")
                },
                {
                                "NF",
                    new Country(
                        isoNumeric: 574,
                        iso2: "NF",
                        iso3: "NFK",
                        englishName: "Norfolk Island",
                        nativeName: "Norfolk Island",
                        nationalityName: "Norfolk Islander",
                        capital: null,
                        continent: "Oceania",
                        currencyCode: "AUD",
                        domain: "nf",
                        iddCode: "672")
                },
                {
                                "NO",
                    new Country(
                        isoNumeric: 578,
                        iso2: "NO",
                        iso3: "NOR",
                        englishName: "Norway",
                        nativeName: "Norge",
                        nationalityName: "Norwegian",
                        capital: "Oslo",
                        continent: "Europe",
                        currencyCode: "NOK",
                        domain: "no",
                        iddCode: "47")
                },
                {
                                "MP",
                    new Country(
                        isoNumeric: 580,
                        iso2: "MP",
                        iso3: "MNP",
                        englishName: "Northern Mariana Islands",
                        nativeName: null,
                        nationalityName: "Northern Mariana Islander",
                        capital: "Saipan",
                        continent: "Oceania",
                        currencyCode: "USD",
                        domain: "mp",
                        iddCode: "1670")
                },
                {
                                "UM",
                    new Country(
                        isoNumeric: 581,
                        iso2: "UM",
                        iso3: "UMI",
                        englishName: "United States Minor Outlying Islands",
                        nativeName: "United States Minor Outlying Islands",
                        nationalityName: "American Islander",
                        capital: null,
                        continent: "Oceania",
                        currencyCode: "USD",
                        domain: "um",
                        iddCode: null)
                },
                {
                                "FM",
                    new Country(
                        isoNumeric: 583,
                        iso2: "FM",
                        iso3: "FSM",
                        englishName: "Micronesia",
                        nativeName: null,
                        nationalityName: "Micronesian",
                        capital: "Palikir",
                        continent: "Oceania",
                        currencyCode: "USD",
                        domain: "fm",
                        iddCode: "691")
                },
                {
                                "MH",
                    new Country(
                        isoNumeric: 584,
                        iso2: "MH",
                        iso3: "MHL",
                        englishName: "Marshall Islands",
                        nativeName: null,
                        nationalityName: "Marshallese",
                        capital: "Majuro",
                        continent: "Oceania",
                        currencyCode: "USD",
                        domain: "mh",
                        iddCode: "692")
                },
                {
                                "PW",
                    new Country(
                        isoNumeric: 585,
                        iso2: "PW",
                        iso3: "PLW",
                        englishName: "Palau",
                        nativeName: null,
                        nationalityName: "Palauan",
                        capital: "Melekeok",
                        continent: "Oceania",
                        currencyCode: "USD",
                        domain: "pw",
                        iddCode: "680")
                },
                {
                                "PK",
                    new Country(
                        isoNumeric: 586,
                        iso2: "PK",
                        iso3: "PAK",
                        englishName: "Pakistan",
                        nativeName: "پاکستان",
                        nationalityName: "Pakistani",
                        capital: "Islamabad",
                        continent: "Asia",
                        currencyCode: "PKR",
                        domain: "pk",
                        iddCode: "92")
                },
                {
                                "PA",
                    new Country(
                        isoNumeric: 591,
                        iso2: "PA",
                        iso3: "PAN",
                        englishName: "Panama",
                        nativeName: "Panamá",
                        nationalityName: "Panamanian",
                        capital: "Panama City",
                        continent: "North America",
                        currencyCode: "USD",
                        domain: "pa",
                        iddCode: "507")
                },
                {
                                "PG",
                    new Country(
                        isoNumeric: 598,
                        iso2: "PG",
                        iso3: "PNG",
                        englishName: "Papua New Guinea",
                        nativeName: null,
                        nationalityName: "Papua New Guinean",
                        capital: "Port Moresby",
                        continent: "Oceania",
                        currencyCode: "PGK",
                        domain: "pg",
                        iddCode: "675")
                },
                {
                                "PY",
                    new Country(
                        isoNumeric: 600,
                        iso2: "PY",
                        iso3: "PRY",
                        englishName: "Paraguay",
                        nativeName: "Paraguay",
                        nationalityName: "Paraguayan",
                        capital: "Asuncion",
                        continent: "South America",
                        currencyCode: "PYG",
                        domain: "py",
                        iddCode: "595")
                },
                {
                                "PE",
                    new Country(
                        isoNumeric: 604,
                        iso2: "PE",
                        iso3: "PER",
                        englishName: "Peru",
                        nativeName: "Perú",
                        nationalityName: "Peruvian",
                        capital: "Lima",
                        continent: "South America",
                        currencyCode: "PEN",
                        domain: "pe",
                        iddCode: "51")
                },
                {
                                "PH",
                    new Country(
                        isoNumeric: 608,
                        iso2: "PH",
                        iso3: "PHL",
                        englishName: "Philippines",
                        nativeName: "Philippines",
                        nationalityName: "Filipino",
                        capital: "Manila",
                        continent: "Asia",
                        currencyCode: "PHP",
                        domain: "ph",
                        iddCode: "63")
                },
                {
                                "PN",
                    new Country(
                        isoNumeric: 612,
                        iso2: "PN",
                        iso3: "PCN",
                        englishName: "Pitcairn Islands",
                        nativeName: null,
                        nationalityName: "Pitcairn Islander",
                        capital: "Adamstown",
                        continent: "Oceania",
                        currencyCode: "NZD",
                        domain: "pn",
                        iddCode: "64")
                },
                {
                                "PL",
                    new Country(
                        isoNumeric: 616,
                        iso2: "PL",
                        iso3: "POL",
                        englishName: "Poland",
                        nativeName: "Polska",
                        nationalityName: "Polish",
                        capital: "Warsaw",
                        continent: "Europe",
                        currencyCode: "PLN",
                        domain: "pl",
                        iddCode: "48")
                },
                {
                                "PT",
                    new Country(
                        isoNumeric: 620,
                        iso2: "PT",
                        iso3: "PRT",
                        englishName: "Portugal",
                        nativeName: "Portugal",
                        nationalityName: "Portuguese",
                        capital: "Lisbon",
                        continent: "Europe",
                        currencyCode: "EUR",
                        domain: "pt",
                        iddCode: "351")
                },
                {
                                "GW",
                    new Country(
                        isoNumeric: 624,
                        iso2: "GW",
                        iso3: "GNB",
                        englishName: "Guinea-Bissau",
                        nativeName: null,
                        nationalityName: "Bissau-Guinean",
                        capital: "Bissau",
                        continent: "Africa",
                        currencyCode: "XOF",
                        domain: "gw",
                        iddCode: "245")
                },
                {
                    "TL",
                    new Country(
                        isoNumeric: 626,
                        iso2: "TL",
                        iso3: "TLS",
                        englishName: "East Timor",
                        nativeName: null,
                        nationalityName: "Timorese",
                        capital: "Dili",
                        continent: "Oceania",
                        currencyCode: "USD",
                        domain: "tl",
                        iddCode: "670")
                },
                {
                    "PR",
                    new Country(
                        isoNumeric: 630,
                        iso2: "PR",
                        iso3: "PRI",
                        englishName: "Puerto Rico",
                        nativeName: "Puerto Rico",
                        nationalityName: "Puerto Rican",
                        capital: "San Juan",
                        continent: "North America",
                        currencyCode: "USD",
                        domain: "pr",
                        iddCode: "1787")
                },
                {
                                "QA",
                    new Country(
                        isoNumeric: 634,
                        iso2: "QA",
                        iso3: "QAT",
                        englishName: "Qatar",
                        nativeName: "قطر",
                        nationalityName: "Quatari",
                        capital: "Doha",
                        continent: "Asia",
                        currencyCode: "QAR",
                        domain: "qa",
                        iddCode: "974")
                },
                {
                    "RE",
                    new Country(
                        isoNumeric: 638,
                        iso2: "RE",
                        iso3: "REU",
                        englishName: "Réunion",
                        nativeName: "La Réunion",
                        nationalityName: "Reunionese",
                        capital: "Saint-Denis",
                        continent: "Africa",
                        currencyCode: "EUR",
                        domain: "re",
                        iddCode: "262")
                },
                {
                                "RO",
                    new Country(
                        isoNumeric: 642,
                        iso2: "RO",
                        iso3: "ROU",
                        englishName: "Romania",
                        nativeName: "România",
                        nationalityName: "Romanian",
                        capital: "Bucharest",
                        continent: "Europe",
                        currencyCode: "RON",
                        domain: "ro",
                        iddCode: "40")
                },
                {
                                "RU",
                    new Country(
                        isoNumeric: 643,
                        iso2: "RU",
                        iso3: "RUS",
                        englishName: "Russia",
                        nativeName: "Рәсәй",
                        nationalityName: "Russian",
                        capital: "Moscow",
                        continent: "Europe",
                        currencyCode: "RUB",
                        domain: "ru",
                        iddCode: "7")
                },
                {
                                "RW",
                    new Country(
                        isoNumeric: 646,
                        iso2: "RW",
                        iso3: "RWA",
                        englishName: "Rwanda",
                        nativeName: "Rwanda",
                        nationalityName: "Rwandan",
                        capital: "Kigali",
                        continent: "Africa",
                        currencyCode: "RWF",
                        domain: "rw",
                        iddCode: "250")
                },
                {
                                "BL",
                    new Country(
                        isoNumeric: 652,
                        iso2: "BL",
                        iso3: "BLM",
                        englishName: "Saint Barthelemy",
                        nativeName: null,
                        nationalityName: "Saint-Barth",
                        capital: "Gustavia",
                        continent: "North America",
                        currencyCode: null,
                        domain: "gp",
                        iddCode: "590")
                },
                {
                                "SH",
                    new Country(
                        isoNumeric: 654,
                        iso2: "SH",
                        iso3: "SHN",
                        englishName: "Saint Helena",
                        nativeName: null,
                        nationalityName: "Saint Helenian",
                        capital: "Jamestown",
                        continent: "Africa",
                        currencyCode: "SHP",
                        domain: "sh",
                        iddCode: "290")
                },
                {
                                "KN",
                    new Country(
                        isoNumeric: 659,
                        iso2: "KN",
                        iso3: "KNA",
                        englishName: "Saint Kitts and Nevis",
                        nativeName: null,
                        nationalityName: "Kittitian",
                        capital: "Basseterre",
                        continent: "North America",
                        currencyCode: "XCD",
                        domain: "kn",
                        iddCode: "1869")
                },
                {
                                "AI",
                    new Country(
                        isoNumeric: 660,
                        iso2: "AI",
                        iso3: "AIA",
                        englishName: "Anguilla",
                        nativeName: null,
                        nationalityName: "Anguillan",
                        capital: "The Valley",
                        continent: "North America",
                        currencyCode: "XCD",
                        domain: "ai",
                        iddCode: "1264")
                },
                {
                                "LC",
                    new Country(
                        isoNumeric: 662,
                        iso2: "LC",
                        iso3: "LCA",
                        englishName: "Saint Lucia",
                        nativeName: null,
                        nationalityName: "Saint Lucian",
                        capital: "Castries",
                        continent: "North America",
                        currencyCode: "XCD",
                        domain: "lc",
                        iddCode: "1758")
                },
                {
                                "MF",
                    new Country(
                        isoNumeric: 663,
                        iso2: "MF",
                        iso3: "MAF",
                        englishName: "Saint Martin",
                        nativeName: null,
                        nationalityName: null,
                        capital: "Marigot",
                        continent: "North America",
                        currencyCode: "EUR",
                        domain: "gp",
                        iddCode: "590")
                },
                {
                                "PM",
                    new Country(
                        isoNumeric: 666,
                        iso2: "PM",
                        iso3: "SPM",
                        englishName: "Saint Pierre and Miquelon",
                        nativeName: null,
                        nationalityName: "Frenchman",
                        capital: "Saint-Pierre",
                        continent: "North America",
                        currencyCode: "EUR",
                        domain: "pm",
                        iddCode: "508")
                },
                {
                                "VC",
                    new Country(
                        isoNumeric: 670,
                        iso2: "VC",
                        iso3: "VCT",
                        englishName: "Saint Vincent and the Grenadines",
                        nativeName: null,
                        nationalityName: "Saint Vincentian",
                        capital: "Kingstown",
                        continent: "North America",
                        currencyCode: "XCD",
                        domain: "vc",
                        iddCode: "1784")
                },
                {
                                "SM",
                    new Country(
                        isoNumeric: 674,
                        iso2: "SM",
                        iso3: "SMR",
                        englishName: "San Marino",
                        nativeName: null,
                        nationalityName: "Sammarinese",
                        capital: "San Marino",
                        continent: "Europe",
                        currencyCode: "EUR",
                        domain: "sm",
                        iddCode: "378")
                },
                {
                                "ST",
                    new Country(
                        isoNumeric: 678,
                        iso2: "ST",
                        iso3: "STP",
                        englishName: "Sao Tome and Principe",
                        nativeName: null,
                        nationalityName: "Sao Tomean",
                        capital: "Sao Tome",
                        continent: "Africa",
                        currencyCode: "STD",
                        domain: "st",
                        iddCode: "239")
                },
                {
                                "SA",
                    new Country(
                        isoNumeric: 682,
                        iso2: "SA",
                        iso3: "SAU",
                        englishName: "Saudi Arabia",
                        nativeName: "المملكة العربية السعودية",
                        nationalityName: "Saudi Arabian",
                        capital: "Riyadh",
                        continent: "Asia",
                        currencyCode: "SAR",
                        domain: "sa",
                        iddCode: "966")
                },
                {
                                "SN",
                    new Country(
                        isoNumeric: 686,
                        iso2: "SN",
                        iso3: "SEN",
                        englishName: "Senegal",
                        nativeName: "Sénégal",
                        nationalityName: "Senegalese",
                        capital: "Dakar",
                        continent: "Africa",
                        currencyCode: "XOF",
                        domain: "sn",
                        iddCode: "221")
                },
                {
                                "RS",
                    new Country(
                        isoNumeric: 688,
                        iso2: "RS",
                        iso3: "SRB",
                        englishName: "Serbia",
                        nativeName: "Србија",
                        nationalityName: "Serbian",
                        capital: "Belgrade",
                        continent: "Europe",
                        currencyCode: "RSD",
                        domain: "rs",
                        iddCode: "381")
                },
                {
                                "SC",
                    new Country(
                        isoNumeric: 690,
                        iso2: "SC",
                        iso3: "SYC",
                        englishName: "Seychelles",
                        nativeName: null,
                        nationalityName: "Seychellois",
                        capital: "Victoria",
                        continent: "Africa",
                        currencyCode: "SCR",
                        domain: "sc",
                        iddCode: "248")
                },
                {
                                "SL",
                    new Country(
                        isoNumeric: 694,
                        iso2: "SL",
                        iso3: "SLE",
                        englishName: "Sierra Leone",
                        nativeName: null,
                        nationalityName: "Sierra Leonean",
                        capital: "Freetown",
                        continent: "Africa",
                        currencyCode: "SLL",
                        domain: "sl",
                        iddCode: "232")
                },
                {
                                "SG",
                    new Country(
                        isoNumeric: 702,
                        iso2: "SG",
                        iso3: "SGP",
                        englishName: "Singapore",
                        nativeName: "Singapore",
                        nationalityName: "Singaporean",
                        capital: "Singapore",
                        continent: "Asia",
                        currencyCode: "SGD",
                        domain: "sg",
                        iddCode: "65")
                },
                {
                                "SK",
                    new Country(
                        isoNumeric: 703,
                        iso2: "SK",
                        iso3: "SVK",
                        englishName: "Slovakia",
                        nativeName: "Slovensko",
                        nationalityName: "Slovak",
                        capital: "Bratislava",
                        continent: "Europe",
                        currencyCode: "EUR",
                        domain: "sk",
                        iddCode: "421")
                },
                {
                                "VN",
                    new Country(
                        isoNumeric: 704,
                        iso2: "VN",
                        iso3: "VNM",
                        englishName: "Vietnam",
                        nativeName: "Việt Nam",
                        nationalityName: "Vietnamese",
                        capital: "Hanoi",
                        continent: "Asia",
                        currencyCode: "VND",
                        domain: "vn",
                        iddCode: "84")
                },
                {
                                "SI",
                    new Country(
                        isoNumeric: 705,
                        iso2: "SI",
                        iso3: "SVN",
                        englishName: "Slovenia",
                        nativeName: "Slovenija",
                        nationalityName: "Slovenian",
                        capital: "Ljubljana",
                        continent: "Europe",
                        currencyCode: "EUR",
                        domain: "si",
                        iddCode: "386")
                },
                {
                                "SO",
                    new Country(
                        isoNumeric: 706,
                        iso2: "SO",
                        iso3: "SOM",
                        englishName: "Somalia",
                        nativeName: "Soomaaliya",
                        nationalityName: "Somali",
                        capital: "Mogadishu",
                        continent: "Africa",
                        currencyCode: "SOS",
                        domain: "so",
                        iddCode: "252")
                },
                {
                                "ZA",
                    new Country(
                        isoNumeric: 710,
                        iso2: "ZA",
                        iso3: "ZAF",
                        englishName: "South Africa",
                        nativeName: "Suid-Afrika",
                        nationalityName: "South African",
                        capital: "Pretoria",
                        continent: "Africa",
                        currencyCode: "ZAR",
                        domain: "za",
                        iddCode: "27")
                },
                {
                                "ZW",
                    new Country(
                        isoNumeric: 716,
                        iso2: "ZW",
                        iso3: "ZWE",
                        englishName: "Zimbabwe",
                        nativeName: "Zimbabwe",
                        nationalityName: "Zimbabwean",
                        capital: "Harare",
                        continent: "Africa",
                        currencyCode: "ZWD",
                        domain: "zw",
                        iddCode: "263")
                },
                {
                                "ES",
                    new Country(
                        isoNumeric: 724,
                        iso2: "ES",
                        iso3: "ESP",
                        englishName: "Spain",
                        nativeName: "Espanya",
                        nationalityName: "Spanish",
                        capital: "Madrid",
                        continent: "Europe",
                        currencyCode: "EUR",
                        domain: "es",
                        iddCode: "34")
                },
                {
                                "SS",
                    new Country(
                        isoNumeric: 728,
                        iso2: "SS",
                        iso3: "SSD",
                        englishName: "South Sudan",
                        nativeName: null,
                        nationalityName: "South Sudanese",
                        capital: "Juba",
                        continent: "Africa",
                        currencyCode: null,
                        domain: "ss",
                        iddCode: "211")
                },
                {
                                "SD",
                    new Country(
                        isoNumeric: 729,
                        iso2: "SD",
                        iso3: "SDN",
                        englishName: "Sudan",
                        nativeName: null,
                        nationalityName: "Sudanese",
                        capital: "Khartoum",
                        continent: "Africa",
                        currencyCode: "SDG",
                        domain: "sd",
                        iddCode: "249")
                },
                {
                                "EH",
                    new Country(
                        isoNumeric: 732,
                        iso2: "EH",
                        iso3: "ESH",
                        englishName: "Western Sahara",
                        nativeName: null,
                        nationalityName: "Sahrawi",
                        capital: "El-Aaiun",
                        continent: "Africa",
                        currencyCode: "MAD",
                        domain: "eh",
                        iddCode: "212")
                },
                {
                                "SR",
                    new Country(
                        isoNumeric: 740,
                        iso2: "SR",
                        iso3: "SUR",
                        englishName: "Suriname",
                        nativeName: null,
                        nationalityName: "Surinamer",
                        capital: "Paramaribo",
                        continent: "South America",
                        currencyCode: "SRD",
                        domain: "sr",
                        iddCode: "597")
                },
                {
                                "SJ",
                    new Country(
                        isoNumeric: 744,
                        iso2: "SJ",
                        iso3: "SJM",
                        englishName: "Svalbard and Jan Mayen",
                        nativeName: null,
                        nationalityName: null,
                        capital: "Longyearbyen",
                        continent: "Europe",
                        currencyCode: "NOK",
                        domain: "sj",
                        iddCode: "4779")
                },
                {
                                "SZ",
                    new Country(
                        isoNumeric: 748,
                        iso2: "SZ",
                        iso3: "SWZ",
                        englishName: "Swaziland",
                        nativeName: null,
                        nationalityName: "Swazi",
                        capital: "Mbabane",
                        continent: "Africa",
                        currencyCode: "SZL",
                        domain: "sz",
                        iddCode: "268")
                },
                {
                                "SE",
                    new Country(
                        isoNumeric: 752,
                        iso2: "SE",
                        iso3: "SWE",
                        englishName: "Sweden",
                        nativeName: "Ruoŧŧa",
                        nationalityName: "Swedish",
                        capital: "Stockholm",
                        continent: "Europe",
                        currencyCode: "SEK",
                        domain: "se",
                        iddCode: "46")
                },
                {
                                "CH",
                    new Country(
                        isoNumeric: 756,
                        iso2: "CH",
                        iso3: "CHE",
                        englishName: "Switzerland",
                        nativeName: "Schweiz",
                        nationalityName: "Swiss",
                        capital: "Berne",
                        continent: "Europe",
                        currencyCode: "CHF",
                        domain: "ch",
                        iddCode: "41")
                },
                {
                                "SY",
                    new Country(
                        isoNumeric: 760,
                        iso2: "SY",
                        iso3: "SYR",
                        englishName: "Syria",
                        nativeName: "سوريا",
                        nationalityName: "Syrian",
                        capital: "Damascus",
                        continent: "Asia",
                        currencyCode: "SYP",
                        domain: "sy",
                        iddCode: "963")
                },
                {
                                "TJ",
                    new Country(
                        isoNumeric: 762,
                        iso2: "TJ",
                        iso3: "TJK",
                        englishName: "Tajikistan",
                        nativeName: "Тоҷикистон",
                        nationalityName: "Tadzhik",
                        capital: "Dushanbe",
                        continent: "Asia",
                        currencyCode: "TJS",
                        domain: "tj",
                        iddCode: "992")
                },
                {
                                "TH",
                    new Country(
                        isoNumeric: 764,
                        iso2: "TH",
                        iso3: "THA",
                        englishName: "Thailand",
                        nativeName: "ไทย",
                        nationalityName: "Thai",
                        capital: "Bangkok",
                        continent: "Asia",
                        currencyCode: "THB",
                        domain: "th",
                        iddCode: "66")
                },
                {
                                "TG",
                    new Country(
                        isoNumeric: 768,
                        iso2: "TG",
                        iso3: "TGO",
                        englishName: "Togo",
                        nativeName: null,
                        nationalityName: "Togolese",
                        capital: "Lome",
                        continent: "Africa",
                        currencyCode: "XOF",
                        domain: "tg",
                        iddCode: "228")
                },
                {
                                "TK",
                    new Country(
                        isoNumeric: 772,
                        iso2: "TK",
                        iso3: "TKL",
                        englishName: "Tokelau",
                        nativeName: null,
                        nationalityName: "Tokelauan",
                        capital: null,
                        continent: "Oceania",
                        currencyCode: "NZD",
                        domain: "tk",
                        iddCode: "690")
                },
                {
                                "TO",
                    new Country(
                        isoNumeric: 776,
                        iso2: "TO",
                        iso3: "TON",
                        englishName: "Tonga",
                        nativeName: null,
                        nationalityName: "Tongan",
                        capital: "Nuku'alofa",
                        continent: "Oceania",
                        currencyCode: "TOP",
                        domain: "to",
                        iddCode: "676")
                },
                {
                                "TT",
                    new Country(
                        isoNumeric: 780,
                        iso2: "TT",
                        iso3: "TTO",
                        englishName: "Trinidad and Tobago",
                        nativeName: "Trinidad and Tobago",
                        nationalityName: "Trinidadian",
                        capital: "Port of Spain",
                        continent: "North America",
                        currencyCode: "TTD",
                        domain: "tt",
                        iddCode: "1868")
                },
                {
                                "AE",
                    new Country(
                        isoNumeric: 784,
                        iso2: "AE",
                        iso3: "ARE",
                        englishName: "United Arab Emirates",
                        nativeName: "الإمارات العربية المتحدة",
                        nationalityName: "Emirati",
                        capital: "Abu Dhabi",
                        continent: "Asia",
                        currencyCode: "AED",
                        domain: "ae",
                        iddCode: "971")
                },
                {
                                "TN",
                    new Country(
                        isoNumeric: 788,
                        iso2: "TN",
                        iso3: "TUN",
                        englishName: "Tunisia",
                        nativeName: "تونس",
                        nationalityName: "Tunisian",
                        capital: "Tunis",
                        continent: "Africa",
                        currencyCode: "TND",
                        domain: "tn",
                        iddCode: "216")
                },
                {
                                "TR",
                    new Country(
                        isoNumeric: 792,
                        iso2: "TR",
                        iso3: "TUR",
                        englishName: "Turkey",
                        nativeName: "Türkiye",
                        nationalityName: "Turkish",
                        capital: "Ankara",
                        continent: "Asia",
                        currencyCode: "TRY",
                        domain: "tr",
                        iddCode: "90")
                },
                {
                                "TM",
                    new Country(
                        isoNumeric: 795,
                        iso2: "TM",
                        iso3: "TKM",
                        englishName: "Turkmenistan",
                        nativeName: "Türkmenistan",
                        nationalityName: "Turkmen",
                        capital: "Ashgabat",
                        continent: "Asia",
                        currencyCode: "TMT",
                        domain: "tm",
                        iddCode: "993")
                },
                {
                                "TC",
                    new Country(
                        isoNumeric: 796,
                        iso2: "TC",
                        iso3: "TCA",
                        englishName: "Turks and Caicos Islands",
                        nativeName: null,
                        nationalityName: "Turks and Caicos Islander",
                        capital: "Cockburn Town",
                        continent: "North America",
                        currencyCode: "USD",
                        domain: "tc",
                        iddCode: "1649")
                },
                {
                                "TV",
                    new Country(
                        isoNumeric: 798,
                        iso2: "TV",
                        iso3: "TUV",
                        englishName: "Tuvalu",
                        nativeName: null,
                        nationalityName: "Tuvaluan",
                        capital: "Funafuti",
                        continent: "Oceania",
                        currencyCode: "AUD",
                        domain: "tv",
                        iddCode: "688")
                },
                {
                                "UG",
                    new Country(
                        isoNumeric: 800,
                        iso2: "UG",
                        iso3: "UGA",
                        englishName: "Uganda",
                        nativeName: null,
                        nationalityName: "Ugandan",
                        capital: "Kampala",
                        continent: "Africa",
                        currencyCode: "UGX",
                        domain: "ug",
                        iddCode: "256")
                },
                {
                                "UA",
                    new Country(
                        isoNumeric: 804,
                        iso2: "UA",
                        iso3: "UKR",
                        englishName: "Ukraine",
                        nativeName: "Україна",
                        nationalityName: "Ukrainian",
                        capital: "Kiev",
                        continent: "Europe",
                        currencyCode: "UAH",
                        domain: "ua",
                        iddCode: "380")
                },
                {
                                "MK",
                    new Country(
                        isoNumeric: 807,
                        iso2: "MK",
                        iso3: "MKD",
                        englishName: "Macedonia",
                        nativeName: "Република Македонија",
                        nationalityName: "Macedonian",
                        capital: "Skopje",
                        continent: "Europe",
                        currencyCode: "MKD",
                        domain: "mk",
                        iddCode: "389")
                },
                {
                                "EG",
                    new Country(
                        isoNumeric: 818,
                        iso2: "EG",
                        iso3: "EGY",
                        englishName: "Egypt",
                        nativeName: "مصر",
                        nationalityName: "Egyptian",
                        capital: "Cairo",
                        continent: "Africa",
                        currencyCode: "EGP",
                        domain: "eg",
                        iddCode: "20")
                },
                {
                                "GB",
                    new Country(
                        isoNumeric: 826,
                        iso2: "GB",
                        iso3: "GBR",
                        englishName: "United Kingdom",
                        nativeName: "Y Deyrnas Unedig",
                        nationalityName: "British",
                        capital: "London",
                        continent: "Europe",
                        currencyCode: "GBP",
                        domain: "uk",
                        iddCode: "44")
                },
                {
                                "GG",
                    new Country(
                        isoNumeric: 831,
                        iso2: "GG",
                        iso3: "GGY",
                        englishName: "Guernsey",
                        nativeName: null,
                        nationalityName: "Channel Islander",
                        capital: "St Peter Port",
                        continent: "Europe",
                        currencyCode: "GBP",
                        domain: "gg",
                        iddCode: "44")
                },
                {
                                "JE",
                    new Country(
                        isoNumeric: 832,
                        iso2: "JE",
                        iso3: "JEY",
                        englishName: "Jersey",
                        nativeName: null,
                        nationalityName: "Channel Islander",
                        capital: "Saint Helier",
                        continent: "Europe",
                        currencyCode: "GBP",
                        domain: "je",
                        iddCode: "44")
                },
                {
                                "IM",
                    new Country(
                        isoNumeric: 833,
                        iso2: "IM",
                        iso3: "IMN",
                        englishName: "Isle of Man",
                        nativeName: null,
                        nationalityName: "Manx",
                        capital: "Douglas, Isle of Man",
                        continent: "Europe",
                        currencyCode: "GBP",
                        domain: "im",
                        iddCode: "44")
                },
                {
                                "TZ",
                    new Country(
                        isoNumeric: 834,
                        iso2: "TZ",
                        iso3: "TZA",
                        englishName: "Tanzania",
                        nativeName: null,
                        nationalityName: "Tanzanian",
                        capital: "Dodoma",
                        continent: "Africa",
                        currencyCode: "TZS",
                        domain: "tz",
                        iddCode: "255")
                },
                {
                                "US",
                    new Country(
                        isoNumeric: 840,
                        iso2: "US",
                        iso3: "USA",
                        englishName: "United States",
                        nativeName: "United States",
                        nationalityName: "American",
                        capital: "Washington",
                        continent: "North America",
                        currencyCode: "USD",
                        domain: "us",
                        iddCode: "1")
                },
                {
                                "VI",
                    new Country(
                        isoNumeric: 850,
                        iso2: "VI",
                        iso3: "VIR",
                        englishName: "U.S. Virgin Islands",
                        nativeName: null,
                        nationalityName: "Virgin Islander",
                        capital: "Charlotte Amalie",
                        continent: "North America",
                        currencyCode: "USD",
                        domain: "vi",
                        iddCode: "1340")
                },
                {
                                "BF",
                    new Country(
                        isoNumeric: 854,
                        iso2: "BF",
                        iso3: "BFA",
                        englishName: "Burkina Faso",
                        nativeName: null,
                        nationalityName: "Burkinabe",
                        capital: "Ouagadougou",
                        continent: "Africa",
                        currencyCode: "XOF",
                        domain: "bf",
                        iddCode: "226")
                },
                {
                                "UY",
                    new Country(
                        isoNumeric: 858,
                        iso2: "UY",
                        iso3: "URY",
                        englishName: "Uruguay",
                        nativeName: "Uruguay",
                        nationalityName: "Uruguayan",
                        capital: "Montevideo",
                        continent: "South America",
                        currencyCode: "UYU",
                        domain: "uy",
                        iddCode: "598")
                },
                {
                                "UZ",
                    new Country(
                        isoNumeric: 860,
                        iso2: "UZ",
                        iso3: "UZB",
                        englishName: "Uzbekistan",
                        nativeName: "Ўзбекистон",
                        nationalityName: "Uzbekistani",
                        capital: "Tashkent",
                        continent: "Asia",
                        currencyCode: "UZS",
                        domain: "uz",
                        iddCode: "998")
                },
                {
                    "VE",
                    new Country(
                        isoNumeric: 862,
                        iso2: "VE",
                        iso3: "VEN",
                        englishName: "Venezuela",
                        nativeName: "Venezuela",
                        nationalityName: "Venezuelan",
                        capital: "Caracas",
                        continent: "South America",
                        currencyCode: "VEF",
                        domain: "ve",
                        iddCode: "58")
                },
                {
                    "WF",
                    new Country(
                        isoNumeric: 876,
                        iso2: "WF",
                        iso3: "WLF",
                        englishName: "Wallis and Futuna",
                        nativeName: null,
                        nationalityName: "Wallisian",
                        capital: "Mata Utu",
                        continent: "Oceania",
                        currencyCode: "XPF",
                        domain: "wf",
                        iddCode: "681")
                },
                {
                    "WS",
                    new Country(
                        isoNumeric: 882,
                        iso2: "WS",
                        iso3: "WSM",
                        englishName: "Samoa",
                        nativeName: null,
                        nationalityName: "Samoan",
                        capital: "Apia",
                        continent: "Oceania",
                        currencyCode: "WST",
                        domain: "ws",
                        iddCode: "685")
                },
                {
                                "YE",
                    new Country(
                        isoNumeric: 887,
                        iso2: "YE",
                        iso3: "YEM",
                        englishName: "Yemen",
                        nativeName: "اليمن",
                        nationalityName: "Yemeni",
                        capital: "Sanaa",
                        continent: "Asia",
                        currencyCode: "YER",
                        domain: "ye",
                        iddCode: "967")
                },
                {
                    "ZM",
                    new Country(
                        isoNumeric: 894,
                        iso2: "ZM",
                        iso3: "ZMB",
                        englishName: "Zambia",
                        nativeName: null,
                        nationalityName: "Zambian",
                        capital: "Lusaka",
                        continent: "Africa",
                        currencyCode: "ZMW",
                        domain: "zm",
                        iddCode: "260")
                }
            };

            CultureInfos = CultureInfo
                .GetCultures(CultureTypes.AllCultures & ~CultureTypes.NeutralCultures)
                .Where(w => !string.IsNullOrEmpty(w.Name))
                .Distinct()
                .ToDictionary(
                    k => k.Name,
                    v => CultureInfo.CreateSpecificCulture(v.Name)
                );
        }
        #endregion


        #region HELPERS
        /// <summary>
        /// Method to get ISO numeric by ISO2
        /// </summary>
        /// <param name="iso2">Two-letter code</param>
        /// <returns>ISONumeric</returns>
        public static int GetISONumeric(string iso2)
        {
            if (string.IsNullOrWhiteSpace(iso2))
            {
                return -1;
            }
            return Countries[iso2.ToUpper()].ISONumeric;
        }

        /// <summary>
        /// Method to get ISO3 by ISO2
        /// </summary>
        /// <param name="iso2">Two-letter code</param>
        /// <returns>ISO3</returns>
        public static string GetISO3(string iso2)
        {
            if (string.IsNullOrWhiteSpace(iso2))
            {
                return null;
            }
            return Countries[iso2.ToUpper()].ISO3;
        }

        /// <summary>
        /// Method to get english name by iso2
        /// </summary>
        /// <param name="iso2">Two-letter code</param>
        /// <returns>EnglishName</returns>
        public static string GetEnglishName(string iso2)
        {
            if (string.IsNullOrWhiteSpace(iso2))
            {
                return null;
            }
            return Countries[iso2.ToUpper()].EnglishName;
        }

        /// <summary>
        /// Method to get native name by iso2
        /// </summary>
        /// <param name="iso2">Two-letter code</param>
        /// <returns>NativeName</returns>
        public static string GetNativeName(string iso2)
        {
            if (string.IsNullOrWhiteSpace(iso2))
            {
                return null;
            }
            return Countries[iso2.ToUpper()].NativeName;
        }

        /// <summary>
        /// Method to get nationality name by iso2
        /// </summary>
        /// <param name="iso2">Two-letter code</param>
        /// <returns>NationalityName</returns>
        public static string GetNationalityName(string iso2)
        {
            if (string.IsNullOrWhiteSpace(iso2))
            {
                return null;
            }
            return Countries[iso2.ToUpper()].NationalityName;
        }

        /// <summary>
        /// Method to get IDDCode by iso2
        /// </summary>
        /// <param name="iso2">Two-letter code</param>
        /// <returns>IDDCode</returns>
        public static string GetIDDCode(string iso2)
        {
            if (string.IsNullOrWhiteSpace(iso2))
            {
                return null;
            }
            return Countries[iso2.ToUpper()].IDDCode;
        }

        /// <summary>
        /// Get the culture code
        /// </summary>
        /// <param name="cultureCode">Culture code</param>
        /// <returns>Return the culture info</returns>
        public static CultureInfo GetCultureInfo(string cultureCode)
            => CultureInfos.SingleOrDefault(s => s.Key.Equals(cultureCode, StringComparison.InvariantCultureIgnoreCase)).Value;

        /// <summary>
        /// Method to check if the country code ISO3 exist
        /// </summary>
        /// <param name="iso3">Three-letter code</param>
        /// <returns>Bool if exist or not</returns>
        public static bool IfExistISO3(string iso3)
        {
            if (string.IsNullOrWhiteSpace(iso3))
            {
                return false;
            }

            if (!CountryList.Any(c => c.ISO3.Equals(iso3, StringComparison.InvariantCultureIgnoreCase)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Method to check if the country code iso2 exist
        /// </summary>
        /// <param name="iso2">Two-letter code</param>
        /// <returns>Bool if exist or not</returns>
        public static bool IfExistISO2(string iso2)
        {
            if (string.IsNullOrWhiteSpace(iso2))
            {
                return false;
            }

            if (Countries.ContainsKey(iso2.ToUpper()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
