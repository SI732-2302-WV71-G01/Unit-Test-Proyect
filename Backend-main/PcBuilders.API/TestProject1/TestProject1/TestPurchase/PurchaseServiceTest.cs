using System;
using Xunit;
namespace TestProject1.TestPurchase
{
    public class PurchaseServiceTest
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
    }
}