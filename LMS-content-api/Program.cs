using DAL.Repositories;
using Logic.IRepositories;
using Logic.IServices;
using Logic.Services;
using MongoDB.Driver;
using Newtonsoft.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var mongoClient = new MongoClient("mongodb://localhost:27017");
var mongoDatabase = mongoClient.GetDatabase("testDBtest");
builder.Services.AddSingleton<IMongoDatabase>(mongoDatabase);
builder.Services.AddScoped<IContentRepository, ContentRepository>();
builder.Services.AddScoped<IContentService, ContentService>();

builder.Services.AddControllers()
	.AddNewtonsoftJson(options =>
	{
		options.SerializerSettings.TypeNameHandling = TypeNameHandling.Auto;
	});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

Console.Write(app);

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
