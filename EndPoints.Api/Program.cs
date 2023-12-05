using Carwash.Application.Interface;
using Carwash.Application.Service.Cars.Commands.Create;
using Carwash.Application.Service.Cars.Commands.Delete;
using Carwash.Application.Service.Cars.Commands.SaveCar;
using Carwash.Application.Service.Cars.Commands.Update;
using Carwash.Application.Service.Cars.Queries.GetCar;
using Carwash.Application.Service.Cars.Queries.GetCarById;
using Carwash.Application.Service.Cars.Queries.SearchCar;
using Carwash.Application.Service.Histories.Queries;
using Carwash.Application.Service.Jwt;
using Carwash.Application.Service.Khadamats.Commands.Create;
using Carwash.Application.Service.Khadamats.Commands.Delete;
using Carwash.Application.Service.Khadamats.Commands.SaveKhadamat;
using Carwash.Application.Service.Khadamats.Commands.Update;
using Carwash.Application.Service.Khadamats.Queries.GetKhadamat;
using Carwash.Application.Service.Khadamats.Queries.GetKhadamatById;
using Carwash.Application.Service.Khadamats.Queries.SearchKhadamat;
using Carwash.Application.Service.Managers.Commands.Create;
using Carwash.Application.Service.Managers.Commands.Delete;
using Carwash.Application.Service.Managers.Queries;
using Carwash.Application.Service.WorkerInKhadamats.Commands.Create;
using Carwash.Application.Service.WorkerInKhadamats.Queries.GetWorkerInKhadamat;
using Carwash.Application.Service.Workers.Command.Create;
using Carwash.Application.Service.Workers.Command.Delete;
using Carwash.Application.Service.Workers.Command.SaveWorker;
using Carwash.Application.Service.Workers.Command.Update;
using Carwash.Application.Service.Workers.Queries.GetWorker;
using Carwash.Application.Service.Workers.Queries.GetWorkerById;
using Carwash.Application.Service.Workers.Queries.SearchWorker;
using Carwash.Infrastructure.Context;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//HttpContextAccessor

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("sql")));
//DbContext
builder.Services.AddScoped<IAppDbContext, AppDbContext>();

//Worker
builder.Services.AddScoped<IGetWorkerService, GetWorkerService>();
builder.Services.AddScoped<IGetWorkerByIdService, GetWorkerByIdService>();
builder.Services.AddScoped<ICreateWorkerService, CreateWorkerService>();
builder.Services.AddScoped<IDeleteWorkerService, DeleteWorkerService>();
builder.Services.AddScoped<IUpdateWorkerService, UpdateWorkerService>();
builder.Services.AddScoped<ISaveWorkerService, SaveWorkerService>();
builder.Services.AddScoped<ISearchWorkerService, SearchWorkerService>();

//Khadamat

builder.Services.AddScoped<IGetKhadamatService, GetKhadamatService>();
builder.Services.AddScoped<IGetKhadamatByIdService, GetKhadamatByIdService>();
builder.Services.AddScoped<ICreateKhadamatService, CreateKhadamatService>();
builder.Services.AddScoped<IDeleteKhadamatService, DeleteKhadamatService>();
builder.Services.AddScoped<ISearchKhadamatService, SearchKhadamatService>();
builder.Services.AddScoped<ISaveKhadamatService, SaveKhadamatService>();
builder.Services.AddScoped<IUpdateKhadamatService, UpdateKhadamatService>();

//Car

builder.Services.AddScoped<IGetCarService, GetCarService>();
builder.Services.AddScoped<IGetCarByIdService, GetCarByIdService>();
builder.Services.AddScoped<ICreateCarService, CreateCarService>();
builder.Services.AddScoped<IDeleteCarService, DeleteCarService>();
builder.Services.AddScoped<IUpdateCarService, UpdateCarService>();
builder.Services.AddScoped<ISearchCarService, SearchCarService>();
builder.Services.AddScoped<ISaveCarService, SaveCarService>();

//Manager
builder.Services.AddScoped<IGetManagerService, GetManagerService>();    
builder.Services.AddScoped<ICreateManagerService, CreateManagerService>();
builder.Services.AddScoped<IDeleteManagerService, DeleteManagerService>();

//History
builder.Services.AddScoped<IGetHistoryService, GetHistoryService>();
//WorkerInKhadamat
builder.Services.AddScoped<ICreateWorkerInKhadamatService, CreateWorkerInKhadamatService>();
builder.Services.AddScoped<IGetWorkerInKhadamat, GetWorkerInKhadamat>();


//Jwt
builder.Services.AddScoped<IJwtService, JwtService>();

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(option =>
{
     var Key = Encoding.UTF8.GetBytes(builder.Configuration["Autentication:Key"]);
    option.SaveToken = true;
    option.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Autentication:Issuer"],
        ValidAudience = builder.Configuration["Autentication:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Key)
    };
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

