using System;
namespace PowerUtils.Globalization.Tests;

public class DateTimeExtensionsTests
{
    [Fact]
    public void ToTimestamp_Datime_Timestamp()
    {
        // Arrange
        var date = new DateTime(2019, 12, 12, 8, 12, 39);


        // Act
        var act = date.ToTimestamp();


        // Assert
        act.Should()
            .Be(1576138359000);
    }

    [Fact]
    public void ToTimestamp_Int_DateTime()
    {
        // Arrange
        var timestamp = 1652622232;
        


        // Act
        var act = timestamp.FromTimestampToDateTime();


        // Assert
        act.Should()
            .Be(new DateTime(2022, 05, 15, 14, 43, 52));
    }

    [Fact]
    public void ToTimestamp_UInt_DateTime()
    {
        // Arrange
        var timestamp = 1652622232u;



        // Act
        var act = timestamp.FromTimestampToDateTime();


        // Assert
        act.Should()
            .Be(new DateTime(2022, 05, 15, 14, 43, 52));
    }

    [Fact]
    public void ToTimestamp_Long_DateTime()
    {
        // Arrange
        var timestamp = 1652622232L;



        // Act
        var act = timestamp.FromTimestampToDateTime();


        // Assert
        act.Should()
            .Be(new DateTime(2022, 05, 15, 14, 43, 52));
    }

    [Fact]
    public void ToTimestamp_ULong_DateTime()
    {
        // Arrange
        var timestamp = 1652622232uL;



        // Act
        var act = timestamp.FromTimestampToDateTime();


        // Assert
        act.Should()
            .Be(new DateTime(2022, 05, 15, 14, 43, 52));
    }
}
