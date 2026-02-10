using FluentAssertions;
using Moq;
using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Infrastructure;
using SchoolManagementApi.Api.Repositories;
using System.Data;

namespace SchoolManagementApi.Tests.Repositories;

public sealed class StudentRepositoryTests
{
    [Fact]
    public async Task CreateAsync_UsesExecutor()
    {
        var connectionFactory = new Mock<IDbConnectionFactory>();
        var executor = new Mock<IDapperExecutor>();
        var connection = new Mock<IDbConnection>();

        connectionFactory.Setup(x => x.CreateConnection()).Returns(connection.Object);
        executor.Setup(x => x.ExecuteAsync(connection.Object, It.IsAny<string>(), It.IsAny<object>()))
            .ReturnsAsync(1);

        var repository = new StudentRepository(connectionFactory.Object, executor.Object);
        var student = new Student { Id = Guid.NewGuid(), FirstName = "Test", LastName = "User", GradeLevel = "Grade 1" };

        var id = await repository.CreateAsync(student);

        id.Should().Be(student.Id);
        executor.Verify(x => x.ExecuteAsync(connection.Object, It.IsAny<string>(), It.IsAny<object>()), Times.Once);
    }
}
