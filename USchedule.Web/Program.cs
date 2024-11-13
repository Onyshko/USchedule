using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.Text;
using USchedule.Domain.Entities;
using USchedule.Repository.Context;
using USchedule.Repository.Models;
using USchedule.Repository.Utility.Registrations;
using USchedule.Repository.Utility.SeedConfiguration;
using USchedule.Service.Utility.Exceptions;
using USchedule.Service.Utility.Registrations;
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

var jwtSettingsJson = builder.Configuration["JWTSettings"];
var jwtSettings = JsonConvert.DeserializeObject<JwtSettingsModel>(jwtSettingsJson!);
builder.Services.AddAuthentication(opt =>
{
    opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtSettings!.ValidIssuer!.ToString(),
        ValidAudience = jwtSettings.ValidAudience!.ToString(),
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SecurityKey!.ToString()!))
    };
    builder.Configuration.Bind("JwtSettings", options);
});

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("OnlyAdminUsers",
        policy => policy.RequireRole("Admin", "SuperAdmin"));
});


var superAdminJson = builder.Configuration["SuperAdmin"];
var superAdmin = JsonConvert.DeserializeObject<SuperAdminModel>(superAdminJson!);

var emailConfigurationJson = builder.Configuration["EmailConfiguration"];
var emailConfiguration = JsonConvert.DeserializeObject<EmailConfiguration>(emailConfigurationJson!);

builder.Services.AddSingleton(superAdmin!);
builder.Services.AddSingleton(jwtSettings!);
builder.Services.AddSingleton(emailConfiguration!);



builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddRepositoryLayerRegistration();
builder.Services.AddServiceLayerRegistration();


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

app.ConfigureCustomExceptionMiddleware();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
