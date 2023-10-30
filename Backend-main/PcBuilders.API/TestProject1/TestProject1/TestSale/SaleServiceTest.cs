using System;
using Xunit;
namespace TestProject1.TestSale
{
    public class SaleServiceClasTests
    {
        [Fact]
        public void SaleServiceClas_SetProperties_ReturnsExpectedResult()
        {
            // Arrange
            var saleServiceClas = new SaleServiceClas();
            int expectedId = 1;
            string expectedCode = "Test Code";
            int expectedPurchaserId = 2;
            int expectedStoreId = 1;

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

        [Fact]
        public void SaleServiceClas_SetInvalidId_ThrowsException()
        {
            // Arrange
            var saleServiceClas = new SaleServiceClas();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => saleServiceClas.Id = -1);
        }

        [Fact]
        public void SaleServiceClas_SetEmptyCode_ThrowsException()
        {
            // Arrange
            var saleServiceClas = new SaleServiceClas();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => saleServiceClas.Code = string.Empty);
        }

        [Fact]
        public void SaleServiceClas_SetInvalidPurchaserId_ThrowsException()
        {
            // Arrange
            var saleServiceClas = new SaleServiceClas();

           // Act and Assert
           Assert.Throws<ArgumentException>(() => saleServiceClas.PurchaserId = -1);
       }

       [Fact]
       public void SaleServiceClas_SetInvalidStoreId_ThrowsException()
       {
           // Arrange
           var saleServiceClas = new SaleServiceClas();

           // Act and Assert
           Assert.Throws<ArgumentException>(() => saleServiceClas.StoreId = -1);
       }
   }
}
