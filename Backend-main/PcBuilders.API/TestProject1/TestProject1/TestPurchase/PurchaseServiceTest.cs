using System;
using Xunit;
namespace TestProject1.TestPurchase
{
    public class PurchaseServiceClasTests
    {
        [Fact]
        public void PurchaseServiceClas_SetProperties_ReturnsExpectedResult()
        {
            // Arrange
            var purchaseServiceClas = new PurchaseServiceClas();
            int expectedId = 1;
            string expectedCode = "Test Code";
            int expectedUserId = 2;

            // Act
            purchaseServiceClas.Id = expectedId;
            purchaseServiceClas.Code = expectedCode;
            purchaseServiceClas.UserId = expectedUserId;

            // Assert
            Assert.Equal(expectedId, purchaseServiceClas.Id);
            Assert.Equal(expectedCode, purchaseServiceClas.Code);
            Assert.Equal(expectedUserId, purchaseServiceClas.UserId);
        }

        [Fact]
        public void PurchaseServiceClas_SetInvalidId_ThrowsException()
        {
            // Arrange
            var purchaseServiceClas = new PurchaseServiceClas();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => purchaseServiceClas.Id = -1);
        }

        [Fact]
        public void PurchaseServiceClas_SetEmptyCode_ThrowsException()
        {
            // Arrange
            var purchaseServiceClas = new PurchaseServiceClas();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => purchaseServiceClas.Code = string.Empty);
        }

        [Fact]
        public void PurchaseServiceClas_SetInvalidUserId_ThrowsException()
        {
            // Arrange
            var purchaseServiceClas = new PurchaseServiceClas();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => purchaseServiceClas.UserId = -1);
        }
    }
}
