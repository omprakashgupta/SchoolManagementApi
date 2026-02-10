using AutoMapper;
using FluentAssertions;
using Moq;
using SchoolManagementApi.Api.DTOs.Students;
using SchoolManagementApi.Api.Entities;
using SchoolManagementApi.Api.Mappings;
using SchoolManagementApi.Api.Repositories;
using SchoolManagementApi.Api.Services;

namespace SchoolManagementApi.Tests.Services;

public sealed class StudentServiceTests
{
    [Fact]
    public async Task CreateAsync_ReturnsId_WhenRepositoryCreates()
    {
        var repository = new Mock<IStudentRepository>();
        var sanitizer = new Mock<IInputSanitizer>();
        var mapper = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>()).CreateMapper();
        var dto = new StudentCreateDto
        {
            FirstName = "Alex",
            LastName = "Stone",
            DateOfBirth = new DateTime(2010, 5, 1),
            GradeLevel = "Grade 8",
            Email = "alex@example.com",
            Phone = "123456"
        };

        sanitizer.Setup(x => x.Sanitize(dto)).Returns(dto);
        repository.Setup(x => x.CreateAsync(It.IsAny<Student>())).ReturnsAsync(Guid.NewGuid());

        var service = new StudentService(repository.Object, mapper, sanitizer.Object);

        var result = await service.CreateAsync(dto);

        result.Should().NotBe(Guid.Empty);
        repository.Verify(x => x.CreateAsync(It.IsAny<Student>()), Times.Once);
    }
}
