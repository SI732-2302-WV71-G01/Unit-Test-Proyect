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

            // Act
            articleServiceClas.Id = expectedId;
            articleServiceClas.Name = expectedName;
            articleServiceClas.Description = expectedDescription;
            articleServiceClas.UserId = expectedUserId;

            // Assert
            Assert.Equal(expectedId, articleServiceClas.Id);
            Assert.Equal(expectedName, articleServiceClas.Name);
            Assert.Equal(expectedDescription, articleServiceClas.Description);
            Assert.Equal(expectedUserId, articleServiceClas.UserId);
        }
    }
}
