using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TodoTask.Api.Extensions;
using TodoTask.Api.Filters;
using TodoTask.Application.Configuration;
using TodoTask.Infrastructure.Configuration;
using TodoTask.Infrastructure.Persistence.Database;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

// Add services to the container.
builder.Services.AddControllers(options =>
{
    options.Filters.Add<ApiResponseFilter>();
});

builder.Services.AddMvc().AddNewtonsoftJson(s => {
    s.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
});


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddDatabase(connectionString);
builder.Services.AddApplicationAdapters();

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

app.UseErrorHandlerMiddleware();

app.Run();
