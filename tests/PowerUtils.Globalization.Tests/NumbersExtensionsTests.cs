namespace PowerUtils.Globalization.Tests;

public class NumbersExtensionsTests
{
    [Fact]
    public void ConvertToCulture_PTLanguage_FormattedNumber()
    {
        // Arrange
        var number = "1011,23";


        // Act
        var act = number.ConvertToCulture("pt-PT");


        // Assert
        act.Should()
            .StartWith("1" + UtilsNumber.GetThousandSeparator("pt-PT") + "011" + UtilsNumber.GetDecimalSeparator("pt-PT") + "23");
    }

    [Fact]
    public void ConvertToCulture_DefaultCulture_FormattedNumber()
    {
        // Arrange
        var number = "5442121,50";


        // Act
        var act = number.ConvertToCulture();


        // Assert
        act.Should()
            .Be("5" + UtilsNumber.GetThousandSeparator() + "442" + UtilsNumber.GetThousandSeparator() + "121" + UtilsNumber.GetDecimalSeparator() + "50");
    }

    [Fact]
    public void ConvertToCulture_DoubleCulture_FormattedNumber()
    {
        // Arrange
        var language = "en-GB";
        var number = 2121.455d;


        // Act
        var act = number.ConvertToCulture(language);


        // Assert
        act.Should()
            .Be("2" + UtilsNumber.GetThousandSeparator(language) + "121" + UtilsNumber.GetDecimalSeparator(language) + "46");
    }

    [Fact]
    public void ConvertToCulture_DoubleDefault_FormattedNumber()
    {
        // Arrange
        var number = 2121.4551d;


        // Act
        var act = number.ConvertToCulture(3);


        // Assert
        act.Should()
            .Be("2" + UtilsNumber.GetThousandSeparator() + "121" + UtilsNumber.GetDecimalSeparator() + "455");
    }

    [Fact]
    public void ConvertToCulture_DecimalCulture_FormattedNumber()
    {
        // Arrange
        var language = "es-ES";
        var number = 2121.455M;


        // Act
        var act = number.ConvertToCulture(language);


        // Assert
        act.Should()
            .Be("2" + UtilsNumber.GetThousandSeparator(language) + "121" + UtilsNumber.GetDecimalSeparator(language) + "46");
    }

    [Fact]
    public void ConvertToCulture_DecimalDefault_FormattedNumber()
    {
        // Arrange
        var number = 2121.4551M;


        // Act
        var act = number.ConvertToCulture(1);


        // Assert
        act.Should()
            .Be("2" + UtilsNumber.GetThousandSeparator() + "121" + UtilsNumber.GetDecimalSeparator() + "5");
    }

    [Fact]
    public void ConvertToCulture_FloatCulture_FormattedNumber()
    {
        // Arrange
        var language = "es-ES";
        var number = 2121.455f;


        // Act
        var act = number.ConvertToCulture(language);


        // Assert
        act.Should()
            .Be("2" + UtilsNumber.GetThousandSeparator(language) + "121" + UtilsNumber.GetDecimalSeparator(language) + "46");
    }

    [Fact]
    public void ConvertToCulture_FloatDefault_FormattedNumber()
    {
        // Arrange
        var number = 2121.4551f;


        // Act
        var act = number.ConvertToCulture(1);


        // Assert
        act.Should()
            .Be("2" + UtilsNumber.GetThousandSeparator() + "121" + UtilsNumber.GetDecimalSeparator() + "5");
    }

    [Fact]
    public void ConvertToCulture_IntCulture_FormattedNumber()
    {
        // Arrange
        var language = "fr-FR";
        var number = 1234;


        // Act
        var act = number.ConvertToCulture(language);


        // Assert
        act.Should()
            .Be("1" + UtilsNumber.GetThousandSeparator(language) + "234");
    }

    [Fact]
    public void ConvertToCulture_IntDefault_FormattedNumber()
    {
        // Arrange
        var number = 987654321;


        // Act
        var act = number.ConvertToCulture();


        // Assert
        act.Should()
            .Be("987" + UtilsNumber.GetThousandSeparator() + "654" + UtilsNumber.GetThousandSeparator() + "321");
    }

    [Fact]
    public void ConvertToCulture_UIntCulture_FormattedNumber()
    {
        // Arrange
        var language = "en-US";
        var number = 1234u;


        // Act
        var act = number.ConvertToCulture(language);


        // Assert
        act.Should()
            .Be("1" + UtilsNumber.GetThousandSeparator(language) + "234");
    }

    [Fact]
    public void ConvertToCulture_UIntDefault_FormattedNumber()
    {
        // Arrange
        var number = 987654321U;


        // Act
        var act = number.ConvertToCulture();


        // Assert
        act.Should()
            .Be("987" + UtilsNumber.GetThousandSeparator() + "654" + UtilsNumber.GetThousandSeparator() + "321");
    }

    [Fact]
    public void ConvertToShortCulture_Culture_FormattedNumber()
    {
        // Arrange
        var language = "pt-PT";
        var number = "1 234";


        // Act
        var act = number.ConvertToShortCulture(language);


        // Assert
        act.Should()
            .Be(1234);
    }

    [Fact]
    public void ConvertToShortCulture_Default_FormattedNumber()
    {
        // Arrange
        var number = "921";


        // Act
        var act = number.ConvertToShortCulture();


        // Assert
        act.Should()
            .Be(921);
    }

    [Fact]
    public void ConvertToUShortCulture_Culture_FormattedNumber()
    {
        // Arrange
        var language = "pt-PT";
        var number = "1 234";


        // Act
        var act = number.ConvertToUShortCulture(language);


        // Assert
        act.Should()
            .Be(1234);
    }

    [Fact]
    public void ConvertToUShortCulture_Default_FormattedNumber()
    {
        // Arrange
        var number = "921";


        // Act
        var act = number.ConvertToUShortCulture();


        // Assert
        act.Should()
            .Be(921);
    }

    [Fact]
    public void ConvertToIntCulture_Culture_FormattedNumber()
    {
        // Arrange
        var language = "pt-PT";
        var number = "1 234";


        // Act
        var act = number.ConvertToIntCulture(language);


        // Assert
        act.Should()
            .Be(1234);
    }

    [Fact]
    public void ConvertToIntCulture_Default_FormattedNumber()
    {
        // Arrange
        var number = "921";


        // Act
        var act = number.ConvertToIntCulture();


        // Assert
        act.Should()
            .Be(921);
    }

    [Fact]
    public void ConvertToUIntCulture_Culture_FormattedNumber()
    {
        // Arrange
        var language = "pt-PT";
        var number = "1 234";


        // Act
        var act = number.ConvertToUIntCulture(language);


        // Assert
        act.Should()
            .Be(1234);
    }

    [Fact]
    public void ConvertToUIntCulture_Default_FormattedNumber()
    {
        // Arrange
        var number = "921";


        // Act
        var act = number.ConvertToUIntCulture();


        // Assert
        act.Should()
            .Be(921);
    }

    [Fact]
    public void ConvertToLongCulture_Culture_FormattedNumber()
    {
        // Arrange
        var language = "pt-PT";
        var number = "1 234";


        // Act
        var act = number.ConvertToLongCulture(language);


        // Assert
        act.Should()
            .Be(1234);
    }

    [Fact]
    public void ConvertToLongCulture_Default_FormattedNumber()
    {
        // Arrange
        var number = "921";


        // Act
        var act = number.ConvertToLongCulture();


        // Assert
        act.Should()
            .Be(921);
    }

    [Fact]
    public void ConvertToULongCulture_Culture_FormattedNumber()
    {
        // Arrange
        var language = "pt-PT";
        var number = "1 234";


        // Act
        var act = number.ConvertToULongCulture(language);


        // Assert
        act.Should()
            .Be(1234);
    }

    [Fact]
    public void ConvertToULongCulture_Default_FormattedNumber()
    {
        // Arrange
        var number = "921";


        // Act
        var act = number.ConvertToULongCulture();


        // Assert
        act.Should()
            .Be(921);
    }

    [Fact]
    public void ConvertToFloatCulture_Culture_FormattedNumber()
    {
        // Arrange
        var language = "pt-PT";
        var number = "1 234,24";


        // Act
        var act = number.ConvertToFloatCulture(language);


        // Assert
        act.Should()
            .Be(1234.24f);
    }

    [Fact]
    public void ConvertToFloatCulture_Default_FormattedNumber()
    {
        // Arrange
        var number = "92124";


        // Act
        var act = number.ConvertToFloatCulture();


        // Assert
        act.Should()
            .Be(92124f);
    }

    [Fact]
    public void ConvertToDoubleCulture_Culture_FormattedNumber()
    {
        // Arrange
        var language = "pt-PT";
        var number = "1 234,24";


        // Act
        var act = number.ConvertToDoubleCulture(language);


        // Assert
        act.Should()
            .Be(1234.24);
    }

    [Fact]
    public void ConvertToDoubleCulture_Default_FormattedNumber()
    {
        // Arrange
        var number = "92124";


        // Act
        var act = number.ConvertToDoubleCulture();


        // Assert
        act.Should()
            .Be(92124);
    }

    [Fact]
    public void ConvertToDecimalCulture_Culture_FormattedNumber()
    {
        // Arrange
        var language = "pt-PT";
        var number = "1 234,24";


        // Act
        var act = number.ConvertToDecimalCulture(language);


        // Assert
        act.Should()
            .Be(1234.24M);
    }

    [Fact]
    public void ConvertToDecimalCulture_Default_FormattedNumber()
    {
        // Arrange
        var number = "92124";


        // Act
        var act = number.ConvertToDecimalCulture();


        // Assert
        act.Should()
            .Be(92124M);
    }
}
