using AutoMapper;
using Microsoft.EntityFrameworkCore;
using TestTaskOSKI.DataAccess.DBContext;
using TestTaskOSKI.DataAccess.Interfaces;
using TestTaskOSKI.DataAccess.Repositories;
using TestTaskOSKI.DTO;
using TestTaskOSKI.Services.ServicesInterfaces;
using TestTaskOSKI.Services.TestsServices;

var builder = WebApplication.CreateBuilder(args);

var conStr = builder.Configuration.GetConnectionString("DefaultConnection");
var db = builder.Services.AddDbContext<TestAppContext>(options => options.UseSqlServer(conStr));
// Add services to the container.

builder.Services.AddControllersWithViews();

var mappingConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MapperDTO());
});
IMapper mapper = mappingConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddSingleton<ITests, Tests>();
builder.Services.AddSingleton<ITestServices, TestsServices>();
builder.Services.AddSingleton<IUsers, Users>();
builder.Services.AddSingleton<ILoginService, LoginService>();
builder.Services.AddSingleton<IQuestions, Questions>();
builder.Services.AddSingleton<IAnswers, Answers>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();


app.MapControllers();

app.MapFallbackToFile("index.html"); ;

app.Run();
