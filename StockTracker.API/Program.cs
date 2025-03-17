using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using StockTracker.Business.Abstract;
using StockTracker.Business.Concrete;
using StockTracker.Business.Configuration;
using StockTracker.Business.Mapping;
using StockTracker.Data.Abstract;
using StockTracker.Data.Concrete.Context;
using StockTracker.Data.Concrete.Repositories;
using StockTracker.Entity.Concrete;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        var connectionString = builder.Configuration.GetConnectionString("SQLiteConnection");

        builder.Services.AddDbContext<StockTrackerDbContext>(options =>
            options.UseSqlite(connectionString));


        builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
        builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        builder.Services.AddScoped<IAuthService, AuthService>();
        builder.Services.AddScoped<ICustomerService, CustomerService>();
        builder.Services.AddScoped<IRentalService, RentalService>();






        builder.Services.AddAutoMapper(typeof(MappingProfile));
        //Identity Ayarlar?
        builder.Services.AddIdentity<ApplicationUser, ApplicationRole>(options =>
        {
            options.Password.RequireDigit = true;
            options.Password.RequireUppercase = true;
            options.Password.RequireLowercase = true;
            options.Password.RequireNonAlphanumeric = true;
            options.Password.RequiredLength = 8;

            options.User.RequireUniqueEmail = true;
           

        }).AddEntityFrameworkStores<StockTrackerDbContext>().AddDefaultTokenProviders();


     
        builder.Services.Configure<JwtConfig>(builder.Configuration.GetSection("JwtConfig"));


        var jwtConfig = builder.Configuration.GetSection("JwtConfig").Get<JwtConfig>();

   
        builder.Services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = jwtConfig?.Issuer,
                ValidAudience = jwtConfig?.Audience,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtConfig?.Secret ?? ""))
            };
        });










        var app = builder.Build();

    


     
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}