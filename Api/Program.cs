using Module.Customers.Infraestructure;
using Module.Orders.Infraestructure;
using Modules.Products.Infraestructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddSharedModule(builder.Configuration);

builder.Services.AddCustomerModule(builder.Configuration);
builder.Services.AddOrdersModule(builder.Configuration);
builder.Services.AddProductsModule(builder.Configuration);


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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
