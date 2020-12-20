using System;
using Xunit;

using MonarchsApi.Repositories;

namespace MonarchsApiTest
{
    public class RepositoryTests
    {
        [Fact]
        public void GetMonarchsTest()
        {
            // Arrange
            IMonarchsRepository repository = new MonarchsRepository("./Data/monarchs.json");

            // Act
            var result = repository.GetMonarchs();

            // Assert
            Assert.IsType<String>(result);
            Assert.NotNull(result);
        }
    }
}
