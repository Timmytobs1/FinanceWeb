using Microsoft.EntityFrameworkCore;
using ValeFinanceWeb.Data;
using ValeFinanceWeb.Interface;
using ValeFinanceWeb.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ValeFinanceContext>(options => {
    options.UseMySQL(builder.Configuration.GetConnectionString("ValeFinancePortal"));
});


builder.Services.AddScoped<IInterestRateRepository, InterestRateRepository>();
//builder.Services.AddScoped<IProductRepository, ProductRepository>();

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
