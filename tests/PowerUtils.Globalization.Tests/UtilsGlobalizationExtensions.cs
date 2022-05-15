using System.Linq;

namespace PowerUtils.Globalization.Tests;

public class UtilsGlobalizationExtensions
{
    [Fact]
    public void Countries_PT_Country()
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
    public void CountryList_ES_Country()
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
    public void CultureInfos_ptPT_CultureInfo()
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
    public void CultureInfoList_enGB_CultureInfo()
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
    public void GetISONumeric_EmptyCode_NegativeOne()
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
    public void GetISONumeric_DoesNotExist_NegativeOne()
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
    public void GetISONumeric_Exists_ISONumeric()
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
    public void GetISO3_DoesNotExist_NULL()
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
    public void GetISO3_Exists_ISO3()
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
    public void GetEnglishName_Exists_EnglishName()
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
    public void GetNativeName_DoesNotExist_NULL()
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
    public void GetNativeName_Exists_NativeName()
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
    public void GetNationalityName_DoesNotExist_NULL()
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
    public void GetNationalityName_Exists_NationalityName()
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
    public void GetIDDCode_DoesNotExist_NULL()
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
    public void GetIDDCode_Exists_NationalityName()
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
    public void GetCultureInfo_DoesNotExist_NULL()
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
    public void GetCultureInfo_Exists_CultureInfo()
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
    public void IfExistISO3_EmptyCode_FALSE()
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
    public void IfExistISO3_DoesNotExist_FALSE()
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
    public void IfExistISO3_Exists_TRUE()
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
    public void IfExistISO2_EmptyCode_FALSE()
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
    public void IfExistISO2_DoesNotExist_FALSE()
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
    public void IfExistISO2_Exists_TRUE()
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
