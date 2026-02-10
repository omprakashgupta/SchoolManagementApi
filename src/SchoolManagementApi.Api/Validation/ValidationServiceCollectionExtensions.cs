using FluentValidation;
using SchoolManagementApi.Api.DTOs.Announcements;
using SchoolManagementApi.Api.DTOs.Auth;
using SchoolManagementApi.Api.DTOs.Attendance;
using SchoolManagementApi.Api.DTOs.Classes;
using SchoolManagementApi.Api.DTOs.Exams;
using SchoolManagementApi.Api.DTOs.Fees;
using SchoolManagementApi.Api.DTOs.Grades;
using SchoolManagementApi.Api.DTOs.Health;
using SchoolManagementApi.Api.DTOs.Homework;
using SchoolManagementApi.Api.DTOs.Inventory;
using SchoolManagementApi.Api.DTOs.Library;
using SchoolManagementApi.Api.DTOs.Messaging;
using SchoolManagementApi.Api.DTOs.Students;
using SchoolManagementApi.Api.DTOs.Teachers;
using SchoolManagementApi.Api.DTOs.Timetable;
using SchoolManagementApi.Api.DTOs.Transport;

namespace SchoolManagementApi.Api.Validation;

public static class ValidationServiceCollectionExtensions
{
    public static IServiceCollection AddSchoolValidators(this IServiceCollection services)
    {
        services.AddScoped<IValidator<StudentCreateDto>, StudentCreateDtoValidator>();
        services.AddScoped<IValidator<StudentUpdateDto>, StudentUpdateDtoValidator>();
        services.AddScoped<IValidator<TeacherCreateDto>, TeacherCreateDtoValidator>();
        services.AddScoped<IValidator<TeacherUpdateDto>, TeacherUpdateDtoValidator>();
        services.AddScoped<IValidator<ClassCreateDto>, ClassCreateDtoValidator>();
        services.AddScoped<IValidator<ClassUpdateDto>, ClassUpdateDtoValidator>();
        services.AddScoped<IValidator<FeeCreateDto>, FeeCreateDtoValidator>();
        services.AddScoped<IValidator<FeeUpdateDto>, FeeUpdateDtoValidator>();
        services.AddScoped<IValidator<LibraryBookCreateDto>, LibraryBookCreateDtoValidator>();
        services.AddScoped<IValidator<LibraryBookUpdateDto>, LibraryBookUpdateDtoValidator>();
        services.AddScoped<IValidator<IssueBookDto>, IssueBookDtoValidator>();
        services.AddScoped<IValidator<ReturnBookDto>, ReturnBookDtoValidator>();
        services.AddScoped<IValidator<TransportRouteCreateDto>, TransportRouteCreateDtoValidator>();
        services.AddScoped<IValidator<TransportRouteUpdateDto>, TransportRouteUpdateDtoValidator>();
        services.AddScoped<IValidator<TransportAlertDto>, TransportAlertDtoValidator>();
        services.AddScoped<IValidator<AttendanceCreateDto>, AttendanceCreateDtoValidator>();
        services.AddScoped<IValidator<AttendanceUpdateDto>, AttendanceUpdateDtoValidator>();
        services.AddScoped<IValidator<BiometricAttendanceHookDto>, BiometricAttendanceHookDtoValidator>();
        services.AddScoped<IValidator<TimetableCreateDto>, TimetableCreateDtoValidator>();
        services.AddScoped<IValidator<TimetableUpdateDto>, TimetableUpdateDtoValidator>();
        services.AddScoped<IValidator<GradeCreateDto>, GradeCreateDtoValidator>();
        services.AddScoped<IValidator<GradeUpdateDto>, GradeUpdateDtoValidator>();
        services.AddScoped<IValidator<HomeworkCreateDto>, HomeworkCreateDtoValidator>();
        services.AddScoped<IValidator<HomeworkUpdateDto>, HomeworkUpdateDtoValidator>();
        services.AddScoped<IValidator<ExamCreateDto>, ExamCreateDtoValidator>();
        services.AddScoped<IValidator<ExamUpdateDto>, ExamUpdateDtoValidator>();
        services.AddScoped<IValidator<MessageCreateDto>, MessageCreateDtoValidator>();
        services.AddScoped<IValidator<MessageUpdateDto>, MessageUpdateDtoValidator>();
        services.AddScoped<IValidator<AnnouncementCreateDto>, AnnouncementCreateDtoValidator>();
        services.AddScoped<IValidator<AnnouncementUpdateDto>, AnnouncementUpdateDtoValidator>();
        services.AddScoped<IValidator<InventoryCreateDto>, InventoryCreateDtoValidator>();
        services.AddScoped<IValidator<InventoryUpdateDto>, InventoryUpdateDtoValidator>();
        services.AddScoped<IValidator<HealthCreateDto>, HealthCreateDtoValidator>();
        services.AddScoped<IValidator<HealthUpdateDto>, HealthUpdateDtoValidator>();
        services.AddScoped<IValidator<LoginRequestDto>, LoginRequestDtoValidator>();

        return services;
    }
}
