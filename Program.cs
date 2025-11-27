using Microsoft.EntityFrameworkCore;
using Services_Customer_Service.Models.Context;
using SLAging;
using SLAging.Data;

var builder = WebApplication.CreateBuilder(args);
builder.WebHost.UseUrls("http://0.0.0.0:5100");


builder.Services.AddDbContext<SEAT03Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SeaT03")));

builder.Services.AddDbContext<SEADWContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SeaDW")));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
