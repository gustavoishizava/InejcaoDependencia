using InjecaoDependencia.Application;
using InjecaoDependencia.Service;
using InjecaoDependencia.Workers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<ISingletonService, Service>();
builder.Services.AddScoped<IScopedService, Service>();
builder.Services.AddTransient<ITransientService, Service>();

builder.Services.AddTransient<IApplicationOne, Application>();
builder.Services.AddTransient<IApplicationTwo, Application>();

builder.Services.AddHostedService<Worker>();

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
