using System;
using Xunit;
namespace TestProject1.TestSale
{
    public class SaleServiceTest
    {
        [Fact]
        public void SaleServiceClas_SetProperties_ReturnsExpectedResult()
        {
            // Arrange
            var saleServiceClas = new SaleServiceClas();
            int expectedId = 1;
            string expectedCode = "Test Code";
            int expectedPurchaserId = 2;
            int expectedStoreId = 3;

            // Act
            saleServiceClas.Id = expectedId;
            saleServiceClas.Code = expectedCode;
            saleServiceClas.PurchaserId = expectedPurchaserId;
            saleServiceClas.StoreId = expectedStoreId;

            // Assert
            Assert.Equal(expectedId, saleServiceClas.Id);
            Assert.Equal(expectedCode, saleServiceClas.Code);
            Assert.Equal(expectedPurchaserId, saleServiceClas.PurchaserId);
            Assert.Equal(expectedStoreId, saleServiceClas.StoreId);
        }
    }
}