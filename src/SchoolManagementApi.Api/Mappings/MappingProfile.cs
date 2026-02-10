using AutoMapper;
using SchoolManagementApi.Api.DTOs.Announcements;
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
using SchoolManagementApi.Api.Entities;

namespace SchoolManagementApi.Api.Mappings;

public sealed class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Student, StudentDto>().ReverseMap();
        CreateMap<StudentCreateDto, Student>();
        CreateMap<StudentUpdateDto, Student>();

        CreateMap<Teacher, TeacherDto>().ReverseMap();
        CreateMap<TeacherCreateDto, Teacher>();
        CreateMap<TeacherUpdateDto, Teacher>();

        CreateMap<ClassRoom, ClassDto>().ReverseMap();
        CreateMap<ClassCreateDto, ClassRoom>();
        CreateMap<ClassUpdateDto, ClassRoom>();

        CreateMap<FeeRecord, FeeDto>().ReverseMap();
        CreateMap<FeeCreateDto, FeeRecord>();
        CreateMap<FeeUpdateDto, FeeRecord>();

        CreateMap<LibraryBook, LibraryBookDto>().ReverseMap();
        CreateMap<LibraryBookCreateDto, LibraryBook>();
        CreateMap<LibraryBookUpdateDto, LibraryBook>();

        CreateMap<TransportRoute, TransportRouteDto>().ReverseMap();
        CreateMap<TransportRouteCreateDto, TransportRoute>();
        CreateMap<TransportRouteUpdateDto, TransportRoute>();

        CreateMap<AttendanceRecord, AttendanceDto>().ReverseMap();
        CreateMap<AttendanceCreateDto, AttendanceRecord>();
        CreateMap<AttendanceUpdateDto, AttendanceRecord>();

        CreateMap<TimetableEntry, TimetableDto>().ReverseMap();
        CreateMap<TimetableCreateDto, TimetableEntry>();
        CreateMap<TimetableUpdateDto, TimetableEntry>();

        CreateMap<GradeRecord, GradeDto>().ReverseMap();
        CreateMap<GradeCreateDto, GradeRecord>();
        CreateMap<GradeUpdateDto, GradeRecord>();

        CreateMap<HomeworkAssignment, HomeworkDto>().ReverseMap();
        CreateMap<HomeworkCreateDto, HomeworkAssignment>();
        CreateMap<HomeworkUpdateDto, HomeworkAssignment>();

        CreateMap<ExamSchedule, ExamDto>().ReverseMap();
        CreateMap<ExamCreateDto, ExamSchedule>();
        CreateMap<ExamUpdateDto, ExamSchedule>();

        CreateMap<Message, MessageDto>().ReverseMap();
        CreateMap<MessageCreateDto, Message>();
        CreateMap<MessageUpdateDto, Message>();

        CreateMap<Announcement, AnnouncementDto>().ReverseMap();
        CreateMap<AnnouncementCreateDto, Announcement>();
        CreateMap<AnnouncementUpdateDto, Announcement>();

        CreateMap<InventoryAsset, InventoryDto>().ReverseMap();
        CreateMap<InventoryCreateDto, InventoryAsset>();
        CreateMap<InventoryUpdateDto, InventoryAsset>();

        CreateMap<HealthRecord, HealthDto>().ReverseMap();
        CreateMap<HealthCreateDto, HealthRecord>();
        CreateMap<HealthUpdateDto, HealthRecord>();
    }
}
