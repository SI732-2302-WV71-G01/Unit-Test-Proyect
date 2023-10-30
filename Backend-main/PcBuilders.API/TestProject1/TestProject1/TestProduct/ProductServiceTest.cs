using System;
using Xunit;
namespace TestProject1.TestProduct
{
    public class ProductServiceClasTests
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
            int expectedStoreId = 1;

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

        [Fact]
        public void ProductServiceClas_SetInvalidId_ThrowsException()
        {
            // Arrange
            var productServiceClas = new ProductServiceClas();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => productServiceClas.Id = -1);
        }

        [Fact]
        public void ProductServiceClas_SetInvalidRating_ThrowsException()
        {
            // Arrange
            var productServiceClas = new ProductServiceClas();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => productServiceClas.Rating = -1);
        }

        [Fact]
        public void ProductServiceClas_SetEmptyName_ThrowsException()
        {
            // Arrange
            var productServiceClas = new ProductServiceClas();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => productServiceClas.Name = string.Empty);
        }

        [Fact]
        public void ProductServiceClas_SetEmptyImage_ThrowsException()
        {
            // Arrange
            var productServiceClas = new ProductServiceClas();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => productServiceClas.Image = string.Empty);
        }

        [Fact]
        public void ProductServiceClas_SetEmptyCategory_ThrowsException()
        {
            // Arrange
            var productServiceClas = new ProductServiceClas();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => productServiceClas.Category = string.Empty);
        }

        [Fact]
        public void ProductServiceClas_SetInvalidPrice_ThrowsException()
        {
            // Arrange
            var productServiceClas = new ProductServiceClas();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => productServiceClas.Price = -1);
        }

        [Fact]
        public void ProductServiceClas_SetEmptyInventoryStatus_ThrowsException()
        {
            // Arrange
            var productServiceClas = new ProductServiceClas();

           // Act and Assert
           Assert.Throws<ArgumentException>(() => productServiceClas.InventoryStatus = string.Empty);
       }

       [Fact]
       public void ProductServiceClas_SetInvalidStoreId_ThrowsException()
       {
           // Arrange
           var productServiceClas = new ProductServiceClas();

           // Act and Assert
           Assert.Throws<ArgumentException>(() => productServiceClas.StoreId = -1);
       }
   }
}
