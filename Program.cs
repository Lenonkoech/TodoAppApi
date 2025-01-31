using Microsoft.EntityFrameworkCore;
using TodoApp.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
/*======Services======*/
//Database service
builder.Services.AddDbContext<TodoContext>(opt =>
opt.UseInMemoryDatabase("TodoList"));

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
