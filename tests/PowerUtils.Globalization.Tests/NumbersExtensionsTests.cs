using FluentAssertions;
using Xunit;

namespace PowerUtils.Globalization.Tests
{
    public class NumbersExtensionsTests
    {
        [Fact]
        public void StringPTLanguage_ConvertToCulture_FormattedNumber()
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
        public void StringWithCurrentDecimalSeparator_ConvertToCulture_FormattedNumber()
        {
            // Arrange
            var number = "5442121" + UtilsNumber.GetDecimalSeparator() + "50";


            // Act
            var act = number.ConvertToCulture();


            // Assert
            act.Should()
                .Be("5" + UtilsNumber.GetThousandSeparator() + "442" + UtilsNumber.GetThousandSeparator() + "121" + UtilsNumber.GetDecimalSeparator() + "50");
        }

        [Fact]
        public void DoubleWithSpecificLanguage_ConvertToCulture_FormattedNumber()
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
        public void Double_ConvertToCulture_FormattedNumber()
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
        public void DecimalWithSpecificLanguage_ConvertToCulture_FormattedNumber()
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
        public void Decimal_ConvertToCulture_FormattedNumber()
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
        public void FloatWithSpecificLanguage_ConvertToCulture_FormattedNumber()
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
        public void Float_ConvertToCulture_FormattedNumber()
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
        public void IntWithSpecificLanguage_ConvertToCulture_FormattedNumber()
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
        public void Int_ConvertToCulture_FormattedNumber()
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
        public void UIntWithSpecificLanguage_ConvertToCulture_FormattedNumber()
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
        public void UInt_ConvertToCulture_FormattedNumber()
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
        public void StringWithSpecificLanguage_ConvertToShortCulture_Short()
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
        public void String_ConvertToShortCulture_Short()
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
        public void StringWithSpecificLanguage_ConvertToUShortCulture_UShort()
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
        public void String_ConvertToUShortCulture_UShort()
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
        public void StringWithSpecificLanguage_ConvertToIntCulture_Int()
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
        public void String_ConvertToIntCulture_Int()
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
        public void StringWithSpecificLanguage_ConvertToUIntCulture_UInt()
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
        public void String_ConvertToUIntCulture_UInt()
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
        public void StringWithSpecificLanguage_ConvertToLongCulture_Long()
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
        public void String_ConvertToLongCulture_Long()
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
        public void StringWithSpecificLanguage_ConvertToULongCulture_ULong()
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
        public void String_ConvertToULongCulture_ULong()
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
        public void StringWithSpecificLanguage_ConvertToFloatCulture_Float()
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
        public void String_ConvertToFloatCulture_Float()
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
        public void StringWithSpecificLanguage_ConvertToDoubleCulture_Double()
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
        public void String_ConvertToDoubleCulture_Double()
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
        public void StringWithSpecificLanguage_ConvertToDecimalCulture_Decimal()
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
        public void String_ConvertToDecimalCulture_Decimal()
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
}