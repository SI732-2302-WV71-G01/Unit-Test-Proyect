using System;
using Xunit;

namespace TestProject1.TestArticle
{
     public class ArticleServiceClasTests
    {
        [Fact]
        public void ArticleServiceClas_SetProperties_ReturnsExpectedResult()
        {
            // Arrange
            var articleServiceClas = new ArticleServiceClas();
            int expectedId = 1;
            string expectedName = "Test Name";
            string expectedDescription = "Test Description";
            int expectedUserId = 2;
            string expectedUser = "Test User";

            // Act
            articleServiceClas.Id = expectedId;
            articleServiceClas.Name = expectedName;
            articleServiceClas.Description = expectedDescription;
            articleServiceClas.UserId = expectedUserId;
            articleServiceClas.User = expectedUser;

            // Assert
            Assert.Equal(expectedId, articleServiceClas.Id);
            Assert.Equal(expectedName, articleServiceClas.Name);
            Assert.Equal(expectedDescription, articleServiceClas.Description);
            Assert.Equal(expectedUserId, articleServiceClas.UserId);
            Assert.Equal(expectedUser, articleServiceClas.User);
        }

        [Fact]
        public void ArticleServiceClas_SetInvalidId_ThrowsException()
        {
            // Arrange
            var articleServiceClas = new ArticleServiceClas();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => articleServiceClas.Id = -1);
        }

        [Fact]
        public void ArticleServiceClas_SetInvalidUserId_ThrowsException()
        {
            // Arrange
            var articleServiceClas = new ArticleServiceClas();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => articleServiceClas.UserId = -1);
        }

        [Fact]
        public void ArticleServiceClas_SetEmptyName_ThrowsException()
        {
            // Arrange
            var articleServiceClas = new ArticleServiceClas();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => articleServiceClas.Name = string.Empty);
        }

        [Fact]
        public void ArticleServiceClas_SetEmptyDescription_ThrowsException()
        {
            // Arrange
            var articleServiceClas = new ArticleServiceClas();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => articleServiceClas.Description = string.Empty);
        }

        [Fact]
        public void ArticleServiceClas_SetEmptyUser_ThrowsException()
        {
            // Arrange
            var articleServiceClas = new ArticleServiceClas();

            // Act and Assert
            Assert.Throws<ArgumentException>(() => articleServiceClas.User = string.Empty);
        }
    }
}

