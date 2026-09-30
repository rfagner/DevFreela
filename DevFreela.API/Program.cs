using DevFreela.API.Models;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddOpenApi();

builder.Services.Configure<OpeningTimeOption>(builder.Configuration.GetSection("OpeningTime"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Gera o JSON da spec em /openapi/v1.json
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();

    // UI do Scalar em /scalar/v1
    app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
