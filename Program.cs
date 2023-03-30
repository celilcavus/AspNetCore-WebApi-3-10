using CelilCavus.OgrenciKayitSistemi.Context;
using CelilCavus.OgrenciKayitSistemi.Controllers;
using CelilCavus.OgrenciKayitSistemi.Entites;
using CelilCavus.OgrenciKayitSistemi.Interface;
using CelilCavus.OgrenciKayitSistemi.Service;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllers();
        builder.Services.AddScoped<DbContext, KayitSistemiContext>();
        builder.Services.AddScoped<IRepository<Ogrenci>, OgrenciService>();
        builder.Services.AddScoped<IRepository<Dersler>, DersService>();
        builder.Services.AddEndpointsApiExplorer();


        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {

        }

        app.UseHttpsRedirection();

        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
}