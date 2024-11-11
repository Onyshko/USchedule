using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using USchedule.Domain.Entities;
using USchedule.Repository.Context;
using USchedule.Repository.Utility.SeedConfiguration;
using USchedule.Shared.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddUserSecrets<Program>();


var connectionStringJson = builder.Configuration["ConnectionStrings"];
var connectionString = JsonConvert.DeserializeObject<Dictionary<string, object>>(connectionStringJson!);

builder.Services.AddDbContext<DatabaseContext>(opts =>
    opts.UseSqlServer(connectionString!["ConnectionString"].ToString()));

builder.Services.AddIdentity<User, Role>(opt =>
{
    opt.Password.RequiredLength = 7;
})
.AddEntityFrameworkStores<DatabaseContext>()
.AddDefaultTokenProviders();

builder.Services.Configure<DataProtectionTokenProviderOptions>(opt =>
    opt.TokenLifespan = TimeSpan.FromHours(2));



var superAdminJson = builder.Configuration["SuperAdmin"];
var superAdmin = JsonConvert.DeserializeObject<SuperAdminModel>(superAdminJson!);

builder.Services.AddSingleton(superAdmin!);



builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        await DataInitializer.InitializeRolesAndSuperAdmin(services);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error creating roles or super admin: {ex.Message}");
    }
}


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
