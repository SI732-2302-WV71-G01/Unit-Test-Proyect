using System;
using Xunit;
namespace TestProject1.TestProduct
{
    public class ProductServiceTest
    {
        [Fact]
        public void ProductServiceClas_SetProperties_ReturnsExpectedResult()
        {
            // Arrange
            var productServiceClas = new ProductServiceClas();
            int expectedId = 1;
            string expectedName = "Test Name";
            int expectedRating = 5;
            string expectedImage = "Test Image";
            string expectedCategory = "Test Category";
            int expectedPrice = 100;
            string expectedInventoryStatus = "In Stock";
            int expectedStoreId = 2;

            // Act
            productServiceClas.Id = expectedId;
            productServiceClas.Name = expectedName;
            productServiceClas.Rating = expectedRating;
            productServiceClas.Image = expectedImage;
            productServiceClas.Category = expectedCategory;
            productServiceClas.Price = expectedPrice;
            productServiceClas.InventoryStatus = expectedInventoryStatus;
            productServiceClas.StoreId = expectedStoreId;

            // Assert
            Assert.Equal(expectedId, productServiceClas.Id);
            Assert.Equal(expectedName, productServiceClas.Name);
            Assert.Equal(expectedRating, productServiceClas.Rating);
            Assert.Equal(expectedImage, productServiceClas.Image);
            Assert.Equal(expectedCategory, productServiceClas.Category);
            Assert.Equal(expectedPrice, productServiceClas.Price);
            Assert.Equal(expectedInventoryStatus, productServiceClas.InventoryStatus);
            Assert.Equal(expectedStoreId, productServiceClas.StoreId);
        }
    }
}