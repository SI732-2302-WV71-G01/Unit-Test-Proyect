using System;
using Xunit;
namespace TestProject1.TestStore
{
    public class StoreServiceTest
    {
        [Fact]
        public void StoreServiceClas_SetProperties_ReturnsExpectedResult()
        {
            // Arrange
            var storeServiceClas = new StoreServiceClas();
            int expectedId = 1;
            int expectedUserId = 2;
            string expectedName = "Test Name";
            string expectedDescription = "Test Description";
            string expectedAddress = "Test Address";
            string expectedEncoded64LogoImage = "Test Encoded64LogoImage";

            // Act
            storeServiceClas.Id = expectedId;
            storeServiceClas.UserId = expectedUserId;
            storeServiceClas.Name = expectedName;
            storeServiceClas.Description = expectedDescription;
            storeServiceClas.Address = expectedAddress;
            storeServiceClas.Encoded64LogoImage = expectedEncoded64LogoImage;

            // Assert
            Assert.Equal(expectedId, storeServiceClas.Id);
            Assert.Equal(expectedUserId, storeServiceClas.UserId);
            Assert.Equal(expectedName, storeServiceClas.Name);
            Assert.Equal(expectedDescription, storeServiceClas.Description);
            Assert.Equal(expectedAddress, storeServiceClas.Address);
            Assert.Equal(expectedEncoded64LogoImage, storeServiceClas.Encoded64LogoImage);
        }
    }
}