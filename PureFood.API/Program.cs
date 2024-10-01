using AutoMapper;
using AutoMapper.Internal;
using Microsoft.OpenApi.Models;
using PureFood.API;
using PureFood.API.AutoMappers;
using PureFood.API.Extensions;
using PureFood.API.Services;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
// Add services to the container.
builder.Services.ConfigureIdentity();
builder.Services.ConfigureCors();
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureServiceManager();
builder.Services.ConfigureJwtSetting(builder.Configuration);
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.ConfigureTokenAndManagerIdentity();
builder.Services.AddCustomJwtAuthentication(configuration);
builder.Services.AddSwaggerGen(option =>
{


    option.AddSecurityDefinition(name: "Bearer", securityScheme: new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Description = "Enter the Bearer Authorization string as following: `Bearer Generated-JWT-Token`",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        BearerFormat = "JWT",
        Scheme = "Bearer"
    });

    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
      {
        new OpenApiSecurityScheme
        {
          Reference = new OpenApiReference
          {
            Type = ReferenceType.SecurityScheme,
            Id = "Bearer"
          },
            In = ParameterLocation.Header,
                Scheme = "Bearer",
                Name = "Authorization",
                BearerFormat = "JWT"
        },
        Array.Empty<string>()
      }
    });
});
var mapperConfig = new MapperConfiguration(mc =>
{
    mc.Internal().MethodMappingEnabled = false;
    mc.AddProfile(new MappingProfiles());
});
builder.Services.AddAutoMapper(cfg => cfg.Internal().MethodMappingEnabled = false, typeof(Program).Assembly);
builder.Services.ConfigureSqlContext(configuration);
//builder.Services.AddExceptionHandler<GlobalExceptionHandler>();



builder.Services.AddControllers();
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
app.UseCors("CorsPolicy");
app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();
app.MapControllers();
app.MigrationDatabase();
app.Run();
