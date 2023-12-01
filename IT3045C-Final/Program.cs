using IT3045C_Final;
using IT3045C_Final.Controllers.Data;
using IT3045C_Final.Controllers.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("AppDb");
builder.Services.AddDbContext<GenInfoData>(options =>
    options.UseSqlServer("GenInfoData"));

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddOpenApiDocument();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();
    app.UseSwaggerUI();
}
/*using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<GenInfoData>();
    db.Database.Migrate();
}*/
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
