using System;
using Xunit;
using System.Collections.Generic;

using MonarchsApi.Repositories;
using MonarchsApi.Services;
using MonarchsApi.Models;

namespace MonarchsApiTest
{
    public class ServiceTests
    {
        [Fact]
        public void GetMonarchsTest()
        {
            // Arrange
            IMonarchsRepository repository = new MonarchsRepository("./Data/monarchs.json");
            IMonarchsService service = new MonarchsService(repository);

            // Act
            var result = service.GetMonarchs();

            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<Monarch>>(result);
            Assert.Equal(57, result.Count);
        }
    }
}
