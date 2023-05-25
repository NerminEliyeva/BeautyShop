using BeautyShop.DAL.Abstract.IRepository;
using BeautyShop.DAL.Concrete.Entity;
using BeautyShop.DAL.Concrete.Repository;
using BeautyShop.Services.Interfaces;
using BeautyShop.Services.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IRepositoryWrapper, RepositoryWrapper>();
builder.Services.AddTransient<ICategoryBrandService, CategoryBrandService>();

builder.Services.AddDbContext<BeautyShopDbContext>(_ => _.UseSqlServer(builder.Configuration["ConnectionStrings:ConnectionString"]));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
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
