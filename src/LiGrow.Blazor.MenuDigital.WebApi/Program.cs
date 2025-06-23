using DotNetEnv;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

Env.Load();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
   c.AddSecurityDefinition("ApiKey", new OpenApiSecurityScheme
   {
      Description = "Chave de autenticação via header. Ex: X-API-KEY: <chave>",
      In = ParameterLocation.Header,
      Name = "X-API-KEY",
      Type = SecuritySchemeType.ApiKey,
      Scheme = "ApiKeyScheme"
   });
   
   c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "ApiKey"
                }
            },
            new string[] {}
        }
    });
});

builder.Services.AddCors(options =>
{
   options.AddDefaultPolicy(builder =>
   {
      builder.AllowAnyOrigin()
             .AllowAnyMethod()
             .AllowAnyHeader();
   });
});

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
