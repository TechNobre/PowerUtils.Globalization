using System;
using FluentAssertions;
using Xunit;

namespace PowerUtils.Globalization.Tests
{
    public class DateTimeExtensionsTests
    {
        [Fact]
        public void DateTime_ToTimestampMS_Timestamp()
        {
            // Arrange
            var dateTime = new DateTime(2019, 12, 12, 8, 12, 39);


            // Act
            var act = dateTime.ToTimestampMS();


            // Assert
            act.Should()
                .Be(1576138359000);
        }

        [Fact]
        public void Datime_ToTimestamp_Timestamp()
        {
            // Arrange
            var dateTime = new DateTime(2019, 12, 12, 8, 12, 39);


            // Act
            var act = dateTime.ToTimestamp();


            // Assert
            act.Should()
                .Be(1576138359);
        }

        [Fact]
        public void Int_ToTimestamp_DateTime()
        {
            // Arrange
            var timestamp = 1652622232;


            // Act
            var act = timestamp.FromTimestampToDateTime();


            // Assert
            act.Should()
                .Be(new DateTime(2022, 05, 15, 13, 43, 52));
        }

        [Fact]
        public void UInt_ToTimestamp_DateTime()
        {
            // Arrange
            var timestamp = 1652622232u;



            // Act
            var act = timestamp.FromTimestampToDateTime();


            // Assert
            act.Should()
                .Be(new DateTime(2022, 05, 15, 13, 43, 52));
        }

        [Fact]
        public void Long_ToTimestamp_DateTime()
        {
            // Arrange
            var timestamp = 1652622232L;



            // Act
            var act = timestamp.FromTimestampToDateTime();


            // Assert
            act.Should()
                .Be(new DateTime(2022, 05, 15, 13, 43, 52));
        }

        [Fact]
        public void ULong_ToTimestamp_DateTime()
        {
            // Arrange
            var timestamp = 1652622232uL;



            // Act
            var act = timestamp.FromTimestampToDateTime();


            // Assert
            act.Should()
                .Be(new DateTime(2022, 05, 15, 13, 43, 52));
        }

        [Fact]
        public void Timestamp_FromTimestampToDateTime_DateTime()
        {
            // Arrange
            var dateTime = new DateTime(2019, 12, 12, 8, 12, 39);
            var timestamp = dateTime.ToTimestamp();


            // Act
            var act = timestamp.FromTimestampToDateTime();


            // Assert
            act.Should()
                .Be(dateTime);
        }

        [Fact]
        public void DateTime_ToTimestamp_Timestamp()
        {
            // Arrange
            var timestamp = 1652622232uL;
            var date = timestamp.FromTimestampToDateTime();


            // Act
            var act = date.ToTimestamp();


            // Assert
            act.Should()
                .Be(timestamp);
        }
    }
}