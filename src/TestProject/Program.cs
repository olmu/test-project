using TestProject.BL.Handlers;
using TestProject.BL.Requests;
using TestProject.BL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(Program));


builder.Services.AddSingleton<IRequestHandler<RegisterCustomerBlRequest, RegisterCustomerBlResponse>, RegisterCustomerHandler>();
builder.Services.AddSingleton<IRequestHandler<GetCustomerInfoBlRequest, GetCustomerInfoBlResponse>, GetCustomerInfoHandler>();
builder.Services.AddSingleton<IRequestHandler<GetCustomerBalanceBlRequest, GetCustomerBalanceBlResponse>, GetCustomerBalanceHandler>();

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
