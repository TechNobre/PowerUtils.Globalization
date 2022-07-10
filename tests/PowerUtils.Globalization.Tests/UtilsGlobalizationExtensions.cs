using System.Linq;

namespace PowerUtils.Globalization.Tests;

public class UtilsGlobalizationExtensions
{
    [Fact]
    public void PT_Countries_Country()
    {
        // Arrange
        var code = "PT";


        // Act
        var act = UtilsGlobalization.Countries[code];


        // Assert
        act.ISONumeric.Should()
            .Be(620);
        act.ISO2.Should()
            .Be("PT");
        act.ISO3.Should()
            .Be("PRT");
        act.EnglishName.Should()
            .Be("Portugal");
        act.NativeName.Should()
            .Be("Portugal");
        act.NationalityName.Should()
            .Be("Portuguese");
        act.Capital.Should()
            .Be("Lisbon");
        act.Continent.Should()
            .Be("Europe");
        act.CurrencyCode.Should()
            .Be("EUR");
        act.Domain.Should()
            .Be("pt");
        act.IDDCode.Should()
            .Be("351");
    }


    [Fact]
    public void ESIsoNumeric_CountryList_Country()
    {
        // Arrange
        var isoNumeric = 724;


        // Act
        var act = UtilsGlobalization.CountryList.Single(s => s.ISONumeric == isoNumeric);


        // Assert
        act.ISONumeric.Should()
            .Be(724);
        act.ISO2.Should()
            .Be("ES");
        act.ISO3.Should()
            .Be("ESP");
        act.EnglishName.Should()
            .Be("Spain");
        act.NativeName.Should()
            .Be("Espanya");
        act.NationalityName.Should()
            .Be("Spanish");
        act.Capital.Should()
            .Be("Madrid");
        act.Continent.Should()
            .Be("Europe");
        act.CurrencyCode.Should()
            .Be("EUR");
        act.Domain.Should()
            .Be("es");
        act.IDDCode.Should()
            .Be("34");
    }


    [Fact]
    public void CulturePtPT_CultureInfos_CultureInfo()
    {
        // Arrange
        var code = "pt-PT";


        // Act
        var act = UtilsGlobalization.CultureInfos[code];


        // Assert
        act.Should()
            .NotBeNull();
    }


    [Fact]
    public void CultureEnGB_CultureInfoList_CultureInfo()
    {
        // Arrange
        var code = "en-GB";


        // Act
        var act = UtilsGlobalization.CultureInfoList.Single(s => s.Name == code);


        // Assert
        act.Should()
            .NotBeNull();
    }

    [Fact]
    public void InvalidIso2_GetISONumeric_NegativeOne()
    {
        // Arrange
        var code = "rr";


        // Act
        var act = UtilsGlobalization.GetISONumeric(code);


        // Assert
        act.Should()
            .Be(-1);
    }

    [Fact]
    public void Iso2PT_GetISONumeric_ISONumeric620()
    {
        // Arrange
        var code = "pt";


        // Act
        var act = UtilsGlobalization.GetISONumeric(code);


        // Assert
        act.Should()
            .Be(620);
    }

    [Fact]
    public void InvalidIso2_GetISO3_NULL()
    {
        // Arrange
        var code = "rr";


        // Act
        var act = UtilsGlobalization.GetISO3(code);


        // Assert
        act.Should()
            .BeNull();
    }

    [Fact]
    public void Iso2PT_GetISO3_ISO3()
    {
        // Arrange
        var code = "pT";


        // Act
        var act = UtilsGlobalization.GetISO3(code);


        // Assert
        act.Should()
            .Be("PRT");
    }

    [Fact]
    public void GetEnglishName_DoesNotExist_NULL()
    {
        // Arrange
        var code = "rr";


        // Act
        var act = UtilsGlobalization.GetEnglishName(code);


        // Assert
        act.Should()
            .BeNull();
    }

    [Fact]
    public void Iso2PT_GetEnglishName_EnglishName()
    {
        // Arrange
        var code = "pT";


        // Act
        var act = UtilsGlobalization.GetEnglishName(code);


        // Assert
        act.Should()
            .Be("Portugal");
    }

    [Fact]
    public void InvalidIso2_GetNativeName_NULL()
    {
        // Arrange
        var code = "rr";


        // Act
        var act = UtilsGlobalization.GetNativeName(code);


        // Assert
        act.Should()
            .BeNull();
    }

    [Fact]
    public void Iso2ES_GetNativeName_NativeName()
    {
        // Arrange
        var code = "eS";


        // Act
        var act = UtilsGlobalization.GetNativeName(code);


        // Assert
        act.Should()
            .Be("Espanya");
    }

    [Fact]
    public void InvalidIso2_GetNationalityName_NULL()
    {
        // Arrange
        var code = "rr";


        // Act
        var act = UtilsGlobalization.GetNationalityName(code);


        // Assert
        act.Should()
            .BeNull();
    }

    [Fact]
    public void Iso2ES_GetNationalityName_NationalityName()
    {
        // Arrange
        var code = "eS";


        // Act
        var act = UtilsGlobalization.GetNationalityName(code);


        // Assert
        act.Should()
            .Be("Spanish");
    }

    [Fact]
    public void InvalidIso2_GetIDDCode_NULL()
    {
        // Arrange
        var code = "rr";


        // Act
        var act = UtilsGlobalization.GetIDDCode(code);


        // Assert
        act.Should()
            .BeNull();
    }

    [Fact]
    public void Iso2ES_GetIDDCode_NationalityName()
    {
        // Arrange
        var code = "eS";


        // Act
        var act = UtilsGlobalization.GetIDDCode(code);


        // Assert
        act.Should()
            .Be("34");
    }

    [Fact]
    public void InvalidCultureCode_GetCultureInfo_NULL()
    {
        // Arrange
        var cultureCode = "rr-rr";


        // Act
        var act = UtilsGlobalization.GetCultureInfo(cultureCode);


        // Assert
        act.Should()
            .BeNull();
    }

    [Fact]
    public void CultureCodeES_GetCultureInfo_CultureCode()
    {
        // Arrange
        var cultureCode = "es-es";


        // Act
        var act = UtilsGlobalization.GetCultureInfo(cultureCode);


        // Assert
        act.Should()
            .NotBeNull();
    }

    [Fact]
    public void EmptryString_IfExistISO3_False()
    {
        // Arrange
        var code = "";


        // Act
        var act = UtilsGlobalization.IfExistISO3(code);


        // Assert
        act.Should()
            .BeFalse();
    }


    [Fact]
    public void InvalidIso3_IfExistISO3_False()
    {
        // Arrange
        var code = "rr-rr";


        // Act
        var act = UtilsGlobalization.IfExistISO3(code);


        // Assert
        act.Should()
            .BeFalse();
    }

    [Fact]
    public void Iso3ESO_IfExistISO3_True()
    {
        // Arrange
        var code = "esp";


        // Act
        var act = UtilsGlobalization.IfExistISO3(code);


        // Assert
        act.Should()
            .BeTrue();
    }

    [Fact]
    public void EmptyString_IfExistISO2_False()
    {
        // Arrange
        var code = "";


        // Act
        var act = UtilsGlobalization.IfExistISO2(code);


        // Assert
        act.Should()
            .BeFalse();
    }


    [Fact]
    public void InvalidIso2_IfExistISO2_False()
    {
        // Arrange
        var code = "rr-rr";


        // Act
        var act = UtilsGlobalization.IfExistISO2(code);


        // Assert
        act.Should()
            .BeFalse();
    }

    [Fact]
    public void Iso2ES_IfExistISO2_True()
    {
        // Arrange
        var code = "es";


        // Act
        var act = UtilsGlobalization.IfExistISO2(code);


        // Assert
        act.Should()
            .BeTrue();
    }
}
