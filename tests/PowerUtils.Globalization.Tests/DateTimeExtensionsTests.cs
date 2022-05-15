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
}
