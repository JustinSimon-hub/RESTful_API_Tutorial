﻿using Microsoft.EntityFrameworkCore;
using REST_API_Tutorial2nd.Data;



var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddDbContext<APIcontext>
    (opt => opt.UseInMemoryDatabase("BookingDB"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

