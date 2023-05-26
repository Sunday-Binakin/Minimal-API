using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SixminApi.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//sql connection
/**
var SqlConnectionBuilder = new SqlConnectionStringBuilder();
SqlConnectionBuilder.ConnectionString = builder.Configuration.GetConnectionString("SQLDbConnection");
SqlConnectionBuilder.UserID = builder.Configuration["UserId"];
SqlConnectionBuilder.Password = builder.Configuration["Password"];

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(SqlConnectionBuilder.ConnectionString));
**/
var connectionString = builder.Configuration.GetConnectionString("SQLDbConnection");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<ICommandRepo, CommandRepo>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
