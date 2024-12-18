# PowerUtils.Globalization

![Logo](https://raw.githubusercontent.com/TechNobre/PowerUtils.Globalization/main/assets/logo/logo_128x128.png)

***Utils, helpers and extensions to work with globalization***

![Tests](https://github.com/TechNobre/PowerUtils.Globalization/actions/workflows/tests.yml/badge.svg)
[![Mutation tests](https://img.shields.io/endpoint?style=flat&url=https%3A%2F%2Fbadge-api.stryker-mutator.io%2Fgithub.com%2FTechNobre%2FPowerUtils.Globalization%2Fmain)](https://dashboard.stryker-mutator.io/reports/github.com/TechNobre/PowerUtils.Globalization/main)

[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=TechNobre_PowerUtils.Globalization&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=TechNobre_PowerUtils.Globalization)
[![Coverage](https://sonarcloud.io/api/project_badges/measure?project=TechNobre_PowerUtils.Globalization&metric=coverage)](https://sonarcloud.io/summary/new_code?id=TechNobre_PowerUtils.Globalization)
[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=TechNobre_PowerUtils.Globalization&metric=reliability_rating)](https://sonarcloud.io/summary/new_code?id=TechNobre_PowerUtils.Globalization)
[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=TechNobre_PowerUtils.Globalization&metric=bugs)](https://sonarcloud.io/summary/new_code?id=TechNobre_PowerUtils.Globalization)

[![NuGet](https://img.shields.io/nuget/v/PowerUtils.Globalization.svg)](https://www.nuget.org/packages/PowerUtils.Globalization)
[![Nuget](https://img.shields.io/nuget/dt/PowerUtils.Globalization.svg)](https://www.nuget.org/packages/PowerUtils.Globalization)
[![License: MIT](https://img.shields.io/github/license/TechNobre/PowerUtils.Globalization.svg)](https://github.com/TechNobre/PowerUtils.Globalization/blob/main/LICENSE)


- [Support to ](#support-to-)
- [How to use ](#how-to-use-)
  - [Install NuGet package ](#install-nuget-package-)
  - [Helpers ](#helpers-)
  - [Extensions ](#extensions-)
  - [Structures ](#structures-)
- [Contribution ](#contribution-)



## Support to <a name="support-to"></a>
- .NET 9.0
- .NET 8.0
- .NET 7.0
- .NET 6.0
- .NET 5.0
- .NET 3.1
- .NET Standard 2.1
- .NET Framework 4.6.2 or more



## How to use <a name="how-to-use"></a>

### Install NuGet package <a name="installation"></a>
This package is available through Nuget Packages: https://www.nuget.org/packages/PowerUtils.Globalization

**Nuget**
```bash
Install-Package PowerUtils.Globalization
```

**.NET CLI**
```bash
dotnet add package PowerUtils.Globalization
```



### Helpers <a name="helpers"></a>
  - `UtilsGlobalization`
    - **Properties:**
      - `UtilsGlobalization.Countries`: Dictionary of countries;
      - `UtilsGlobalization.CountryList`: List of countries;
      - `UtilsGlobalization.CultureInfos`: Dictionary of culture informations;
      - `UtilsGlobalization.CultureInfoList`: List of culture informations;
    - **Methods:**
      - `UtilsGlobalization.GetISONumeric(iso2)`: Return ISO numeric;
      - `UtilsGlobalization.GetISO3(iso2)`: Return ISO3;
      - `UtilsGlobalization.GetEnglishName(iso2)`: Return english name;
      - `UtilsGlobalization.GetNativeName(iso2)`: Return native name;
      - `UtilsGlobalization.GetNationalityName(iso2)`: Return nationality name;
      - `UtilsGlobalization.GetIDDCode(iso2)`: Return IDDCode;
      - `UtilsGlobalization.GetCultureInfo(cultureCode)`: Return the culture info;
      - `UtilsGlobalization.IfExistISO3()`: Method to check if the country code ISO3 exist;
      - `UtilsGlobalization.IfExistISO2()`: Method to check if the country code iso2 exist;

  - `UtilsNumber`
    - `UtilsNumber.GetDecimalSeparator(string languageCode)`: Return character for decimal separator;
    - `UtilsNumber.GetDecimalSeparator(CultureInfo cultureInfo)`: Return character for decimal separator;
    - `UtilsNumber.GetDecimalSeparator()`: Return character for decimal separator;
    - `UtilsNumber.GetThousandSeparator(string languageCode)`: Return character for thousand separator;
    - `UtilsNumber.GetThousandSeparator(CultureInfo cultureInfo)`: Return character for thousand separator;
    - `UtilsNumber.GetThousandSeparator()`: Return character for thousand separator;


### Extensions <a name="extensions"></a>
- `DateTimeExtensions`
  - `DateTime.ToTimestamp()`: Convert datetime to timestamp (Unix timestamp is seconds past epoch)
  - `DateTime.ToTimestampMS()`: Convert datetime to timestamp in milliseconds (Unix timestamp is seconds past epoch)
  - `timestamp.FromTimestampToDateTime()`: Convert timestamp (Unix timestamp is seconds past epoch) to datetime

- `NumbersExtensions`
  - `string.ConvertToCulture(languageCode)`: Convert text number to text number culture;
  - `string.ConvertToCulture(cultureInfo)`: Convert text number to text number culture;
  - `string.ConvertToCulture()`: Convert text number to text number culture;
  - `string.ConvertToDoubleCulture(string languageCode)`: Convert text number to double number;
  - `string.ConvertToDoubleCulture(cultureInfo)`: Convert text number to double number;
  - `string.ConvertToDoubleCulture()`: Convert text number to double number;
  - `string.ConvertToDecimalCulture(languageCode)`: Convert text number to decimal number;
  - `string.ConvertToDecimalCulture(cultureInfo)`: Convert text number to decimal number;
  - `string.ConvertToDecimalCulture()`: Convert text number to decimal number;
  - `double.ConvertToCulture(languageCode, decimalDigits = 2)`: Convert double number to text number culture;
  - `double.ConvertToCulture(cultureInfo, decimalDigits = 2)`: Convert double number to text number culture;
  - `double.ConvertToCulture(decimalDigits = 2)`: Convert double number to text number culture;
  - `decimal.ConvertToCulture(languageCode, decimalDigits = 2)`: Convert decimal number to text number culture;
  - `decimal.ConvertToCulture(cultureInfo, decimalDigits = 2)`: Convert decimal number to text number culture;
  - `decimal.ConvertToCulture(decimalDigits = 2)`: Convert decimal number to text number culture;
  - `float.ConvertToCulture(languageCode, decimalDigits = 2)`: Convert float number to text number culture;
  - `float.ConvertToCulture(cultureInfo, decimalDigits = 2)`: Convert float number to text number culture;
  - `float.ConvertToCulture( decimalDigits = 2)`: Convert float number to text number culture;
  - `int.ConvertToCulture(languageCode)`: Convert int number to text number culture;
  - `int.ConvertToCulture(cultureInfo)`: Convert int number to text number culture;
  - `int.ConvertToCulture()`: Convert int number to text number culture;
  - `uint.ConvertToCulture(languageCode)`: Convert uint number to text number culture;
  - `uint.ConvertToCulture(cultureInfo)`: Convert uint number to text number culture;
  - `uint.ConvertToCulture()`: Convert uint number to text number culture;
  - `string.ConvertToShortCulture(string languageCode)`: Convert text number to short number;
  - `string.ConvertToShortCulture(cultureInfo)`: Convert text number to short number;
  - `string.ConvertToShortCulture()`: Convert text number to short number;
  - `string.ConvertToUShortCulture(string languageCode)`: Convert text number to ushort number;
  - `string.ConvertToUShortCulture(cultureInfo)`: Convert text number to ushort number;
  - `string.ConvertToUShortCulture()`: Convert text number to ushort number;
  - `string.ConvertToIntCulture(string languageCode)`: Convert text number to int number;
  - `string.ConvertToIntCulture(cultureInfo)`: Convert text number to int number;
  - `string.ConvertToIntCulture()`: Convert text number to int number;
  - `string.ConvertToUIntCulture(string languageCode)`: Convert text number to uint number;
  - `string.ConvertToUIntCulture(cultureInfo)`: Convert text number to uint number;
  - `string.ConvertToUIntCulture()`: Convert text number to uint number;
  - `string.ConvertToLongCulture(string languageCode)`: Convert text number to long number;
  - `string.ConvertToLongCulture(cultureInfo)`: Convert text number to long number;
  - `string.ConvertToLongCulture()`: Convert text number to long number;
  - `string.ConvertToULongCulture(string languageCode)`: Convert text number to ulong number;
  - `string.ConvertToULongCulture(cultureInfo)`: Convert text number to ulong number;
  - `string.ConvertToULongCulture()`: Convert text number to ulong number;
  - `string.ConvertToFloatCulture(string languageCode)`: Convert text number to float number;
  - `string.ConvertToFloatCulture(cultureInfo)`: Convert text number to float number;
  - `string.ConvertToFloatCulture()`: Convert text number to float number;


### Structures <a name="structures"></a>
```csharp
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
}
```



## Contribution <a name="contribution"></a>

If you have any questions, comments, or suggestions, please open an [issue](https://github.com/TechNobre/PowerUtils.Globalization/issues/new/choose) or create a [pull request](https://github.com/TechNobre/PowerUtils.Globalization/compare)
