using Microsoft.EntityFrameworkCore;
using TesteArq.API.Middlewares;
using TesteArq.Application.Interface;
using TesteArq.Application.Mappings;
using TesteArq.Application.Service;
using TesteArq.Data.Context;
using TesteArq.Data.Interface;
using TesteArq.Data.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ProjDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IAlunoService, AlunoService>();
builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();
builder.Services.AddScoped<ICursoService, CursoSerivce>();
builder.Services.AddScoped<ICursoRepository, CursoRepository>();
builder.Services.AddAutoMapper(typeof(DtoMappingProfile));


var app = builder.Build();
app.UseMiddleware<ExceptionMiddleware>();
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
