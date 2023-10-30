using System;
using Xunit;
namespace TestProject1.TestStoreImage
{
    public class StoreImageServiceClasTests
    {
        [Fact]
        public void StoreImageServiceClas_SetProperties_ReturnsExpectedResult()
        {
            // Arrange
            var storeImageServiceClas = new StoreImageServiceClas();
            int expectedId = 1;
            string expectedEnconded64Image = "Test Enconded64Image";
            int expectedStoreId = 1;

            // Act
            storeImageServiceClas.Id = expectedId;
            storeImageServiceClas.Enconded64Image = expectedEnconded64Image;
            storeImageServiceClas.StoreId = expectedStoreId;

            // Assert
            Assert.Equal(expectedId, storeImageServiceClas.Id);
            Assert.Equal(expectedEnconded64Image, storeImageServiceClas.Enconded64Image);
            Assert.Equal(expectedStoreId, storeImageServiceClas.StoreId);
        }

        [Fact]
        public void StoreImageServiceClas_SetInvalidId_ThrowsException()
        {
            // Arrange
            var storeImageServiceClas = new StoreImageServiceClas();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => storeImageServiceClas.Id = -1);
        }

        [Fact]
        public void StoreImageServiceClas_SetEmptyEnconded64Image_ThrowsException()
        {
            // Arrange
            var storeImageServiceClas = new StoreImageServiceClas();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => storeImageServiceClas.Enconded64Image = string.Empty);
        }

        [Fact]
        public void StoreImageServiceClas_SetInvalidStoreId_ThrowsException()
        {
            // Arrange
            var storeImageServiceClas = new StoreImageServiceClas();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => storeImageServiceClas.StoreId = -1);
        }
    }
}
