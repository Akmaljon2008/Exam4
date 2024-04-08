using Infrastracture.Data;
using Infrastracture.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<DapperContext>();
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<ITeacherService, TeacherService>();
builder.Services.AddScoped<IParentService, ParentService>();
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<IGradeService, GradeService>();
builder.Services.AddScoped<IClassroomService, ClassroomService>();
builder.Services.AddScoped<IAttendencyService, AttendancyService>();
builder.Services.AddScoped<IExamTypeService, ExamTypeService>();
builder.Services.AddScoped<IClassroomStudentService, ClassroomStudentService>();
builder.Services.AddScoped<IExamService, ExamService>();
builder.Services.AddScoped<IExamResultService, ExamResultService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();
app.Run();


