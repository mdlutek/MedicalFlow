using DevExpress.Xpo.DB;
using MedicalFlow.Infrastructure.Xpo;
using Microsoft.Data.SqlClient; // Wymagany using

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 1. Wymuszenie załadowania biblioteki Microsoft.Data.SqlClient do pamięci procesu
_ = typeof(SqlConnection);

// 2. Jawna rejestracja dostawcy MSSql w XPO
MSSqlConnectionProvider.Register();

// 1. Pobieramy ConnectionString i inicjalizujemy XPO dla całego serwisu
string connStr = builder.Configuration.GetConnectionString("MedicalFlowDb");
XpoConnectionHelper.InitXpo(connStr);
XpoConnectionHelper.SeedInitialData();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

//app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();

app.Run();
