using DAL.Repositories;
using Logic.IRepositories;
using Logic.IServices;
using Logic.Services;
using MongoDB.Driver;
using Newtonsoft.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
using DotNetEnv;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//!TODO add env handling for kuber

var connectionString = Env.GetString("DB_URL");
var databaseName = Env.GetString("DB_NAME");

var connectionUrl = connectionString;
var connectionDatabase = databaseName;
var mongoClient = new MongoClient(connectionUrl);
var mongoDatabase = mongoClient.GetDatabase(connectionDatabase);
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
