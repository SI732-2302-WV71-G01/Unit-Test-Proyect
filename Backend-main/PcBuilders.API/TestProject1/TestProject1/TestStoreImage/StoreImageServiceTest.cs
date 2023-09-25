using System;
using Xunit;
namespace TestProject1.TestStoreImage
{
    public class StoreImageServiceTest
    {
        [Fact]
        public void StoreImageServiceClas_SetProperties_ReturnsExpectedResult()
        {
            // Arrange
            var storeImageServiceClas = new StoreImageServiceClas();
            int expectedId = 1;
            string expectedEnconded64Image = "Test Enconded64Image";
            int expectedStoreId = 2;

            // Act
            storeImageServiceClas.Id = expectedId;
            storeImageServiceClas.Enconded64Image = expectedEnconded64Image;
            storeImageServiceClas.StoreId = expectedStoreId;

            // Assert
            Assert.Equal(expectedId, storeImageServiceClas.Id);
            Assert.Equal(expectedEnconded64Image, storeImageServiceClas.Enconded64Image);
            Assert.Equal(expectedStoreId, storeImageServiceClas.StoreId);
        }
    }
}