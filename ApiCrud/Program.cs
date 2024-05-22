using ApiCrud.Models;
using ApiCrud.Pessoa;
using ApiCrud.Routes;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();
var dbContext = new NobreNavalhaBarbeariaDbContext();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
Console.WriteLine("APLICAÇÃO RODANDO...");

//Rotas
app.Health();
app.CriaPessoa(dbContext);

// HealthRoute.Health(app);

app.Run();

