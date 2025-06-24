using client.Infrastructure.Repo;
using Microsoft.EntityFrameworkCore;
using server.Application.Interfaces;
using server.Application.Services;
using server.Domain.Interfaces;
using server.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// +
var AllowSpecificOrigins = "_myAllowSpecificOrigins";
// +

builder.Services.AddControllers();
builder.Services.AddOpenApi();

// +
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
        ?? throw new InvalidOperationException("No connections string was found");

builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddScoped<ITestService, TestService>();
builder.Services.AddScoped<ITestRepo, TestRepo>();

builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddCors(options =>
{
    options.AddPolicy(AllowSpecificOrigins,
                          policy => {
                              policy
                                .AllowAnyHeader()
                                .AllowAnyMethod()
                                .AllowAnyOrigin();
                          });
});

builder.Services.AddHttpContextAccessor();
// +

var app = builder.Build();

//+
app.UseStaticFiles();
//+

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

//+
app.UseCors(AllowSpecificOrigins);
//+

app.MapControllers();

app.Run();
