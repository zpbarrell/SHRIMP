using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Shrimp.Data;
using Shrimp.Services.School;
using Shrimp.Services.District;
using Shrimp.Services.House;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<ISchoolService, SchoolService>();
builder.Services.AddScoped<IDistrictService, DistrictService>();
builder.Services.AddScoped<IHouseService, HouseService>();

//REMEMBER THIS
builder.Services.AddControllers().AddJsonOptions(x =>
x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
 {
     c.SwaggerDoc("v1", new OpenApiInfo { Title = "Shrimp.WebAPI", Version = "v1" });
    });


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
