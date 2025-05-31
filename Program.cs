using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// ✅ Add CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.WithOrigins("http://localhost:5173") // your Vite frontend
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

// Add other services like authentication, EF Core, etc.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "SmartBikePOS API", Version = "v1" });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// ✅ Enable CORS before authorization
app.UseCors("AllowFrontend");

app.UseHttpsRedirection();

app.UseAuthentication(); // if using JWT
app.UseAuthorization();

app.MapControllers();

app.Run();